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
                .Where(sc=>sc.IsHome)
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

        public Task<ShowCard> GetShowCardDetailsByUrlAsync(string showCardUrl)
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
