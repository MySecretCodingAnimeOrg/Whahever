using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;

namespace SunCloud.ViewModel
{
    public static class ApiHelper
    {
        public static string SuggestApiUrl = "https://suggestions.dadata.ru/suggestions/api/4_1/rs/suggest/address";
        public static string ApiUrl = "https://api.weather.yandex.ru/v2/forecast?lat=50&lon=50&hours=true";
        public static string GetWeather(double lat, double lon)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage message = new HttpRequestMessage(new HttpMethod("GET"), $"https://api.weather.yandex.ru/v2/forecast?lat={lat.ToString().Replace(',','.')}&lon={lon.ToString().Replace(',', '.')}&hours=true");
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

        public static string GetCoord(string loc)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage message = new HttpRequestMessage(new HttpMethod("GET"), SuggestApiUrl+ "?query=" + loc);
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
                throw new HttpRequestException("НЕТ ИНТЕРНЕТА ИЛИ МЕДЛЕННОЕ СОЕДИНЕНИЕ");
            }


            return result.Content.ReadAsStringAsync().Result;
        }
    }
}