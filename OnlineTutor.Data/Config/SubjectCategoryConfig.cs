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
    public class SubjectCategoryConfig : IEntityTypeConfiguration<SubjectCategory>
    {
        public void Configure(EntityTypeBuilder<SubjectCategory> builder)
        {
            builder.HasKey(sc => new { sc.SubjectId, sc.CategoryId });

            builder.ToTable("SubjectCategories");

            builder.HasData(
                    new SubjectCategory() { SubjectId = 1, CategoryId = 1 },
                    new SubjectCategory() { SubjectId = 2, CategoryId = 1 },
                    new SubjectCategory() { SubjectId = 3, CategoryId = 1 },
                    new SubjectCategory() { SubjectId = 9, CategoryId = 1 },
                    new SubjectCategory() { SubjectId = 1, CategoryId = 2 },
                    new SubjectCategory() { SubjectId = 2, CategoryId = 2 },
                    new SubjectCategory() { SubjectId = 3, CategoryId = 2 },
                    new SubjectCategory() { SubjectId = 9, CategoryId = 2 },
                    new SubjectCategory() { SubjectId = 8, CategoryId = 2 },
                    new SubjectCategory() { SubjectId = 6, CategoryId = 4 },
                    new SubjectCategory() { SubjectId = 7, CategoryId = 4 },
                    new SubjectCategory() { SubjectId = 10, CategoryId = 4 },
                    new SubjectCategory() { SubjectId = 4, CategoryId = 3 },
                    new SubjectCategory() { SubjectId = 5, CategoryId = 3 }
                );
        }
    }
}
