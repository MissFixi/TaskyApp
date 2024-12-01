using TaskyAPI.Models;
using TaskyAPI.RequestModels;

namespace TaskyAPI.Services;

public interface IUTaskService
{
    Task AddNewTask(UTaskModel uTask);
    Task FinishTask(int idUser, int idTask, UTaskEndModel uTask);
    Task<List<UTaskUserTasksModel>> ShowUserTasks(int idUser);
    Task<List<UTaskPublicTasksModel>> ShowPublicTasks();
    Task<List<UTask>> ShowSubordinatesTasks(int idManager);
    Task DeleteTask(int idTask, int idUser);
    Task EditTask(int idUser, int idTask, UTaskEditModel newTask);
    Task<UTask> GetStatistics(int idManager);
}