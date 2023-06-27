using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    internal class HourlyWeather
    {
        public DateTime Time { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int FeelsLike { get; set; }

        public HourlyWeather(DateTime time, int temperature, int humidity, int feelsLike)
        {
            Time = time;
            Temperature = temperature;
            Humidity = humidity;
            FeelsLike = feelsLike;
        }
    }
}
