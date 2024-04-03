using WeatherSite.Models;

namespace WeatherSite.Data
{
    public class RealTimeWeatherAPI
    {
        public WeatherData GetData(string city)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "c0e19bd40cmshd91a9f7f18f45eap101ac0jsneec7c637be67");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com");

            string url = $"https://weatherapi-com.p.rapidapi.com/current.json?q={city}";

            WeatherData weatherData = client.GetFromJsonAsync<WeatherData>(url).Result;



            return weatherData;
        }
    }
}
