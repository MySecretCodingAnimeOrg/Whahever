using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp2.Model;
using WpfApp2.ViewModel.Helpers;

namespace WpfApp2.ViewModel
{
    internal class WeatherViewModel : BindingHelper
    {
        //public YandexApiModel.Model model;

        //var cords = ApiHelper.GetCoord(.Text);

        

        public SettingsViewModel settingsViewModel { get; set; }

        //public WeatherViewModel()
        //{ 
        //    settingsViewModel = new SettingsViewModel();
        //    //°
        //}
    }
}
