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
using TaskyAPI.Services;

namespace TaskyAPI.Controllers;

[Route("api/tasks")]
[ApiController]
public class TasksController : ControllerBase
{
    private readonly IUTaskService _service;

    public TasksController(IUTaskService service)
    {
        _service = service;
    }

    //could be added custom format issue feedback
    [HttpPost]
    public async Task<IActionResult> AddNewTask(UTaskModel uTask)
    {
        try
        {
            await _service.AddNewTask(uTask);
            return Ok();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    
    // Finish your or public task
    [HttpPut("{idUser:int}/{idTask:int}/finish")]
    public async Task<IActionResult> FinishTask(int idUser, int idTask, UTaskEndModel uTask)
    {
        try
        {
            await _service.FinishTask(idUser, idTask, uTask);
            return Ok();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        
    }
    
    //check your (Employee) tasks
    [HttpGet("{idUser:int}")]
    public async Task<IActionResult> ShowUserTasks(int idUser)
    {
        try
        {
            var userTasks = await _service.ShowUserTasks(idUser);
            return Ok(userTasks);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet("public")]
    public async Task<IActionResult> ShowPublicTasks()
    {
        try
        {
            var publicTasks = await _service.ShowPublicTasks();
            return Ok(publicTasks);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    //check employees tasks
    //change how UTasks show
    [HttpGet("{idManager:int}/subordinates")]
    public async Task<IActionResult> ShowSubordinatesTasks(int idManager)
    {
        try
        {
            var subordinatesTasks = await _service.ShowSubordinatesTasks(idManager);
            return Ok(subordinatesTasks);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }

    }
    
    //delete task
    //thinking about deleting user id validation
    [HttpDelete("{idTask:int}")]
    public async Task<IActionResult> DeleteTask(int idTask, int idUser)
    {
        try
        {
            await _service.DeleteTask(idTask, idUser);
            return Ok();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    //edit task
    [HttpPut("{idUser:int}/{idTask:int}/edit")]
    public async Task<IActionResult> EditTask(int idUser,int idTask, UTaskEditModel newTask)
    {
        try
        {
            await _service.EditTask(idUser, idTask, newTask);
            return Ok();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        
    }
    
    //procedure to check statistics for manager
    [HttpGet("{idManager:int}/statistics")]
    public async Task<IActionResult> GetStatistics(int idManager)
    {
        return Ok();
    }
}