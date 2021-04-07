using Bug_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.EntityConfiguration
{
    public class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> modelBuilder)
        {
            modelBuilder
               
               .HasKey(issue => issue.Post_id);

            modelBuilder

             .HasOne(issue => issue.User)
             .WithMany(User => User.Issues);

            modelBuilder
                .Property(issue => issue.Post_id)
                .ValueGeneratedOnAdd();


        }
    }
}
