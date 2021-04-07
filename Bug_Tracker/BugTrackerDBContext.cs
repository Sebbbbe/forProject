using Bug_Tracker.EntityConfiguration;
using Bug_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker
{
    public class BugTrackerDBContext : DbContext
    {
        public BugTrackerDBContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BugTrackerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

       }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder
                .ApplyConfiguration(new IssueConfiguration());


            modelBuilder
                .ApplyConfiguration(new UserConfiguration());


            modelBuilder
                .ApplyConfiguration(new ProjectConfiguration());


            modelBuilder
            .ApplyConfiguration(new CommentConfiguration());



          

            base.OnModelCreating(modelBuilder);

        }

       public DbSet<Issue> Issues { get; set; }
       public DbSet<User> Users { get; set; }
       public DbSet<Comment> Comments { get; set; }
       public DbSet<Project> Projects { get; set; }


}

}

   
