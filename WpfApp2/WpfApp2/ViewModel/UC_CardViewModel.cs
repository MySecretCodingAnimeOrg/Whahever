using SunCloudApi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.Model;
using WpfApp2.ViewModel.Helpers;

namespace WpfApp2.ViewModel
{
    internal class UC_CardViewModel : BindingHelper
    {
        public ShortApiModel shortApiModel { get; set; }
        private UC_MainWindow_CityViewModel uC_MainWindow_CityViewModel;
        private ObservableCollection<HourlyWeather> hourlyWeatherList;

        //private string cityName;

        //public string CityName
        //{
        //    get { return cityName; }
        //    set
        //    {
        //        cityName = value;
        //        OnPropertyChanged(nameof(CityName));
        //        LoadHourlyWeather(CityName);
        //    }
        //}

        //private void Initialize()
        //{
        //    if (uC_MainWindow_CityViewModel != null)
        //    {
        //        string cityName = uC_MainWindow_CityViewModel.CityName;
        //        LoadHourlyWeather();
        //    }
        //}

        public ObservableCollection<HourlyWeather> HourlyWeatherList
        {
            get { return hourlyWeatherList; }
            set
            {
                hourlyWeatherList = value;
                OnPropertyChanged(nameof(HourlyWeatherList));
            }
        }

        public UC_CardViewModel(UC_MainWindow_CityViewModel mainWindowCityViewModel)
        {
            uC_MainWindow_CityViewModel = mainWindowCityViewModel;
            //string cityName = uC_MainWindow_CityViewModel.CityName;
            //LoadHourlyWeather(cityName);
            LoadHourlyWeather();
        }

        public UC_CardViewModel()
        {
            //UC_MainWindow_CityViewModel uC_MainWindow_CityViewModel= new UC_MainWindow_CityViewModel();
            //string cityName = uC_MainWindow_CityViewModel.CityName;
            //LoadHourlyWeather(cityName);
            LoadHourlyWeather();
            
        }

        //private void LoadHourlyWeather(string city)
        //{
        //    ApiHelper.JsonRender(city);
        //    //ApiHelper.ShortObject();
        //    shortApiModel = ApiHelper.ShortObject();
        //    DateTime now = DateTime.Now;
        //    //string formattedTime = now.ToString("HH:mm");
        //    int hour = 0;
        //    hourlyWeatherList = new ObservableCollection<HourlyWeather>();
        //    foreach (var item in shortApiModel.WeatherObject.HourlyWeatherForecast)
        //    {
        //        string formattedTime = new DateTime(now.Year, now.Month, now.Day, hour, 0, 0).ToString("HH:mm");
        //        hourlyWeatherList.Add(new HourlyWeather(formattedTime, (int)item.Temperature, (int)item.Humidity, (int)item.FeelsLikeTemperature, ""));
        //        hour++;
        //        if (hour == 24)
        //            break;
        //    }
        //}
        private void LoadHourlyWeather()
        {
            ApiHelper.JsonRender("Москва");
            //ApiHelper.ShortObject();
            shortApiModel = ApiHelper.ShortObject();
            DateTime now = DateTime.Now;
            //string formattedTime = now.ToString("HH:mm");
            int hour = 0;
            hourlyWeatherList = new ObservableCollection<HourlyWeather>();
            foreach (var item in shortApiModel.WeatherObject.HourlyWeatherForecast)
            {
                string formattedTime = new DateTime(now.Year, now.Month, now.Day, hour, 0, 0).ToString("HH:mm");
                string weatherDescription = item.Weather.ToLower();
                string iconPath = GetIconPathByWeatherDescription(weatherDescription);
                hourlyWeatherList.Add(new HourlyWeather(formattedTime, (int)item.Temperature, (int)item.Humidity, (int)item.FeelsLikeTemperature, iconPath));
                hour++;
                if (hour == 24)
                    break;
            }
            HourlyWeatherList = hourlyWeatherList;

        }

        //private List<HourlyWeather> GetWeatherDataForTimePoints(List<DateTime> timePoints)
        //{
        //    List<HourlyWeather> weatherData = new List<HourlyWeather>();

        //    foreach (var timePoint in timePoints)
        //    {
        //        var hourlyWeather = hourlyWeatherList.FirstOrDefault(weather => weather.Time == timePoint.ToString("HH:mm"));
        //        if (hourlyWeather != null)
        //        {
        //            weatherData.Add(new HourlyWeather
        //            {
        //                Time = timePoint.ToString("HH:mm"),
        //                Temperature = hourlyWeather.Temperature,
        //                WeatherDescription = hourlyWeather.
        //            });
        //        }
        //    }

        //    return weatherData;
        //}



        private string GetIconPathByWeatherDescription(string weatherDescription)
        {
            string basePath = "../../../Resources/";
            string fileExtension = ".png";

            switch (weatherDescription)
            {
                case "clear":
                    return basePath + "clear" + fileExtension;
                case "partly-cloudy":
                    return basePath + "partly_cloudy" + fileExtension;
                case "cloudy":
                    return basePath + "cloudy" + fileExtension;
                case "overcast":
                    return basePath + "overcast" + fileExtension;
                case "light-rain":
                    return basePath + "light-rain" + fileExtension;
                case "rain":
                    return basePath + "rain" + fileExtension;
                default:
                    return basePath + "default" + fileExtension;
            }
        }
    }
}
