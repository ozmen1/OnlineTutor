﻿using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Business.Concrete;
using OnlineTutor.Entity.Concrete;
using OnlineTutor.Web.Models;

namespace OnlineTutor.Web.Controllers
{
    public class ShowCardController : Controller
    {
        private readonly IShowCardService _showCardManager;
        private readonly ICategoryService _categoryManager;

        public ShowCardController(IShowCardService showCardManager, ICategoryService categoryManager)
        {
            _showCardManager = showCardManager;
            _categoryManager = categoryManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> ShowCardDetails(string showCardUrl)
        //{
        //    if (showCardUrl == null)
        //    {
        //        return NotFound();
        //    }
        //    var showCardNew = await _showCardManager.GetShowCardDetailsByUrlAsync(showCardUrl);
        //    ShowCardDetailsDto showCardDetailsDto = new ShowCardDetailsDto
        //    {
        //        Id = showCardNew.Id,
        //        Title = showCardNew.Title,
        //        Price = showCardNew.Price,
        //        //ImageUrl = showCard.ImageUrl,
        //        Url = showCardNew.Url,
        //        Description = showCardNew.Description
        //        //Categories = showCard
        //        //    .SubjectCategories
        //        //    .Select(sc => sc.Category)
        //        //    .ToList()
        //    };

        //    return View(showCardDetailsDto);
        }

        public async Task<IActionResult> ListShowCardsBySubject(string subjectName, int id)
        {
            var categories = await _categoryManager.GetCategoriesWithSubjectsAsync(id);

            List<CategoryDto> categoryDtos = categories.Select(x => new CategoryDto
            {
                Name = x.Name,
                Id = x.Id,
                SubjectDtos = x.SubjectCategories
                .Select(x => new SubjectDto
                {
                    Id = x.Subject.Id,
                    Name = x.Subject.Name,
                }).ToList()
            }).ToList();


            List<ShowCard> showCards = await _showCardManager.GetShowCardsBySubjectAsync(subjectName, id);

            List<ShowCardDto> showCardDtos = new List<ShowCardDto>();
            foreach (var showCard in showCards)
            {
                showCardDtos.Add(new ShowCardDto
                {
                    Id = showCard.Id,
                    Title = showCard.Title,
                    Description = showCard.Description,
                    Price = showCard.Price,
                    Url = showCard.Url,
                    FirstName = showCard.Teacher.FirstName,
                    LastName = showCard.Teacher.LastName

                });
            }

            ShowCardWithCategoryDto showCardWithCategoryDto = new ShowCardWithCategoryDto
            {
                ShowCardDtos = showCardDtos,
                CategoryDtos = categoryDtos
            };
            return View(showCardWithCategoryDto);

        }
    }
}
