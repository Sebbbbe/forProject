using Bug_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> modelBuilder)
        {

            modelBuilder
                .HasKey(User => User.user_id);

            modelBuilder
                 .HasMany(user => user.Comments)
                 .WithOne(comment => comment.User);

                   modelBuilder
                .Property(issue => issue.user_id)
                .ValueGeneratedOnAdd();


        }
    }
}
