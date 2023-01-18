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

        public Task<List<ShowCard>> GetProductsWithCategories()
        {
            throw new NotImplementedException();
        }

        public Task<List<ShowCard>> GetSearchResultsAsync(bool? isApproved, bool? isHome, string searchString, Category category, Subject subject)
        {
            throw new NotImplementedException();
        }

        public async Task<ShowCard> GetShowCardDetailsByUrlAsync(string showCardUrl)
        {
            return await OnlineTutorContext
               .ShowCards
               .Where(s => s.Url == showCardUrl)
               .Include(s => s.Teacher)
               .Include(s => s.Subject)
               .Include(s => s.Subject.SubjectCategories)
               .ThenInclude(sc => sc.Category)
               .FirstOrDefaultAsync();
        }

        public Task<List<ShowCard>> GetShowCardsByCategoryAsync(string category)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ShowCard>> GetShowCardsBySubjectAsync(string subjectName)
        {
            var showCards = OnlineTutorContext.ShowCards.AsQueryable();
            if (subjectName != null)
            {
                showCards = showCards
                    .Include(p => p.SubjectCategories)
                    .ThenInclude(pc => pc.Category)
                    .Where(p => p.SubjectCategories.Any(pc => pc.Subject.Name == subjectName));
            }
            return await showCards.ToListAsync();
        }

        public Task<List<ShowCard>> GetShowCardsByTeacherAsync(int teacherId)
        {
            throw new NotImplementedException();
        }

        public Task<ShowCard> GetShowCardsWithCategories(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ShowCard>> GetShowCardsWithSubjects(int id)
        {
            return await OnlineTutorContext
                .ShowCards
                .Include(sc => sc.SubjectCategories)
                .ThenInclude(scc => scc.Subject)
                .ToListAsync();
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
