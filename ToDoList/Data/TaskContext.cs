using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions options) : base(options) { }
        public DbSet<Models.ToDoTask> Tasks { get; set; }
    }
}
