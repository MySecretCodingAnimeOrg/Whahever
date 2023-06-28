using SunCloudApi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;
using WpfApp2.ViewModel.Helpers;

namespace WpfApp2.ViewModel
{
    internal class UC_CardViewModel : BindingHelper
    {
        public ShortApiModel shortApiModel { get; set; }
        private ObservableCollection<HourlyWeather> hourlyWeatherList;

        public ObservableCollection<HourlyWeather> HourlyWeatherList
        {
            get { return hourlyWeatherList; }
            set
            {
                hourlyWeatherList = value;
                OnPropertyChanged(nameof(HourlyWeatherList));
            }
        }

        public UC_CardViewModel()
        {
            ApiHelper.JsonRender("Moscow");
            //ApiHelper.ShortObject();
            shortApiModel = ApiHelper.ShortObject();
            DateTime now = DateTime.Now;
            //string formattedTime = now.ToString("HH:mm");
            int hour = 0;
            HourlyWeatherList = new ObservableCollection<HourlyWeather>();
            foreach (var item in shortApiModel.WeatherObject.HourlyWeatherForecast)
            {
                string formattedTime = new DateTime(now.Year, now.Month, now.Day, hour, 0, 0).ToString("HH:mm");
                hourlyWeatherList.Add(new HourlyWeather(formattedTime, (int)item.Temperature, (int)item.Humidity, (int)item.FeelsLikeTemperature, ""));
                hour++;
                if (hour == 24)
                    break;
            }
        }
    }
}
