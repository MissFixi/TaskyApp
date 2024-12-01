using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.IdentityModel.Tokens;
using TaskyAPI.Context;
using TaskyAPI.Migrations;
using TaskyAPI.Models;
using TaskyAPI.RequestModels;

namespace TaskyAPI.Controllers;

[Route("api/tasks")]
[ApiController]
public class TasksController : ControllerBase
{
    private readonly TaskyAppDbContext _context;

    public TasksController(TaskyAppDbContext context)
    {
        _context = context;
    }

    //could be added custom format issue feedback
    [HttpPost]
    public async Task<IActionResult> AddNewTask(UTaskModel uTask)
    {
        var newUTask = new UTask()
        {
            Heading = uTask.Heading,
            Priority = uTask.Priority,
            Description = uTask.Description,
            StartDate = uTask.StartDate,
            IdUser = uTask.IdUser,
            IsPublic = uTask.IsPublic
        };
        
        var userExists = await _context.Users.AnyAsync(u => u.IdUser == newUTask.IdUser);
        
        if (!userExists)
        {
            return BadRequest("Podany użytkownik nie istnieje");
        }

        var addTask = await _context.Tasks.AddAsync(newUTask);

        await _context.SaveChangesAsync();

        return Ok();
    }

    
    // Finish your or public task
    [HttpPut("{idUser:int}/{idTask:int}/finish")]
    public async Task<IActionResult> FinishTask(int idUser, int idTask, UTaskEndModel uTask)
    {
        var taskToFinish = await _context.Tasks.FindAsync(idTask);

        if (taskToFinish == null)
        {
            return BadRequest("Podane zadanie nie istnieje");
        }
        
        var doesUserExist = await _context.Users.AnyAsync(u => u.IdUser == idUser);

        if (!doesUserExist)
        {
            return BadRequest("User o podanym id nie istnieje");
        }
        
        if (taskToFinish.IsPublic == false && taskToFinish.IdUser != idUser)
        {
            return BadRequest("Nie masz uprawnień do usunięcia tego zadania");
        }
        
        if (taskToFinish.EndDate != null)
        {
            return BadRequest("Zadanie jest już zakończone");
        }

        if ((taskToFinish.StartDate > uTask.EndDate) || (uTask.EndDate >= DateTime.Now))
        {
            return BadRequest("Niepoprawna data zakończenia");
        }

        taskToFinish.EndDate = uTask.EndDate;
        if (taskToFinish.IdUser != idUser)
        {
            taskToFinish.IdUser = idUser;
        }
        
        await _context.SaveChangesAsync();
        
        return Ok();
        
    }
    
    //check your (Employee) tasks
    [HttpGet("{idUser:int}")]
    public async Task<IActionResult> ShowUserTasks(int idUser)
    {
        var doesUserExist = await _context.Users.AnyAsync(u => u.IdUser == idUser);

        if (!doesUserExist)
        {
            return BadRequest("User o podanym id nie istnieje");
        }

        var areTasksAssigned = await _context.Tasks.AnyAsync(t => t.IdUser == idUser);

        if (!areTasksAssigned)
        {
            return BadRequest("Podany użytkownik nie posiada żadnych zadań");
        }
        
        var userTasks = await _context.Tasks
            .Where(t => t.IdUser == idUser)
            .Select(t => new
            {
                t.IdTask,
                t.Heading,
                t.Priority,
                t.Description,
                t.StartDate,
                t.EndDate,
                t.IsPublic
            }
            ).ToListAsync();
        
        return Ok(userTasks);
    }
    
    [HttpGet("public")]
    public async Task<IActionResult> ShowPublicTasks()
    {
        var areAnyPublicTasks = await _context.Tasks.AnyAsync(t => t.IsPublic == false);

        if (!areAnyPublicTasks)
        {
            return BadRequest("Akualnie żaden użytkownik nie udostępnia swoich zadań");
        }
        
        var publicTasks = await _context.Tasks
            .Where(t => t.IsPublic == true)
            .Select(t => new
                {
                    t.IdTask,
                    t.Heading,
                    t.Priority,
                    t.Description,
                    t.StartDate,
                    t.EndDate,
                    t.TaskUser.FirstName,
                    t.TaskUser.LastName
                }
            ).ToListAsync();
        
        return Ok(publicTasks);
    }
    
    //check employees tasks
    //change how UTasks show
    [HttpGet("{idManager:int}/subordinates")]
    public async Task<IActionResult> ShowSubordinatesTasks(int idManager)
    {
        var areTasksAssigned = await _context.Tasks.AnyAsync(t => t.TaskUser.IdManager == idManager);

        if (!areTasksAssigned)
        {
            return BadRequest("Brak zadań do wyświetlenia");
        }
        
        var subordinatesTasks = await _context.Users
            .Where(u => u.IdManager == idManager)
            .Select(u => new
            {
                u.UTasks
            })
            .ToListAsync();
        
        return Ok(subordinatesTasks);

    }
    
    //delete task
    //thinking about deleting user id validation
    [HttpDelete("{idTask:int}")]
    public async Task<IActionResult> DeleteTask(int idTask, int idUser)
    {
        var taskToRemove = await _context.Tasks.FindAsync(idTask);
        
        if (taskToRemove == null)
        {
            return BadRequest("Zadanie o podanym id nie istnieje");
        }
        
        var doesUserExist = await _context.Users.AnyAsync(u => u.IdUser == idUser);

        if (!doesUserExist)
        {
            return BadRequest("User o podanym id nie istnieje");
        }
        
        if (taskToRemove.IsPublic == false && taskToRemove.IdUser != idUser)
        {
            return BadRequest("Nie masz uprawnień do usunięcia tego zadania");
        }

        _context.Tasks.Attach(taskToRemove);

        _context.Tasks.Remove(taskToRemove);
        
        await _context.SaveChangesAsync();
        
        return Ok();
    }
    
    //edit task
    [HttpPut("{idUser:int}/{idTask:int}/edit")]
    public async Task<IActionResult> EditTask(int idUser,int idTask, UTaskEditModel newTask)
    {
        var taskToEdit = await _context.Tasks.FindAsync(idTask);
        
        if (taskToEdit == null)
        {
            return BadRequest("Zadanie o podanym id nie istnieje");
        }
        
        var doesUserExist = await _context.Users.AnyAsync(u => u.IdUser == idUser);

        if (!doesUserExist)
        {
            return BadRequest("User o podanym id nie istnieje");
        }
        
        if (taskToEdit.IsPublic == false && taskToEdit.IdUser != idUser)
        {
            return BadRequest("Nie masz uprawnień do edytowania tego zadania");
        }
        
        taskToEdit.Heading = newTask.Heading;
        taskToEdit.Priority = newTask.Priority;
        taskToEdit.Description = newTask.Description;
        taskToEdit.IsPublic = newTask.IsPublic;
        
        await _context.SaveChangesAsync();
        
        return Ok();
        
    }
    
    //procedure to check statistics for manager
    [HttpGet("{idManager:int}/statistics")]
    public async Task<IActionResult> GetStatistics(int idManager)
    {
        return Ok();
    }
}