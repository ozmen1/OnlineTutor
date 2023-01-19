using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
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


    }
}
