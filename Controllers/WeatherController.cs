using ServiceContract;
using Microsoft.AspNetCore.Mvc;
using WeatherServices;
using WeatherAppDIP.Models;

namespace WeatherAppDIP.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            var weather = _weatherService.GetCityWeather();
            return View(weather);
        }

        [Route("/weather/{cityCode?}")]
        public IActionResult Details(string? cityCode)
        {
            if (string.IsNullOrEmpty(cityCode))
            {
                return View();
            }
            CityWeather? city = _weatherService.GetCityCode();
        }
    }
}
