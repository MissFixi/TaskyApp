using TaskyAPI.Models;

namespace TaskyAPI.Repositories;

public interface IUserRepository
{
    Task<bool> DoesUserExistAsync(int idUser);
    Task<bool> IsUserManagerAsync(int idUser);
    Task<List<User>> GetSubordinatesAsync(int idManager);
}