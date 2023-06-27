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
            DateTime now = DateTime.Now;
            string formattedTime = now.ToString("HH:mm");
            HourlyWeatherList = new ObservableCollection<HourlyWeather>
            {
                //new HourlyWeather(),
                new HourlyWeather(formattedTime, 25, 70, 23, ""),
                new HourlyWeather(formattedTime, 25, 70, 23, ""),
                new HourlyWeather(formattedTime, 25, 70, 23, ""),
                new HourlyWeather(formattedTime, 25, 70, 23, ""),
                new HourlyWeather(formattedTime, 25, 70, 23, ""),
                new HourlyWeather(formattedTime, 25, 70, 23, ""),
                new HourlyWeather(formattedTime, 25, 70, 23, ""),
                new HourlyWeather(formattedTime, 25, 70, 23, ""),
                new HourlyWeather(formattedTime, 25, 70, 23, ""),
            };
        }
    }
}
