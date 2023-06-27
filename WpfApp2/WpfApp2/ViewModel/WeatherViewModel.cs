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
    internal class WeatherViewModel : BindingHelper
    {
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

        public CityViewModel CityViewModel { get; set; }

        public WeatherViewModel()
        {
            DateTime now = DateTime.Now;
            string formattedTime = now.ToString("HH:mm");
            HourlyWeatherList = new ObservableCollection<HourlyWeather>
            {
                new HourlyWeather(formattedTime, 25, 70, 23),
                new HourlyWeather(formattedTime, 25, 70, 23),
                new HourlyWeather(formattedTime, 25, 70, 23),
                new HourlyWeather(formattedTime, 25, 70, 23),
                new HourlyWeather(formattedTime, 25, 70, 23),
                new HourlyWeather(formattedTime, 25, 70, 23),
                new HourlyWeather(formattedTime, 25, 70, 23),
                new HourlyWeather(formattedTime, 25, 70, 23),
                new HourlyWeather(formattedTime, 25, 70, 23),
                new HourlyWeather(formattedTime, 25, 70, 23),
            };
            CityViewModel = new CityViewModel();
            
        }
    }
}
