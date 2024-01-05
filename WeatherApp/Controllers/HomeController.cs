using WeatherApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult DisplayMeteo()
        {
            var meteoCardComponent = new List<MeteoCardComponentViewModel>()
            {
                new()
                {
                    City = "Londre",
                    Picture= "https://images.unsplash.com/photo-1486299267070-83823f5448dd?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=facearea&facepad=2&w=320&h=320&q=80"
                },
                new()
                {
                    City = "Bristol",
                    Picture= "https://images.unsplash.com/photo-1612046264803-6d6b67fdee80?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=facearea&facepad=2&w=320&h=320&q=80"
                },
                new()
                {
                    City = "Oxford",
                    Picture= "https://images.unsplash.com/photo-1582542021865-bde52fd7c3cf?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=facearea&facepad=2&w=320&h=320&q=80"
                },
            };

            return PartialView("Components/MeteoCardComponent", meteoCardComponent);
        }
    }
}