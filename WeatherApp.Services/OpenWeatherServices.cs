using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class OpenWeatherServices
    {
        public WeatherInfo GetWeatherFor(string city)
        {
            string apiKey = "ab597816349d0acfa405e0e434b6644e";
            string Url = $"http://api.openweathermap.org/data/2.5/weather?appid={apiKey}&units=metric";
            using (var client = new WebClient())
            {
                string json = client.DownloadString(Url + $"&q={city}");
                WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(json);
                return weatherInfo;
            }
        }
    }
}
