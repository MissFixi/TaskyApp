using TaskyAPI.Models;

namespace TaskyAPI.Repositories;

public interface IUTaskRepository
{
    Task<bool> DoesTaskExistAsync(int idTask);
    Task AddTaskAsync(UTask uTask);
    Task<bool> DoesUserHavePermissionAsync(int idUser, int idTask);
    Task<bool> IsTaskFinishedAsync(int idTask);
    Task<bool> IsEndDateCorrectAsync(DateTime dateTime, int idTask);
    Task FinishTaskAsync(int idTask, DateTime time);
    Task<bool> DoesUserHaveAnyTaskAsync(int idUser);
    Task<bool> AreAnyTasksPublicAsync();
    Task<bool> AreAnyTasksAssignedToSubordinatesAsync(int idManager);
    Task DeleteTaskAsync(int idTask);
    Task EditTaskAsync(int idTask, UTask uTask);
    Task SaveChangesAsyncAsync();
    Task<List<UTask>> GetTasksForUserAsync(int idUser);
    Task<List<UTask>> GetPublicTasksAsync();
    Task<UTask> GetTaskAsync(int idTask);
}