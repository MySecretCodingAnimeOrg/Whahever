using static ShortApiModel;
using System.Collections.Generic;
using System;

public class ShortApiModel
{
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
        /// <summary>
        /// Широта города
        /// </summary>
        public string GeoLat;

        /// <summary>
        /// Долгота города
        /// </summary>
        public string GeoLon;
    }
}