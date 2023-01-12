using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Config
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.CommentText)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(t => t.Point)
                .IsRequired();

            builder.ToTable("Comments");

            builder.HasData(
                    new Comment()
                    {
                        Id = 1,
                        TeacherId = "dc4ac19a-431c-40f1-a2df-cd49869e3559",
                        StudentId = "55dc4a34-a463-46b2-8fb3-e97a76f70cfc",
                        //Title = "Çok iyii", 
                        CommentText = "Mükemmel bir eğitimci.",
                        Url = "comment-1"
                    },
                    new Comment()
                    {
                        Id = 2,
                        TeacherId = "fc4ac19b-331c-90f1-z2df-xd49869e3351",
                        StudentId = "86c02fd2-67c2-4a94-8113-a751bfe9f71f",
                        //Title = "Çok iyii", 
                        CommentText = "Harika bir eğitimci.",
                        Url = "comment-2"
                    }

                );
        }

    }
}
