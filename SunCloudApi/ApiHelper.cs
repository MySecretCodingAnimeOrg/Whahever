using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using Newtonsoft.Json;
using System.Windows;
using System.Windows.Input;

namespace SunCloudApi
{
    public static class ApiHelper
    {
        static string SuggestApiUrl = "https://suggestions.dadata.ru/suggestions/api/4_1/rs/suggest/address";
        static string YandexApiUrl = "https://api.weather.yandex.ru/v2/forecast?";
        static string JsonPath = AppDomain.CurrentDomain.BaseDirectory + "Weather.json";

        /// <summary>
        /// Получает объект погоды в сокращенном формате на основе данных из файла JSON.
        /// </summary>
        /// <returns>Объект погоды в сокращенном формате.</returns>
        public static ShortApiModel ShortObject()
        {
            YandexApiModel.Model deserializeObjectW = JsonConvert.DeserializeObject<YandexApiModel.Model>(File.ReadAllText(JsonPath));
            
            double? dayTempMax = deserializeObjectW.forecasts[0].parts.day.temp_max;
            double? nightTempMax = deserializeObjectW.forecasts[0].parts.night.temp_max;
            double? eveningTempMax = deserializeObjectW.forecasts[0].parts.evening.temp_max;
            double? morningTempMax = deserializeObjectW.forecasts[0].parts.morning.temp_max;
            double max = Convert.ToDouble(new List<double?> { dayTempMax, nightTempMax, morningTempMax, eveningTempMax }.Max());

            double? dayTempMin = deserializeObjectW.forecasts[0].parts.day.temp_min;
            double? nightTempMin = deserializeObjectW.forecasts[0].parts.night.temp_min;
            double? eveningTempMin = deserializeObjectW.forecasts[0].parts.evening.temp_min;
            double? morningTempMin = deserializeObjectW.forecasts[0].parts.morning.temp_min;
            double min = Convert.ToDouble(new List<double?> { dayTempMin, nightTempMin, morningTempMin, eveningTempMin }.Min());

            var item = deserializeObjectW.forecasts[0].hours;
            ShortApiModel shortModel = new ShortApiModel();
            shortModel.WeatherObject.HourlyWeatherForecast = new List<ShortApiModel.HourlyWeather>();


            shortModel = new ShortApiModel(deserializeObjectW.geo_object.locality.name, deserializeObjectW.fact.temp, (double)deserializeObjectW.fact.feels_like, max, min, (double)deserializeObjectW.fact.pressure_mm, (double)deserializeObjectW.fact.humidity, (double)deserializeObjectW.fact.wind_speed, deserializeObjectW.fact.wind_dir, (double)deserializeObjectW.info.lat, (double)deserializeObjectW.info.lon);
            for (var index = 0; index < deserializeObjectW.forecasts[0].hours.Count; index++)
            {
                var hour = deserializeObjectW.forecasts[0].hours[index];
                shortModel.WeatherObject.HourlyWeatherForecast.Add(new ShortApiModel.HourlyWeather(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(hour.hour), 0, 30), (double)hour.pressure_mm, hour.condition, (double)hour.temp, (double)hour.feels_like, (double)hour.humidity));
            }
            return shortModel;
        }

        static string GetWeather(double lat, double lon)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage message = new HttpRequestMessage(new HttpMethod("GET"), $"{YandexApiUrl}lat={lat.ToString().Replace(',', '.')}&lon={lon.ToString().Replace(',', '.')}&hours=true");
            message.Headers.TryAddWithoutValidation("X-Yandex-API-Key", "71270dec-97a3-493a-a7ed-a941ed70dc8f");
            HttpResponseMessage result;

            try
            {
                result = client.SendAsync(message).Result;
            }
            catch
            {
                
                throw new HttpRequestException("НЕТ ИНТЕРНЕТА ИЛИ МЕДЛЕННОЕ СОЕДИНЕНИЕ");
            }

            return result.Content.ReadAsStringAsync().Result;
        }

        static string GetCoord(string loc)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage message = new HttpRequestMessage(new HttpMethod("GET"), SuggestApiUrl + "?query=" + loc);
            message.Headers.TryAddWithoutValidation("Content-Type", "application/json");
            message.Headers.TryAddWithoutValidation("Accept", "application/json");
            message.Headers.TryAddWithoutValidation("Authorization", "Token 8a39ee02b3f0a9bb61cb71433648797399d0f2c9");
            HttpResponseMessage result;
            try
            {
                result = client.SendAsync(message).Result;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("НЕТ ИНТЕРНЕТА ИЛИ МЕДЛЕННОЕ СОЕДИНЕНИЕ");
                throw new HttpRequestException();
            }

            return result.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Создаёт JSON файл погоды, если его ещё нет в проекте
        /// </summary>
        /// <param name="Location">Локация, город, НП и т.д. где хотите узнать погоду</param>
        public static void JsonRender(string Location)
        {
            string json = "";
            if (!File.Exists(JsonPath))
            {
                var cords = GetCoord(Location);
                LocationApiModel.Root LatLon = JsonConvert.DeserializeObject<LocationApiModel.Root>(cords);
                double lat = double.Parse((LatLon.suggestions[0].data.geo_lat).Replace('.', ','));
                double lon = double.Parse(LatLon.suggestions[0].data.geo_lon.Replace('.', ','));
                json = GetWeather(lat, lon);
                File.WriteAllText(JsonPath, json);
            }
        }
    }
}