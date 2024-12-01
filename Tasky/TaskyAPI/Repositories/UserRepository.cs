using Microsoft.EntityFrameworkCore;
using TaskyAPI.Context;

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
}