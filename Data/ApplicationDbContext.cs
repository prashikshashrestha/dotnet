using db.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using todo.Models;

namespace todo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TaskList> TaskList { get; set; }
    }
}
