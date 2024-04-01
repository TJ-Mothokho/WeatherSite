using WeatherSite.Models;

namespace WeatherSite.Data
{
    public class API
    {
        public WeatherData GetData(string city, string apiKey)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", apiKey);
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com");

            string url = $"https://weatherapi-com.p.rapidapi.com/current.json?q={city}";

            WeatherData weatherData = client.GetFromJsonAsync<WeatherData>(url).Result;



            return weatherData;
        }
    }
}
