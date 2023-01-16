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

        public async Task<IActionResult> ShowCardDetails(string showCardUrl)
        {
            if (showCardUrl == null)
            {
                return NotFound();
            }
            var showCard = await _showCardManager.GetShowCardDetailsByUrlAsync(showCardUrl);
            ShowCardDetailsDto showCardDetailsDto = new ShowCardDetailsDto
            {
                Id = showCard.Id,
                Title = showCard.Title,
                Price = showCard.Price,
                //ImageUrl = showCard.ImageUrl,
                Url = showCard.Url,
                Description = showCard.Description,
                //Categories = showCard
                //    .SubjectCategories
                //    .Select(sc => sc.Category)
                //    .ToList()
            };

            return View(showCardDetailsDto);
        }

        public async Task<IActionResult> ListShowCardBySubject(string subject)
        {

            List<ShowCard> showCards = await _showCardManager.GetShowCardsBySubjectAsync(subject);
            List<ShowCardDto> showCardDtos = new List<ShowCardDto>();
            foreach (var showCard in showCards)
            {
                showCardDtos.Add(new ShowCardDto
                {
                    Id = showCard.Id,
                    Title = showCard.Title,
                    Price = showCard.Price,
                    Url = showCard.Url
                });
            }
            return View(showCardDtos);
        }
    }
}
