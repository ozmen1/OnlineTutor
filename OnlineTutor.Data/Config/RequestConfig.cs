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
    public class RequestConfig : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.ResponseTime)
                .IsRequired();

            builder.Property(t => t.ContactNumber)
                .IsRequired();

            builder.Property(t => t.Expectations)
                .IsRequired()
                .HasMaxLength(500);

            builder.ToTable("Requests");

            builder.HasData(
               new Request() { 
                   Id = 1, 
                   ShowCardId = 1,
                   StudentId = "86c02fd2-67c2-4a94-8113-a751bfe9f71f",
                   Expectations = "Kalkülüs dersi için 5 saatlik özel ders", 
                   ContactNumber = "0555-555-55-55",
                   ResponseTime = DateTime.Now 
               }
                );
        }
    }
}
