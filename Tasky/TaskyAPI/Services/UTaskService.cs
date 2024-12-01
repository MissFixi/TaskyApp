using Microsoft.AspNetCore.Components.Forms;
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

    public async Task AddNewTask(UTaskModel uTask)
    {
        var userExists = await _userRepository.DoesUserExistAsync(uTask.IdUser);
        
        if (!userExists)
        {
            throw new ArgumentException("Podany użytkownik nie istnieje");
        }
        
        var newUTask = new UTask()
        {
            Heading = uTask.Heading,
            Priority = uTask.Priority,
            Description = uTask.Description,
            StartDate = uTask.StartDate,
            IdUser = uTask.IdUser,
            IsPublic = uTask.IsPublic
        };
        
        await _taskRepository.AddTaskAsync(newUTask);
        await _taskRepository.SaveChangesAsyncAsync();
    }

    public async Task FinishTask(int idUser, int idTask, UTaskEndModel uTask)
    {
        var taskExists = await _taskRepository.DoesTaskExistAsync(idTask);
        if (!taskExists)
        {
            throw new ArgumentException("Podane zadanie nie istnieje");
        }
        
        var userExists = await _userRepository.DoesUserExistAsync(idUser);
        if (!userExists)
        {
            throw new ArgumentException("Podany użytkownik nie istnieje");
        }
        
        var userHasPermission = await _taskRepository.DoesUserHavePermissionAsync(idUser, idTask);
        if (!userHasPermission)
        {
            throw new ArgumentException("Nie masz uprawnień do zakończenia tego zadania");
        }
        
        var taskIsFinished = await _taskRepository.IsTaskFinishedAsync(idTask);
        if (taskIsFinished)
        {
            throw new ArgumentException("Zadanie jest już zakończone");
        }

        var endDateIsCorrect = await _taskRepository.IsEndDateCorrectAsync(uTask.EndDate, idTask);
        if (!endDateIsCorrect || uTask.EndDate > DateTime.Now)
        {
            throw new ArgumentException("Niepoprawna data zakończenia");
        }

        //change iduser 
        await _taskRepository.FinishTaskAsync(idTask, uTask.EndDate);
        
        await _taskRepository.SaveChangesAsyncAsync();
    }

    public async Task<List<UTaskUserTasksModel>> ShowUserTasks(int idUser)
    {
        var userExists = await _userRepository.DoesUserExistAsync(idUser);
        if (!userExists)
        {
            throw new ArgumentException("Podany użytkownik nie istnieje");
        }

        var userHasTasksAssigned = await _taskRepository.DoesUserHaveAnyTaskAsync(idUser);
        if (!userHasTasksAssigned)
        {
            throw new ArgumentException("Podany użytkownik nie posiada żadnych zadań");
        }
        
        var userTasks = await _taskRepository.GetTasksForUserAsync(idUser);
        return userTasks.Select(t => new UTaskUserTasksModel
            {
                IdTask = t.IdTask,
                Heading = t.Heading,
                Priority = t.Priority,
                Description = t.Description,
                StartDate = t.StartDate,
                EndDate = t.EndDate,
                IsPublic = t.IsPublic
            }
        ).ToList();

    }

    public async Task<List<UTaskPublicTasksModel>> ShowPublicTasks()
    {
        var areAnyPublicTasks = await _taskRepository.AreAnyTasksPublicAsync();
        if (!areAnyPublicTasks)
        {
            throw new Exception("Akualnie żaden użytkownik nie udostępnia swoich zadań");
        }

        var publicTasks = await _taskRepository.GetPublicTasksAsync();
        return publicTasks.Select(t => new UTaskPublicTasksModel
        {
            IdTask = t.IdTask,
            Heading = t.Heading,
            Priority = t.Priority,
            Description = t.Description,
            StartDate = t.StartDate,
            EndDate = t.EndDate,
            /*FirstName = t.TaskUser.FirstName,
            LastName = t.TaskUser.LastName*/
        }).ToList();

    }

    public async Task<List<UTask>> ShowSubordinatesTasks(int idManager)
    {
        var areTasksAssigned = await _taskRepository.AreAnyTasksAssignedToSubordinatesAsync(idManager);
        if (!areTasksAssigned)
        {
            throw new Exception("Brak zadań do wyświetlenia");
        }
        
        var subordinates = await _userRepository.GetSubordinatesAsync(idManager);
        
        return subordinates.Where(u => u.UTasks!=null).SelectMany(u => u.UTasks).ToList();
    }

    public async Task DeleteTask(int idTask, int idUser)
    {
        var taskExists = await _taskRepository.DoesTaskExistAsync(idTask);
        if (!taskExists)
        {
            throw new ArgumentException("Podane zadanie nie istnieje");
        }
        
        var userExists = await _userRepository.DoesUserExistAsync(idUser);
        if (!userExists)
        {
            throw new ArgumentException("Podany użytkownik nie istnieje");
        }
        
        var userHasPermission = await _taskRepository.DoesUserHavePermissionAsync(idUser, idTask);
        if (!userHasPermission)
        {
            throw new ArgumentException("Nie masz uprawnień do usunięcia tego zadania");
        }

        await _taskRepository.DeleteTaskAsync(idTask);
        
        await _taskRepository.SaveChangesAsyncAsync();
    }

    public async Task EditTask(int idUser, int idTask, UTaskEditModel newTask)
    {
        var taskExists = await _taskRepository.DoesTaskExistAsync(idTask);
        if (!taskExists)
        {
            throw new ArgumentException("Podane zadanie nie istnieje");
        }
        
        var userExists = await _userRepository.DoesUserExistAsync(idUser);
        if (!userExists)
        {
            throw new ArgumentException("Podany użytkownik nie istnieje");
        }
        
        var userHasPermission = await _taskRepository.DoesUserHavePermissionAsync(idUser, idTask);
        if (!userHasPermission)
        {
            throw new ArgumentException("Nie masz uprawnień do edytowania tego zadania");
        }

        var taskToEdit = await _taskRepository.GetTaskAsync(idTask);
        taskToEdit.Heading = newTask.Heading;
        taskToEdit.Priority = newTask.Priority;
        taskToEdit.Description = newTask.Description;
        taskToEdit.IsPublic = newTask.IsPublic;
        
        
        await _taskRepository.SaveChangesAsyncAsync();
    }

    public Task<UTask> GetStatistics(int idManager)
    {
        throw new NotImplementedException();
    }
}