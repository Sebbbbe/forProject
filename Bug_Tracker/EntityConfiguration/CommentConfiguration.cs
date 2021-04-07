using Bug_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.EntityConfiguration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> modelBuilder)
        {
            modelBuilder
                .HasKey(Comment => Comment.comment_id);
    
                

            modelBuilder

           .HasOne(issue => issue.User);


            modelBuilder
    .Property(comment => comment.comment_id)
    .ValueGeneratedOnAdd();

        }
    }
}
