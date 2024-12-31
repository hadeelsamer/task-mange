using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
namespace Hadeelsamer.Models
{
    public class context : DbContext
    {
        public context(DbContextOptions<context> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<TeamMamber> teamMambers { get; set; }
        public DbSet<Project> projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
           .HasOne(m => m.Project)
          .WithMany(b => b.tasks)
          .HasForeignKey(v => v.projectID)
           .OnDelete((DeleteBehavior)ReferentialAction.NoAction);
            modelBuilder.Entity<Task>()
            .HasOne(m => m.TeamMamber)
           .WithMany(b => b.Tasks)
          .HasForeignKey(v => v.TaskId)
           .OnDelete((DeleteBehavior)ReferentialAction.NoAction);
        }
       



        
    }
}


                
        

    
