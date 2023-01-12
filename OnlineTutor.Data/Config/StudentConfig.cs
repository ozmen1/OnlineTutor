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
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //builder.HasKey(t => t.Id);

            //builder.Property(t => t.Id).ValueGeneratedOnAdd();

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

            builder.ToTable("Students");

            builder.HasData(
                     new Student()
                     {
                         Id = "86c02fd2-67c2-4a94-8113-a751bfe9f71f",
                         City = "Kocaeli",
                         FirstName = "Kerem",
                         LastName = "Özmen",
                         Url = "universite-ogrencisi",
                         Email = "keremozmen34@gmail.com"
                     },
                    new Student()
                    {
                        Id = "55dc4a34-a463-46b2-8fb3-e97a76f70cfc",
                        City = "İstanbul",
                        FirstName = "Jane",
                        LastName = "Doe",
                        Url = "lise-ogrencisi",
                        Email = "example@example.com"
                    }
                );
        }

    }
}
