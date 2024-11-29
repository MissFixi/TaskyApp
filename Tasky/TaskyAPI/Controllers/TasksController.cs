using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using TaskyAPI.Context;
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
        
        //check heading and description lenght, check priority
        var userExists = await _context.Users.AnyAsync(u => u.IdUser == newUTask.IdUser);
        
        if (!userExists)
        {
            return BadRequest("Podany użytkownik nie istnieje");
        }

        var addTask = await _context.Tasks.AddAsync(newUTask);

        await _context.SaveChangesAsync();

        return Ok();
    }

    
    //might make it to be more optimized + add idUlient + check if public then edit
    [HttpPut("{idTask:int}")]
    public async Task<IActionResult> EndTask(int idTask, UTaskEndModel uTask)
    {
        var taskExists = await _context.Tasks.AnyAsync(t => t.IdTask == idTask);

        if (!taskExists)
        {
            return BadRequest("Podane zadanie nie istnieje");
        }

        var isEnded = await _context.Tasks.AnyAsync(t => t.IdTask == idTask &&
                                                         t.EndDate != null);
        if (isEnded)
        {
            return BadRequest("Zadanie jest już zakończone");
        }

        var endDateIsProper = await _context.Tasks.AnyAsync(t => t.IdTask == idTask &&
                                                                 t.StartDate < uTask.EndDate
                                                                 && uTask.EndDate <= DateTime.Now);
        if (!endDateIsProper)
        {
            return BadRequest("Niepoprawna data zakończenia");
        }

        var existingTask = await _context.Tasks.FirstAsync(t => t.IdTask == idTask);

        existingTask.EndDate = uTask.EndDate;
        
        await _context.SaveChangesAsync();
        
        return Ok();
        
    }
    
    //check your (Employee) tasks
    [HttpGet("{idUser:int}")]
    public async Task<IActionResult> ShowUserTasks(int idUser)
    {
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
    
    //check public tasks
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
    
    //check employees tasks + use function made for user before + change how UTasks show
    [HttpGet("{idManager:int}/subordinates")]
    public async Task<IActionResult> ShowSubordinatesTasks(int idManager)
    {
        var subordinatesTasks = await _context.Users
            .Where(u => u.IdManager == idManager)
            .Select(u => new
            {
                u.UTasks
            })
            .ToListAsync();

        return Ok(subordinatesTasks);

    }
    
    //delete task + do przemyslenia czy walidowac idusera
    [HttpDelete("{idTask:int}")]
    public async Task<IActionResult> DeleteTask(int idTask, int idUser)
    {
        /*//bez walidacji
        var taskToRemove = new UTask()
        {
            IdTask = idTask
        };

        _context.Tasks.Attach(taskToRemove);
        
        _context.Tasks.Remove(taskToRemove);*/
        
        /*var doesTaskExist = await _context.Tasks.AnyAsync(t => t.IdTask == idTask);
        
        if (!doesTaskExist)
        {
            return BadRequest("Zadanie o podanym id nie istnieje");
        }*/
        
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
        
        
        /*var isAvailableForUser = await _context.Tasks.AnyAsync(t => t.IdUser == idUser ||
                                                                    t.IsPublic == true);*/
        if (taskToRemove.IsPublic == false && taskToRemove.IdUser != idUser)
        {
            return BadRequest("Nie masz uprawnień do usunięcia tego zadania");
        }
        /*if (!isAvailableForUser)
        {
            return BadRequest("Nie masz uprawnień do usunięcia tego zadania");
        }*/
        
        /*var taskToRemove = new UTask()
        {
            IdTask = idTask
        };*/

        _context.Tasks.Attach(taskToRemove);

        _context.Tasks.Remove(taskToRemove);
        
        await _context.SaveChangesAsync();
        
        return Ok();
    }
    
    //edit task
    
    //procedure to check statistics for manager
}