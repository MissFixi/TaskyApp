using Microsoft.EntityFrameworkCore;
using TaskyAPI.Context;
using TaskyAPI.Models;

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
    
}