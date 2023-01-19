using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Web.Areas.Admin.Models.Dtos;

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
            _showCardManager = showCardManager;
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
    }
}
