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
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {

            builder.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.PhoneNumber)
                .HasMaxLength(16);

            builder.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.DateOfBirth)
                .IsRequired();

            builder.ToTable("Teachers");

            builder.HasData(
                     new Teacher()
                     {
                         Id = "dc4ac19a-431c-40f1-a2df-cd49869e3559",
                         City = "İstanbul",
                         FirstName = "Kerem",
                         LastName = "Özmen",
                         TeacherInfo = "Deneyimli",
                         //TeacherStatue = Entity.Enum.TeacherStatue.Leader,
                         Url = "deneyimli",
                         Email = "keremozmentr@gmail.com"
                     },
                    new Teacher()
                    {
                        Id = "fc4ac19b-331c-90f1-z2df-xd49869e3351",
                        City = "İstanbul",
                        FirstName = "John",
                        LastName = "Doe",
                        TeacherInfo = "Deneyimsiz",
                        //TeacherStatue = Entity.Enum.TeacherStatue.Super,
                        Url = "deneyimsiz",
                        Email = "example@example.com"
                    }
                );
        }
    }
}
