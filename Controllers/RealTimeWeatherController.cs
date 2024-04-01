using Microsoft.AspNetCore.Mvc;
using WeatherSite.Data;
using WeatherSite.Models;

namespace WeatherSite.Controllers
{
    public class RealTimeWeatherController : Controller
    {
        City city1 = new City();
        private string CityName {  get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string cityName)
        {
            WeatherSite.Data.API api = new API();
            city1.CityName = cityName;
            string url = $"https://weatherapi-com.p.rapidapi.com/current.json?q={city1.GetCityName()}";
            string url2 = $"https://weatherapi-com.p.rapidapi.com/current.json?q=Pretoria";
            WeatherData weather = api.GetData(url);

            return View(weather);
        }
    }
}
