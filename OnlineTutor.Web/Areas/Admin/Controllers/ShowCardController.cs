using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Core;
using OnlineTutor.Entity.Concrete;
using OnlineTutor.Web.Areas.Admin.Models.Dtos;

namespace OnlineTutor.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ShowCardController : Controller
    {
        private readonly IShowCardService _showCardManager;
        private readonly ICategoryService _categoryManager;
        private readonly ISubjectService _subjectManager;

        public ShowCardController(IShowCardService showCardManager, ICategoryService categoryManager, ISubjectService subjectManager)
        {
            _showCardManager = showCardManager;
            _categoryManager = categoryManager;
            _subjectManager = subjectManager;
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
            var categories = await _categoryManager.GetCategoriesWithSubjectsAsync();

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

            ShowCardAddWithCategoryDto showCardWithCategoryDto = new ShowCardAddWithCategoryDto
            {
                CategoryDtos = categoryDtos
            };
            return View(showCardWithCategoryDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShowCardAddWithCategoryDto showCardAddWithCategoryDto)
        {
            if (ModelState.IsValid)
            {
                var url = Jobs.InitUrl(showCardAddWithCategoryDto.Name);
                var showCard = new ShowCard
                {
                    Title = showCardAddWithCategoryDto.Name,
                    Price = showCardAddWithCategoryDto.Price,
                    Description = showCardAddWithCategoryDto.Description,
                    Url = url,
                    //IsApproved = productAddDto.IsApproved,
                    IsHome = showCardAddWithCategoryDto.IsHome,
                    //ImageUrl = Jobs.UploadImage(productAddDto.ImageFile)
                };
                await _showCardManager.CreateShowCardAsync(showCard, showCardAddWithCategoryDto.SelectedCategoryId, showCardAddWithCategoryDto.SelectedSubjectId);
                return RedirectToAction("Index");
            }
            //var categories = await _categoryManager.GetCategoriesWithSubjectsAsync();

            //List<CategoryDto> categoryDtos = categories.Select(x => new CategoryDto
            //{
            //    Name = x.Name,
            //    Id = x.Id,
            //    Description = x.Description,
            //    Url = x.Url,
            //    SubjectDtos = x.SubjectCategories.Select(x => new SubjectDto
            //    {
            //        Id = x.Subject.Id,
            //        Name = x.Subject.Name,
            //        Description = x.Subject.Description,
            //        Url = x.Subject.Url
            //    }).ToList()
            //}).ToList();

            //ShowCardAddWithCategoryDto showCardWithCategoryDto = new ShowCardAddWithCategoryDto
            //{
            //    CategoryDtos = categoryDtos
            //};

            //showCardAddDto.ImageUrl = showCardAddDto.ImageUrl;
            return View(showCardAddWithCategoryDto);
        }
    }
}
