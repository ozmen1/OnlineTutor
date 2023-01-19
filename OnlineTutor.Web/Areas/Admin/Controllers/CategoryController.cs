using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Core;
using OnlineTutor.Entity.Concrete;
using OnlineTutor.Web.Areas.Admin.Models.Dtos;

namespace OnlineTutor.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;
        public CategoryController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryManager.GetAllAsync();
            var categoryListDto = new CategoryListDto
            {
                Categories = categories
            };
            return View(categoryListDto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
                var category = new Category
                {
                    Name = categoryAddDto.Name,
                    Description = categoryAddDto.Description,
                    Url = Jobs.InitUrl(categoryAddDto.Name)
                };
                await _categoryManager.CreateAsync(category);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            var categoryUpdateDto = new CategoryUpdateDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Url = category.Url
            };
            return View(categoryUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var category = await _categoryManager.GetByIdAsync(categoryUpdateDto.Id);
                if (category == null)
                {
                    return NotFound();
                }
                category.Name = categoryUpdateDto.Name;
                category.Description = categoryUpdateDto.Description;
                category.Url = Jobs.InitUrl(categoryUpdateDto.Name);

                _categoryManager.Update(category);
                return RedirectToAction("Index");
            }
            return View(categoryUpdateDto);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            _categoryManager.Delete(category);
            return RedirectToAction("Index");
        }
    }
}
