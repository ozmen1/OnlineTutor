﻿using OnlineTutor.Business.Abstract;
using OnlineTutor.Data.Abstract;
using OnlineTutor.Data.Concrete;
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
            _unitOfWork.ShowCards.Delete(showCard);
            _unitOfWork.Save();
        }

        public async Task<List<ShowCard>> GetAllAsync()
        {
            return await _unitOfWork.ShowCards.GetAllAsync();
        }

        public async Task<ShowCard> GetByIdAsync(int id)
        {
            return await _unitOfWork.ShowCards.GetByIdAsync(id);
        }

        public async Task<List<ShowCard>> GetHomePageShowCardsAsync()
        {
            return await _unitOfWork.ShowCards.GetHomePageShowCardsAsync();
        }

        public async Task<List<ShowCard>> GetShowCardsWithSubjects()
        {
            return await _unitOfWork.ShowCards.GetShowCardsWithSubjects();
        }

        public async Task<ShowCard> GetShowCardDetailsByUrlAsync(string showCardUrl)
        {
            return await _unitOfWork.ShowCards.GetShowCardDetailsByUrlAsync(showCardUrl);
        }

        public List<ShowCard> GetShowCardsByCategory()
        {
            throw new NotImplementedException();
        }

        public void Update(ShowCard showCard)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ShowCard>> GetShowCardsBySubjectAsync(int subjectId, int categoryId)
        {
            return await _unitOfWork.ShowCards.GetShowCardsBySubjectAsync(subjectId, categoryId);
        }

        public async Task CreateShowCardAsync(ShowCard showCard, int selectedCategoryId, int selectedSubjectId, string selectedTeacherId)
        {
            await _unitOfWork.ShowCards.CreateShowCardAsync(showCard, selectedCategoryId, selectedSubjectId, selectedTeacherId);
        }
    }
}
