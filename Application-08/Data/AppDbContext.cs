using Microsoft.EntityFrameworkCore;
using Application_08.Models;

namespace Application_08.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ToDoTask> ToDoTasks { get; set; }
    }
}

