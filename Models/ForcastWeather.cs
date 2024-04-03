 namespace WeatherSite.Models
{
    public class ForcastWeather
    {
        public Forcast Forcast { get; set; }
    }

    public class Forcast
    {
        public List<ForcastDay> ForcastDays { get; set; }
    }

    public class ForcastDay
    {
        public string Date { get; set; }
        public string Date_Epoch { get; set; }
        public Day Day { get; set; }
        public Astro Astro { get; set; }
        public List<Hour> Hours { get; set; }
    }

    public class Day
    {
        public double Maxtemp_c {  get; set; }
        public double Mintemp_c { get; set; }
        public double Maxtemp_f { get; set; }
        public double Mintemp_f { get; set; }
        public double Avgtemp_f { get; set; }
        public double Avgtemp_c { get; set; }
        public double Maxwind_mph { get; set; }
        public double Maxwind_kph { get; set; }
        public double Totalprecip_mm { get; set; }
        public double Totalprecip_in { get; set; }
        public double Totalsnow_cm { get; set; }
        public Condition Condition { get; set; }

    }

    public class Astro
    {
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string Moonrise { get; set; }
        public string Moonset { get; set; }
        public string Moon_Phase { get; set; }
        public int Moon_Illumination { get; set; }
        public int Is_Moon_Up { get; set; }
        public int Is_Sun_Up { get; set; }
    }

    public class Hour
    {
        public long Time_Epoch { get; set; }
        public string Time {  get; set; }
        public double Tempo_c {  get; set; }
        public double Tempo_f { get; set; }
        public int Is_Day { get; set; }
        public Condition Condition { get; set; }
    }

    
}
