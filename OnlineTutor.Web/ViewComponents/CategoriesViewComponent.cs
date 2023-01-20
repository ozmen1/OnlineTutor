using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Business.Concrete;
using OnlineTutor.Web.Models;

namespace OnlineTutor.Web.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesViewComponent(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
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

            ShowCardWithCategoryDto showCardWithCategoryDto = new ShowCardWithCategoryDto
            {
                CategoryDtos = categoryDtos
            };
            return View(showCardWithCategoryDto);
        }
    }
}
