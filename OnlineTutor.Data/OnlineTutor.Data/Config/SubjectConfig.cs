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
    public class SubjectConfig : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(c => c.Url)
                .IsRequired()
                .HasMaxLength(250);

            builder.ToTable("Subjects");

            builder.HasData(
                new Subject() { Id = 1, Name = "Matematik", Description="Bu bir açıklamadır.", Url = "matematik", },
                new Subject() { Id = 2, Name = "Fizik", Description="Bu bir açıklamadır.", Url = "fizik" },
                new Subject() { Id = 3, Name = "Kimya", Description="Bu bir açıklamadır.", Url = "kimya" },
                new Subject() { Id = 4, Name = "C#", Description="Bu bir açıklamadır.", Url = "c#" },
                new Subject() { Id = 5, Name = "Javascript", Description="Bu bir açıklamadır.", Url = "javascript" },
                new Subject() { Id = 6, Name = "Makine Mühendisliği", Description="Bu bir açıklamadır.", Url = "makine-muhendisligi" },
                new Subject() { Id = 7, Name = "Bilgisayar Mühendisliği", Description="Bu bir açıklamadır.", Url = "bilgisayar-muhendisligi" },
                new Subject() { Id = 8, Name = "Hayat Bilgisi", Description="Bu bir açıklamadır.", Url = "hayat-bilgisi" },
                new Subject() { Id = 9, Name = "İngilizce", Description="Bu bir açıklamadır.", Url = "ingilizce" },
                new Subject() { Id = 10, Name = "DotNET", Description="Bu bir açıklamadır.", Url = "dotnet" });
        }
    }
}
