using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ViewModel.Helpers;

namespace WpfApp2.ViewModel
{
    internal class UC_Left_menuViewModel : BindingHelper
    {
        //private List<DateTime> timePoints = new List<DateTime>()
        //{
        //    new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0),
        //    new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 0, 0),
        //    new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 0, 0)
        //};

        //private List<int> temperatures = new List<int>();

        //public List<int> Temperatures
        //{
        //    get { return temperatures; }
        //    set
        //    {
        //        temperatures = value;
        //        OnPropertyChanged(nameof(Temperatures));
        //    }
        //}

        //private void LoadHourlyWeather()
        //{

        //    foreach (var timePoint in timePoints)
        //    {
        //        var hourlyWeather = hourlyWeatherList.FirstOrDefault(weather => weather.Time == timePoint.ToString("HH:mm"));
        //        if (hourlyWeather != null)
        //        {
        //            temperatures.Add(hourlyWeather.Temperature);
        //        }
        //    }
        //}
    }
}
