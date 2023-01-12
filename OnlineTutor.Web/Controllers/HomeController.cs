using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Business.Concrete;
using OnlineTutor.Data.Abstract;
using OnlineTutor.Entity.Concrete;
using OnlineTutor.Web.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace OnlineTutor.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShowCardService _showCardManager;
        private readonly ICategoryService _categoryManager;

        public HomeController(IShowCardService showCardManager, ICategoryService categoryManager)
        {
            _showCardManager = showCardManager;
            _categoryManager = categoryManager;
        }

        public async Task<IActionResult> Index(int id)
        {
            var categories = await _categoryManager.GetCategoriesWithSubjectsAsync(id);

            List<CategoryDto> categoryDtos = categories.Select(x => new CategoryDto
            {
                Name = x.Name,
                Id = x.Id,
                Description = x.Description,
                Url = x.Url,
                SubjectDtos = x.SubjectCategories.Select(x => new SubjectDto
                {
                    Id = x.Subject.Id,
                    Name = x.Subject.Name,
                    Description = x.Subject.Description,
                    Url = x.Subject.Url
                }).ToList()
            }).ToList();
            

            List<ShowCard> showCards = await _showCardManager.GetHomePageShowCardsAsync();

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