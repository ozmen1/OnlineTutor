using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Business.Abstract
{
    public interface IShowCardService
    {
        Task<ShowCard> GetByIdAsync(int id);
        Task<List<ShowCard>> GetAllAsync();
        Task CreateAsync(ShowCard showCard);
        void Update(ShowCard showCard);
        void Delete(ShowCard showCard);
        List<ShowCard> GetShowCardsByCategory();
        Task<List<ShowCard>> GetHomePageShowCardsAsync();
    }
}
