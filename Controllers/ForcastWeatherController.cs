using Microsoft.AspNetCore.Mvc;

namespace WeatherSite.Controllers
{
    public class ForcastWeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
