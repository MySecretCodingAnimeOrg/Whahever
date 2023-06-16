public class ShortApiModel
{
    public class Weather
    {
        public string City { get; set; } // город
        public double Temperature { get; set; } // температура
        public double FeelsLikeTemperature { get; set; } // ощущаемая температура
        public double MaxTemperature { get; set; } // максимальная температура
        public double MinTemperature { get; set; } // минимальная температура
        public double Pressure { get; set; } // давление
        public double Humidity { get; set; } // влажность
        public double WindSpeed { get; set; } // скорость ветра
        public string WindDirection { get; set; } // направление ветра
        public List<HourlyWeather> HourlyWeatherForecast { get; set; } // почасовой прогноз погоды
    }

    public class HourlyWeather
    {
        public DateTime Time { get; set; } // время
        public double Pressure { get; set; } // давление
        public string Weather { get; set; } // погода
        public double Temperature { get; set; } // температура
        public double FeelsLikeTemperature { get; set; } // ощущаемая температура
        public double Humidity { get; set; } // влажность
    }

    public struct City
    {
        public string GeoLat; //Широта
        public string GeoLon; //Долгота
    }
}
