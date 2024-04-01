using Microsoft.AspNetCore.Mvc;
using WeatherSite.Data;
using WeatherSite.Models;

namespace WeatherSite.Controllers
{
    public class RealTimeWeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string apiKey, string cityName)
        {
            WeatherSite.Data.API api = new API();

            if (cityName.Contains(" "))
            {
                cityName = cityName.Replace(" ", "%20");
            }

            WeatherData weather = api.GetData(cityName, apiKey);

            return View(weather);
        }

    }
}
