using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Core;
using OnlineTutor.Entity.Concrete;
using OnlineTutor.Web.Areas.Admin.Models.Dtos;
using OnlineTutor.Web.Models;

namespace OnlineTutor.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ShowCardController : Controller
    {
        private readonly IShowCardService _showCardManager;
        private readonly ICategoryService _categoryManager;

        public ShowCardController(IShowCardService showCardManager, ICategoryService categoryManager)
        {
            _showCardManager = showCardManager;
            _categoryManager = categoryManager;
        }
        public async Task<IActionResult> Index()
        {
            var showCards = await _showCardManager.GetShowCardsWithSubjects();
            var showCardListDto = showCards
                .Select(sc => new ShowCardListDto
                {
                    ShowCard = sc
                }).ToList();
            return View(showCardListDto);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryManager.GetAllAsync();
            var showCardAddDto = new ShowCardAddDto
            {
                Categories = categories
            };
            return View(showCardAddDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShowCardAddDto showCardAddDto)
        {
            if (ModelState.IsValid)
            {
                var url = Jobs.InitUrl(showCardAddDto.Name);
                var showCard = new ShowCard
                {
                    Title = showCardAddDto.Name,
                    Price = showCardAddDto.Price,
                    Description = showCardAddDto.Description,
                    Url = url,
                    //IsApproved = productAddDto.IsApproved,
                    IsHome = showCardAddDto.IsHome,
                    //ImageUrl = Jobs.UploadImage(productAddDto.ImageFile)
                };
                await _showCardManager.CreateShowCardAsync(showCard, showCardAddDto.SelectedCategoryIds);
                return RedirectToAction("Index");
            }
            var categories = await _categoryManager.GetAllAsync();
            showCardAddDto.Categories = categories;
            //showCardAddDto.ImageUrl = showCardAddDto.ImageUrl;
            return View(showCardAddDto);
        }
    }
}
