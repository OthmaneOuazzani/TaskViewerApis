﻿using Microsoft.EntityFrameworkCore;
using TaskViewer.Models;
using TaskViewerApis.Models;
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
        public DbSet<Message> Messages { get; set; }
        public DbSet<Pa> Pas { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<Np> Nps { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<La> Las { get; set; }  






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PowerToolsLAS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasKey(p => p.PlmId);
            modelBuilder.Entity<Task>().HasKey(p => p.PlmId);
            modelBuilder.Entity<TaskDetail>().HasKey(p => p.PlmId);
            modelBuilder.Entity<User>().HasKey(p => p.PlmId);
            modelBuilder.Entity<Pa>().HasKey(p => p.PlmId);
            modelBuilder.Entity<Error>().HasKey(p => p.PlmId);
            modelBuilder.Entity<Message>().HasKey(p => p.PlmId);
            modelBuilder.Entity<Np>().HasKey(p => new { p.PlmId, p.ProjectName });
            modelBuilder.Entity<Notification>().HasKey(p => p.Id);
            modelBuilder.Entity<Rating>().HasKey(p => p.id);
            modelBuilder.Entity<La>().HasKey(p => p.PlmId);


        }
    }
}
