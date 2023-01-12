using OnlineTutor.Business.Abstract;
using OnlineTutor.Data.Abstract;
using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Business.Concrete
{
    public class ShowCardManager : IShowCardService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShowCardManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task CreateAsync(ShowCard showCard)
        {
            throw new NotImplementedException();
        }

        public void Delete(ShowCard showCard)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ShowCard>> GetAllAsync()
        {
            return await _unitOfWork.ShowCards.GetAllAsync();
        }

        public Task<ShowCard> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ShowCard>> GetHomePageShowCardsAsync()
        {
            return await _unitOfWork.ShowCards.GetHomePageShowCardsAsync();
        }

        public List<ShowCard> GetShowCardsByCategory()
        {
            throw new NotImplementedException();
        }

        public void Update(ShowCard showCard)
        {
            throw new NotImplementedException();
        }
    }
}
