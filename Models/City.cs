namespace WeatherSite.Models
{
    public class City
    {
        public string CityName { get; set; }
        public string GetCityName()
        {
            
            if(CityName.Contains(" "))
            {
                string cityName = CityName.Replace(" ", "%20");
                return cityName;
            }
            else
            {
                return CityName;
            }
            
        }
    }
}
