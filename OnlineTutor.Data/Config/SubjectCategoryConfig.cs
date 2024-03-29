﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Config
{
    public class SubjectCategoryConfig : IEntityTypeConfiguration<SubjectCategory>
    {
        public void Configure(EntityTypeBuilder<SubjectCategory> builder)
        {
            builder.HasKey(sc => new { sc.Id });

            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.HasAlternateKey(sc => new { sc.SubjectId, sc.CategoryId });
            builder.ToTable("SubjectCategories");

            builder.HasData(
                    new SubjectCategory() { Id = 1, SubjectId = 1, CategoryId = 1 },
                    new SubjectCategory() { Id = 2, SubjectId = 9, CategoryId = 2 }
                    //new SubjectCategory() { Id = 8, SubjectId = 2, CategoryId = 1 },
                    //new SubjectCategory() { Id = 3, SubjectId = 3, CategoryId = 1 },
                    //new SubjectCategory() { Id = 4, SubjectId = 9, CategoryId = 1 },
                    //new SubjectCategory() { Id = 5, SubjectId = 1, CategoryId = 2 },
                    //new SubjectCategory() { Id = 6, SubjectId = 2, CategoryId = 2 },
                    //new SubjectCategory() { Id = 7, SubjectId = 3, CategoryId = 2 },
                    //new SubjectCategory() { Id = 8, SubjectId = 2, CategoryId = 1 },
                    //new SubjectCategory() { Id = 9, SubjectId = 8, CategoryId = 2 },
                    //new SubjectCategory() { Id = 10, SubjectId = 6, CategoryId = 4 },
                    //new SubjectCategory() { Id = 11, SubjectId = 7, CategoryId = 4 },
                    //new SubjectCategory() { Id = 12, SubjectId = 10, CategoryId = 4 },
                    //new SubjectCategory() { Id = 13, SubjectId = 4, CategoryId = 3 },
                    //new SubjectCategory() { Id = 14, SubjectId = 5, CategoryId = 3 }
                );
        }
    }
}
