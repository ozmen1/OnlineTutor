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
    public class SubjectCategoryShowCardConfig : IEntityTypeConfiguration<SubjectCategoryShowCard>
    {
        public void Configure(EntityTypeBuilder<SubjectCategoryShowCard> builder)
        {
            builder.HasKey(sc => new { sc.Id });

            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.HasAlternateKey(sc => new { sc.SubjectCategoryId, sc.ShowCardId});
            builder.ToTable("SubjectCategoryShowCards");

            builder.HasData(
                    new SubjectCategoryShowCard() { Id = 1, SubjectCategoryId = 1, ShowCardId = 1 },
                    new SubjectCategoryShowCard() { Id = 2, SubjectCategoryId = 2, ShowCardId = 2 }
                    //new SubjectCategoryShowCard() { Id = 3, SubjectCategoryId = 3, ShowCardId = 1 },
                    //new SubjectCategoryShowCard() { Id = 4, SubjectCategoryId = 9, ShowCardId = 1 },
                    //new SubjectCategoryShowCard() { Id = 5, SubjectCategoryId = 1, ShowCardId = 2 },
                    //new SubjectCategory() { Id = 6, SubjectId = 2, CategoryId = 2 },
                    //new SubjectCategory() { Id = 7, SubjectId = 3, CategoryId = 2 },
                    //new SubjectCategory() { Id = 8, SubjectId = 9, CategoryId = 2 },
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
