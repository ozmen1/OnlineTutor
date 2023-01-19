using Microsoft.EntityFrameworkCore;
using OnlineTutor.Data.Abstract;
using OnlineTutor.Data.Concrete.EfCore.Contexts;
using OnlineTutor.Entity.Concrete;
using OnlineTutor.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Concrete.EfCore.Repositories
{
    public class EfCoreShowCardRepository : EfCoreGenericRepository<ShowCard>, IShowCardRepository
    {

        public EfCoreShowCardRepository(OnlineTutorContext context) : base(context)
        {

        }

        private OnlineTutorContext OnlineTutorContext
        {
            get { return _context as OnlineTutorContext; }
        }

        public Task CreateShowCardAsync(ShowCard showCard, int[] selectedCategoryIds)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ShowCard>> GetHomePageShowCardsAsync()
        {
            return await OnlineTutorContext
                .ShowCards
                .Include(sc3 => sc3.Teacher)
                .Where(sc => sc.IsHome)
                .ToListAsync();
        }

        public async Task<ShowCard> GetShowCardDetailsByUrlAsync(string showCardUrl)
        {
            return await OnlineTutorContext
               .ShowCards
               .Where(s => s.Url == showCardUrl)
               .Include(s => s.Teacher)
               .Include(s => s.SubjectCategoryShowCards)
               .ThenInclude(s => s.SubjectCategory)
               .FirstOrDefaultAsync();
            //return await OnlineTutorContext
            //   .ShowCards
            //   .Where(s => s.Url == showCardUrl)
            //   .Include(s => s.Teacher)
            //   .Include(s => s.Subject)
            //   .Include(s => s.Subject.SubjectCategories)
            //   .ThenInclude(sc => sc.Category)
            //   .FirstOrDefaultAsync();
            //return null;
        }

        public async Task<List<ShowCard>> GetShowCardsBySubjectAsync(int subjectId, int categoryId)
        {
            var result = await OnlineTutorContext
            //return await OnlineTutorContext
                .ShowCards
                .Include(sc => sc.SubjectCategoryShowCards)
                .ThenInclude(scc => scc.SubjectCategory)
                .Where(x => x.SubjectCategoryShowCards.Any(scu => scu.SubjectCategory.SubjectId == subjectId && scu.SubjectCategory.CategoryId == categoryId))
                .Include(t=>t.Teacher)
                .ToListAsync();
                return result;
                
            //return await OnlineTutorContext
            //    .ShowCards
            //    .Include(sc => sc.SubjectCategories)
            //    .Include(sc => sc.)


            //var showCards = OnlineTutorContext.ShowCards.AsQueryable();
            //if (subjectName != null)
            //{
            //    showCards = showCards
            //        .Include(p => p.SubjectCategories)
            //        .ThenInclude(pc => pc.Category)
            //        .Where(p => p.SubjectCategories.Any(pc => pc.Category.Id == id && pc.Subject.Name == subjectName));
            //}
            //return await showCards.ToListAsync();

            //return null;
        }

        public async Task<List<ShowCard>> GetShowCardsWithSubjects(int id)
        {
            //return await OnlineTutorContext
            //    .ShowCards
            //    .Include(sc => sc.SubjectCategories)
            //    .ThenInclude(scc => scc.Subject)
            //    .ToListAsync();
            return null;
        }

        public Task<List<ShowCard>> GetProductsWithCategories()
        {
            throw new NotImplementedException();
        }

        public Task<List<ShowCard>> GetSearchResultsAsync(bool? isApproved, bool? isHome, string searchString, Category category, Subject subject)
        {
            throw new NotImplementedException();
        }


        public Task<List<ShowCard>> GetShowCardsByCategoryAsync(string category)
        {
            throw new NotImplementedException();
        }


        public Task<List<ShowCard>> GetShowCardsByTeacherAsync(int teacherId)
        {
            throw new NotImplementedException();
        }

        public Task<ShowCard> GetShowCardsWithCategories(int id)
        {
            throw new NotImplementedException();
        }


        public void isActive(ShowCard showCard)
        {
            throw new NotImplementedException();
        }

        public Task UpdateIsApprovedAsync(ShowCard showCard)
        {
            throw new NotImplementedException();
        }

        public Task UpdateIsHomeAsync(ShowCard showCard)
        {
            throw new NotImplementedException();
        }

        public Task UpdateShowCardAsync(ShowCard showCard, int[] selectedCategoryIds)
        {
            throw new NotImplementedException();
        }
    }
}
