using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TaskyAPI.Context;
using TaskyAPI.Models;
using TaskyAPI.RequestModels;

namespace TaskyAPI.Repositories;

public class UserRepository : IUserRepository
{
    private TaskyAppDbContext _context;
    
    public UserRepository(TaskyAppDbContext context)
    {
        _context = context;
    }
    
    public async Task<bool> DoesUserExistAsync(int idUser)
    {
        return await _context.Users.AnyAsync(u => u.IdUser == idUser);
    }
    
    public async Task<bool> IsUserManagerAsync(int idUser)
    {
        return await _context.Users.AnyAsync(u => u.IdManager == idUser);
    }
    
    public async Task<List<User>> GetSubordinatesAsync(int idManager)
    {
        return await _context.Users
            .Where(u => u.IdManager == idManager)
            .ToListAsync();
    }
    
    public async Task<List<User>> GetSubordinatesTasksAsync(int idManager)
    {
        return await _context.Users
            .Where(u => u.IdManager == idManager)
            .Select(u => new User
            {
                IdUser = u.IdUser,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UTasks = u.UTasks
            })
            .ToListAsync();
    }

    public async Task<List<UTaskStatisticsModel>> GetStatisticsAsync(int idManager)
    {
        var IdManager = new SqlParameter("@Manager", idManager);

        return await _context.Database.SqlQueryRaw<UTaskStatisticsModel>("EXEC getStatisticsForManager @Manager", IdManager).ToListAsync();
    }
    
}