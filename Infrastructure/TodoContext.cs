using System.Reflection.Emit;
using System;

using Microsoft.EntityFrameworkCore;
using Entities;

namespace Infrastructure
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> opt) : base(opt)
        { }

        protected override void OnModelCreating(ModelBuilder model)
        {

        }

        public DbSet<Todo> Tasks { get; set; }
    }
}
