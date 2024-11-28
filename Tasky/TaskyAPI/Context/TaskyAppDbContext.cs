using System;
using System.Collections.Generic;
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

    
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
   
    public DbSet<User> Users { get; set; }
    public DbSet<UTask> Tasks { get; set; }
}
