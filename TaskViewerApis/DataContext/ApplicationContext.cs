using Microsoft.EntityFrameworkCore;
using TaskViewer.Models;
using Task = TaskViewer.Models.Task;

namespace TaskViewerApis.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskDetail> TaskDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PowerTools;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasKey(p => p.PlmId);
            modelBuilder.Entity<Task>().HasKey(p => p.PlmId);
            modelBuilder.Entity<TaskDetail>().HasKey(p => p.PlmId);
            modelBuilder.Entity<User>().HasKey(p => p.PlmId);
        }
    }
}
