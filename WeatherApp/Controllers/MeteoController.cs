using WeatherApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WeatherApp.Controllers
{
    public class MeteoController : Controller
    {
        private readonly ILogger<MeteoController> _logger;
        private readonly Random _rand;

        public MeteoController(ILogger<MeteoController> logger)
        {
            _logger = logger;
            _rand = new Random();
        }

        [HttpGet]
        public IActionResult Index(string city, string picture)
        {
            var temperature = _rand.Next(-10, 30) + _rand.NextDouble();

            var meteo = new MeteoViewModel()
            {
                City = city,
                Temperature = Math.Round(temperature, 1),
                Picture = picture
            };

            return View(meteo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}