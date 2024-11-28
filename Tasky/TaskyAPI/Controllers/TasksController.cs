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


    [HttpPut]
    public async Task<IActionResult> EndTask(UTaskEndModel uTask)
    {
        var taskExists = await _context.Tasks.AnyAsync(t => t.IdTask == uTask.IdTask);

        if (!taskExists)
        {
            return BadRequest("Podane zadanie nie istnieje");
        }

        var isEnded = await _context.Tasks.AnyAsync(t => t.IdTask == uTask.IdTask &&
                                                         t.EndDate != null);
        if (isEnded)
        {
            return BadRequest("Zadanie jest już zakończone");
        }

        var endDateIsProper = await _context.Tasks.AnyAsync(t => t.IdTask == uTask.IdTask &&
                                                                 t.StartDate < uTask.EndDate);
        if (!endDateIsProper)
        {
            return BadRequest("Niepoprawna data zakończenia");
        }

        var existingTask = await _context.Tasks.FirstAsync(t => t.IdTask == uTask.IdTask);

        existingTask.EndDate = uTask.EndDate;
        
        await _context.SaveChangesAsync();

        return Ok();
    }
}