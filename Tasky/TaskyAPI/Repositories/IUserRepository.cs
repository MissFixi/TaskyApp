using TaskyAPI.Models;
using TaskyAPI.RequestModels;

namespace TaskyAPI.Repositories;

public interface IUserRepository
{
    Task<bool> DoesUserExistAsync(int idUser);
    Task<bool> IsUserManagerAsync(int idUser);
    Task<List<User>> GetSubordinatesAsync(int idManager);
    Task<List<User>> GetSubordinatesTasksAsync(int idManager); 
    Task<List<UTaskStatisticsModel>> GetStatisticsAsync(int idManager);
}