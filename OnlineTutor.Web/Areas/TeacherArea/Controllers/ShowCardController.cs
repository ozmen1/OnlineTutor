using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Business.Concrete;
using OnlineTutor.Core;
using OnlineTutor.Entity.Concrete;
using OnlineTutor.Entity.Concrete.Identity;
using OnlineTutor.Web.Areas.TeacherArea.Models;

namespace OnlineTutor.Web.Areas.TeacherArea.Controllers
{
    [Area("TeacherArea")]
    public class ShowCardController : Controller
    {
        //private readonly UserManager<User> _userManager;
        private readonly IShowCardService _showCardManager;
        private readonly ICategoryService _categoryManager;
        private readonly ISubjectService _subjectManager;
        private readonly ITeacherService _teacherManager;

        public ShowCardController(IShowCardService showCardManager, ICategoryService categoryManager, ISubjectService subjectManager, ITeacherService teacherManager)
        {
            _showCardManager = showCardManager;
            _categoryManager = categoryManager;
            _subjectManager = subjectManager;
            _teacherManager = teacherManager;
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

            var teachers = await _teacherManager.GetAllAsync();

            //var user = await _userManager.GetUserAsync(User);

            ShowCardAddWithCategoryDto showCardWithCategoryDto = new ShowCardAddWithCategoryDto
            {
                CategoryDtos = categoryDtos,
                Teachers = teachers
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
                    TeacherId = showCardAddWithCategoryDto.SelectedTeacherId
                    //ImageUrl = Jobs.UploadImage(productAddDto.ImageFile)
                };
                await _showCardManager.CreateShowCardAsync(showCard, showCardAddWithCategoryDto.SelectedCategoryId, showCardAddWithCategoryDto.SelectedSubjectId, showCardAddWithCategoryDto.SelectedTeacherId);
                return RedirectToAction("Index");
            }
            return View(showCardAddWithCategoryDto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var showCard = await _showCardManager.GetByIdAsync(id);
            if (showCard == null)
            {
                return NotFound();
            }

            _showCardManager.Delete(showCard);
            return RedirectToAction("Index");
        }
    }
}
