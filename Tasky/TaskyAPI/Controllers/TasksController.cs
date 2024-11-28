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
            IdUser = uTask.IdUser
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
}