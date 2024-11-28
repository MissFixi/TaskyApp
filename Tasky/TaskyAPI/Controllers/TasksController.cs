using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    
    //might make it to be more optimized + add idclient
    [HttpPut("{idTask}")]
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
    
    //check your tasks
    
    //check public tasks
    
    //check employees tasks
    
    //delete task
    
    //edit task
    
    //procedure to check statistics for manager
}