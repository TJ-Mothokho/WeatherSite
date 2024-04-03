using Microsoft.AspNetCore.Mvc;
using WeatherSite.Data;
using WeatherSite.Models;

namespace WeatherSite.Controllers
{
    public class RealTimeWeatherController : Controller
    {
        WeatherData weather;
        WeatherSite.Data.RealTimeWeatherAPI api = new RealTimeWeatherAPI();
        
        public IActionResult Index()
        {
            weather = api.GetData("Paris"); //Default Parameter
            return View(weather);
        }

        [HttpPost]
        public IActionResult Index(string cityName)
        {
            if (cityName.Contains(" "))
            {
                cityName = cityName.Replace(" ", "%20");
            }

            weather = api.GetData(cityName);

            return View(weather);
        }

    }
}
