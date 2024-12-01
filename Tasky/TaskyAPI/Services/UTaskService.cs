using TaskyAPI.Models;
using TaskyAPI.Repositories;
using TaskyAPI.RequestModels;

namespace TaskyAPI.Services;

public class UTaskService : IUTaskService
{
    private readonly IUTaskRepository _taskRepository;
    private readonly IUserRepository _userRepository;

    public UTaskService(IUTaskRepository uTaskRepository, IUserRepository userRepository)
    {
        _userRepository = userRepository;
        _taskRepository = uTaskRepository;
    }

    public Task AddNewTask(UTaskModel uTask)
    {
        throw new NotImplementedException();
    }

    public Task FinishTask(int idUser, int idTask, UTaskEndModel uTask)
    {
        throw new NotImplementedException();
    }

    public Task<UTask> ShowUserTasks(int idUser)
    {
        throw new NotImplementedException();
    }

    public Task<UTask> ShowPublicTasks()
    {
        throw new NotImplementedException();
    }

    public Task<UTask> ShowSubordinatesTasks(int idManager)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTask(int idTask, int idUser)
    {
        throw new NotImplementedException();
    }

    public Task EditTask(int idUser, int idTask, UTaskEditModel newTask)
    {
        throw new NotImplementedException();
    }

    public Task<UTask> GetStatistics(int idManager)
    {
        throw new NotImplementedException();
    }
}