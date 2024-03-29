﻿using Microsoft.AspNetCore.Mvc;
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
        //private readonly ICategoryService _categoryManager;

        public HomeController(IShowCardService showCardManager)
        {
            _showCardManager = showCardManager;
        }

        public async Task<IActionResult> Index()
        {
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
                    FirstName = showCard.Teacher.FirstName,
                    LastName = showCard.Teacher.LastName

                });
            }
            return View(showCardDtos);
        }
    }
}