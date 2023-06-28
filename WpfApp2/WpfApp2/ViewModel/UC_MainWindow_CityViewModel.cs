﻿using SunCloudApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp2.ViewModel.Helpers;

namespace WpfApp2.ViewModel
{
    internal class UC_MainWindow_CityViewModel : BindingHelper
    {
        public ShortApiModel shortApiModel { get; set; }

        public ICommand CheckWeatherCommand { get; set; }

        public event EventHandler<string> WeatherChecked;

        private string cityName;

        public string CityName
        {
            get { return cityName; }
            set
            {
                if (cityName != value)
                {
                    cityName = value;
                    OnPropertyChanged(nameof(CityName));
                }
            }
        }

        public UC_MainWindow_CityViewModel()
        {
            CheckWeatherCommand = new RelayCommand(CheckWeather);

        }   

        private void CheckWeather()
        {
            UC_CardViewModel uC_CardViewModel = new UC_CardViewModel(this);
            var cur = Application.Current.MainWindow;
            Application.Current.MainWindow = new Window2();
            //Application.Current.MainWindow.DataContext = new UC_CardViewModel
            
            Application.Current.MainWindow.Show();
            cur.Close();
        }
    }
}
