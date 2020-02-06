using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class WeatherInfo
    {
        public Main Main { get; set; }
        public List<Weather> weather { get; set; }


    }
}
