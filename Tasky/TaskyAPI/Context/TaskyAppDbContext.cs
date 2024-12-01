using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using TaskyAPI.Models;
using Task = System.Threading.Tasks.Task;

/*using TaskyAPI.Models;*/

namespace TaskyAPI.Context;

public partial class TaskyAppDbContext : DbContext
{
    public TaskyAppDbContext()
    {
    }

    public TaskyAppDbContext(DbContextOptions<TaskyAppDbContext> options)
        : base(options)
    {
    }
 
    public DbSet<User> Users { get; set; }
    public DbSet<UTask> Tasks { get; set; }
}
