using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    internal class HourlyWeather
    {
        public string Time { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int FeelsLike { get; set; }

        public HourlyWeather(string time, int temperature, int humidity, int feelsLike)
        {
            Time = time;
            Temperature = temperature;
            Humidity = humidity;
            FeelsLike = feelsLike;
        }
    }
}
