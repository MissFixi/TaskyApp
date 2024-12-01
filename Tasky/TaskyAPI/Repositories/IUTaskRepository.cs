using TaskyAPI.Models;

namespace TaskyAPI.Repositories;

public interface IUTaskRepository
{
    Task<bool> DoesTaskExistAsync(int idTask);
    Task AddTaskAsync(UTask uTask);
    Task<bool> DoesUserHavePermissionsAsync(int idUser, int idTask);
    Task<bool> IsTaskFinishedAsync(int idTask);
    Task<bool> IsEndDateCorrectAsync(DateTime dateTime, int idTask);
    Task FinishTaskAsync(int idTask, DateTime time);
    Task<bool> DoesUserHaveAnyTaskAsync(int idUser);
    Task<bool> AreAnyTasksPublicAsync();
    Task<bool> AreAnyTasksAssignedToSubordinatesAsync(int idManager);
    Task DeleteTaskAsync(int idTask);
    Task EditTaskAsync(int idTask, UTask uTask);
    Task SaveChangesAsyncAsync();
}