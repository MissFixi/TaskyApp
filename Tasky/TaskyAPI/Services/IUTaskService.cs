using TaskyAPI.Models;
using TaskyAPI.RequestModels;

namespace TaskyAPI.Services;

public interface IUTaskService
{
    Task AddNewTask(UTaskModel uTask);
    Task FinishTask(int idUser, int idTask, UTaskEndModel uTask);
    Task<UTask> ShowUserTasks(int idUser);
    Task<UTask> ShowPublicTasks();
    Task<UTask> ShowSubordinatesTasks(int idManager);
    Task DeleteTask(int idTask, int idUser);
    Task EditTask(int idUser, int idTask, UTaskEditModel newTask);
    Task<UTask> GetStatistics(int idManager);
}