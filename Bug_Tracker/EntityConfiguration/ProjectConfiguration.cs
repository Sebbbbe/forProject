using Bug_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.EntityConfiguration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> modelBuilder)
        {
            modelBuilder
          .HasKey(Project => Project.Project_id);
            modelBuilder
            
             .HasMany(project => project.Issues)
             .WithOne(issue => issue.Project);


            modelBuilder
          .Property(project => project.Project_id)
          .ValueGeneratedOnAdd();



        }
    }
}
