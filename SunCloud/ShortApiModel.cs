using static ShortApiModel;
using System.Collections.Generic;
using System;

public class ShortApiModel
{

    internal ShortApiModel()
    { }

    public ShortApiModel(string city, double temperature, double feelsLikeTemperature, double maxTemperature,
        double minTemperature, double pressure, double humidity, double windSpeed, string windDirection, double geoLat,
        double geoLon)
    {
        CityObj.Name = city;
        CityObj.GeoLat = geoLat;
        CityObj.GeoLon = geoLon;
        WeatherObject.City = CityObj.Name;
        WeatherObject.Temperature = temperature;
        WeatherObject.FeelsLikeTemperature = feelsLikeTemperature;
        WeatherObject.MaxTemperature = maxTemperature;
        WeatherObject.MinTemperature = minTemperature;
        WeatherObject.WindSpeed = windSpeed;
        WeatherObject.WindDirection = windDirection;
        WeatherObject.Pressure = pressure;
        WeatherObject.Humidity = humidity;
        WeatherObject.HourlyWeatherForecast = new List<HourlyWeather>();
    }
    public Weather WeatherObject = new Weather();
    public City CityObj = new City();

    /// <summary>
    /// Класс, содержащий информацию о погоде в конкретном городе
    /// </summary>
    public class Weather
    {

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Текущая температура в градусах Цельсия
        /// </summary>
        public double Temperature { get; set; }

        /// <summary>
        /// Ощущаемая температура в градусах Цельсия
        /// </summary>
        public double FeelsLikeTemperature { get; set; }

        /// <summary>
        /// Максимальная температура в градусах Цельсия за день
        /// </summary>
        public double MaxTemperature { get; set; }

        /// <summary>
        /// Минимальная температура в градусах Цельсия за день
        /// </summary>
        public double MinTemperature { get; set; }

        /// <summary>
        /// Атмосферное давление в мм рт. ст.
        /// </summary>
        public double Pressure { get; set; }

        /// <summary>
        /// Влажность в процентах
        /// </summary>
        public double Humidity { get; set; }

        /// <summary>
        /// Скорость ветра в м/с
        /// </summary>
        public double WindSpeed { get; set; }

        /// <summary>
        /// Направление ветра
        /// </summary>
        public string WindDirection { get; set; }

        /// <summary>
        /// Список объектов HourlyWeather, содержащих почасовой прогноз погоды
        /// </summary>
        public List<HourlyWeather> HourlyWeatherForecast { get; set; }
    }

    /// <summary>
    /// Класс, содержащий информацию о погоде на определенный час
    /// </summary>
    public class HourlyWeather
    {
        public HourlyWeather(DateTime time, double pressure, string weather, double temperature, double feelsLikeTemperature, double humidity)
        {
            Time = time;
            Pressure = pressure;
            Weather = weather;
            Temperature = temperature;
            FeelsLikeTemperature = feelsLikeTemperature;
            Humidity = humidity;
        }

        /// <summary>
        /// Время прогноза
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Атмосферное давление в мм рт. ст.
        /// </summary>
        public double Pressure { get; set; }

        /// <summary>
        /// Текстовое описание погоды
        /// </summary>
        public string Weather { get; set; }

        /// <summary>
        /// Температура в градусах Цельсия
        /// </summary>
        public double Temperature { get; set; }

        /// <summary>
        /// Ощущаемая температура в градусах Цельсия
        /// </summary>
        public double FeelsLikeTemperature { get; set; }

        /// <summary>
        /// Влажность в процентах
        /// </summary>
        public double Humidity { get; set; }
    }

    /// <summary>
    /// Структура, содержащая координаты города
    /// </summary>
    public struct City
    {
        internal string Name;
        /// <summary>
        /// Широта города
        /// </summary>
        public string _GeoLat;

        /// <summary>
        /// Долгота города
        /// </summary>
        public string _GeoLon;
        /// <summary>
        /// Широта города
        /// </summary>
        public double GeoLat;

        /// <summary>
        /// Долгота города
        /// </summary>
        public double GeoLon;
    }
}