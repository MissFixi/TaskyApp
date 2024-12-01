using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TaskyAPI.Context;
using TaskyAPI.Models;
using TaskyAPI.RequestModels;

namespace TaskyAPI.Repositories;

public class UTaskRepository : IUTaskRepository
{
    private TaskyAppDbContext _context;
    
    public UTaskRepository(TaskyAppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> DoesTaskExistAsync(int idTask)
    {
        return await _context.Tasks.AnyAsync(t => t.IdTask == idTask);
    }

    public async Task AddTaskAsync(UTask uTask)
    {
        await _context.Tasks.AddAsync(uTask);
    }

    public async Task<bool> DoesUserHavePermissionAsync(int idUser, int idTask)
    {
        return await _context.Tasks.AnyAsync(t => t.IdTask == idTask 
                                                  && (t.IdUser == idUser 
                                                  || t.IsPublic == true));
    }

    public async Task<bool> IsTaskFinishedAsync(int idTask)
    {
        return await _context.Tasks.AnyAsync(t => t.IdTask == idTask 
                                                  && t.EndDate != null);
    }

    public async Task<bool> IsEndDateCorrectAsync(DateTime dateTime, int idTask)
    {
        return await _context.Tasks.AnyAsync(t => t.IdTask == idTask
                                                  && dateTime > t.StartDate);
    }

    public async Task FinishTaskAsync(int idTask, DateTime time)
    {
        var taskToFinish = await _context.Tasks.FindAsync(idTask);
        taskToFinish.EndDate = time;
    }

    public async Task<bool> DoesUserHaveAnyTaskAsync(int idUser)
    {
        return await _context.Tasks.AnyAsync(t => t.IdUser == idUser);
    }

    public async Task<bool> AreAnyTasksPublicAsync()
    {
        return await _context.Tasks.AnyAsync(t => t.IsPublic == true);
    }

    public async Task<bool> AreAnyTasksAssignedToSubordinatesAsync(int idManager)
    {
        return await _context.Tasks.AnyAsync(t => t.TaskUser.IdManager == idManager);
    }

    public async Task DeleteTaskAsync(int idTask)
    {
        var taskToRemove = await _context.Tasks.FindAsync(idTask);
        _context.Tasks.Attach(taskToRemove);
        _context.Tasks.Remove(taskToRemove);
    }

    public async Task EditTaskAsync(int idTask, UTask uTask)
    {
        var taskToEdit = await _context.Tasks.FindAsync(idTask);
        taskToEdit.Heading = uTask.Heading;
        taskToEdit.Priority = uTask.Priority;
        taskToEdit.Description = uTask.Description;
        taskToEdit.IsPublic = uTask.IsPublic;
        
    }

    public async Task SaveChangesAsyncAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<List<UTask>> GetTasksForUserAsync(int idUser)
    {
        return await _context.Tasks
            .Where(t => t.IdUser == idUser)
            .ToListAsync();
    }
    
    public async Task<List<UTask>> GetPublicTasksAsync()
    {
        return await _context.Tasks
            .Where(t => t.IsPublic == true)
            .ToListAsync();
    }
    
    public async Task<UTask> GetTaskAsync(int idTask)
    {
        return await _context.Tasks.FindAsync(idTask);
    }
}