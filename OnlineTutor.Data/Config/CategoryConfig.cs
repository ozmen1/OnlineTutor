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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
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

            builder.ToTable("Categories");

            builder.HasData(
                new Category() { Id = 1, Name = "Lise", Description = "Bu bir açıklamadır.", Url = "lise" },
                new Category() { Id = 2, Name = "İlköğretim", Description = "Bu bir açıklamadır.", Url = "ilkogretim" },
                new Category() { Id = 3, Name = "Yazılım", Description = "Bu bir açıklamadır.", Url = "yazilim" },
                new Category() { Id = 4, Name = "Üniversite", Description = "Bu bir açıklamadır.", Url = "universite" });
        }
    }
}
