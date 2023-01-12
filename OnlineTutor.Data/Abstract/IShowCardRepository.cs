using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Abstract
{
    public interface IShowCardRepository : IRepository<ShowCard>
    {
        Task<List<ShowCard>> GetShowCardsByCategoryAsync(string category);
        Task<List<ShowCard>> GetHomePageShowCardsAsync();
        Task<ShowCard> GetShowCardDetailsByUrlAsync(string showCardUrl);
        Task<List<ShowCard>> GetProductsWithCategories();
        Task CreateShowCardAsync(ShowCard showCard, int[] selectedCategoryIds);
        Task<ShowCard> GetShowCardsWithCategories(int id);
        Task<List<ShowCard>> GetShowCardsByTeacherAsync(int teacherId);
        Task UpdateShowCardAsync(ShowCard showCard, int[] selectedCategoryIds);
        Task UpdateIsHomeAsync(ShowCard showCard);
        Task UpdateIsApprovedAsync(ShowCard showCard);
        Task<List<ShowCard>> GetSearchResultsAsync(bool? isApproved, bool? isHome, string searchString, Category? category, Subject? subject);
        void isActive(ShowCard showCard);
    }
}
