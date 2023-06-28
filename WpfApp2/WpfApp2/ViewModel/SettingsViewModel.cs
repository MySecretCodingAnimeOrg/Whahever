using System;
using System.Collections.Generic;
using WpfApp2.ViewModel.Helpers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;
using WpfApp2.Model;
using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace WpfApp2.ViewModel
{
    internal class SettingsViewModel : BindingHelper
    {
        //private string cityName;

        //public string CityName
        //{
        //    get { return cityName; }
        //    set
        //    {
        //        if (cityName != value)
        //        {
        //            cityName = value;
        //            OnPropertyChanged(nameof(CityName));
        //        }
        //    }
        //}

        //public UC_SettingsCardViewModel uC_SettingsCardViewModel;
        //public UC_MainWindow_CityViewModel cityViewModel;

        public SettingsViewModel()
        {
        }



    }
}
