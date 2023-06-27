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
        public ICommand CheckWeatherCommand { get; set; }

        public UC_MainWindow_CityViewModel()
        {
            CheckWeatherCommand = new RelayCommand(CheckWeather);
        }

        private void CheckWeather()
        {
            var cur = Application.Current.MainWindow;
            Application.Current.MainWindow = new Window2();
            Application.Current.MainWindow.Show();
            cur.Close();
        }
    }
}
