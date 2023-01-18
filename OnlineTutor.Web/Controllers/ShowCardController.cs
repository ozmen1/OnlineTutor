using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Entity.Concrete;
using OnlineTutor.Web.Models;

namespace OnlineTutor.Web.Controllers
{
    public class ShowCardController : Controller
    {
        private readonly IShowCardService _showCardManager;

        public ShowCardController(IShowCardService showCardManager)
        {
            _showCardManager = showCardManager;
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
        //}

        public async Task<IActionResult> ListShowCardsBySubject(string subjectName)
        {

            List<ShowCard> showCards = await _showCardManager.GetShowCardsBySubjectAsync(subjectName);
            List<ShowCardWithCategoryDto> showCardWithCategoryDtos = new List<ShowCardWithCategoryDto>();
            foreach (var showCard in showCards)
            {
                showCardWithCategoryDtos.Add(new ShowCardWithCategoryDto
                {
                    Id = showCardWithCategoryDtos,
                    Title = showCard.Title,
                    Price = showCard.Price,
                    Url = showCard.Url,
                    SubjectName = showCard.Subject.Name
                });
            }
            return View(showCardWithCategoryDtos);
        }
    }
}
