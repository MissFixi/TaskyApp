using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using TaskyAPI.Models;
using TaskyAPI.RequestModels;
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

    //Added for WinForms tests -> should be made in safier way
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\Local;Database=TaskyAppDB;Trusted_Connection=True;");
        }
    }

    public DbSet<User> Users { get; set; }
    public DbSet<UTask> Tasks { get; set; }
    
    
}
