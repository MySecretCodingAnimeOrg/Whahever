﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ViewModel
{
    internal class WeatherViewModel
    {
        public CityViewModel CityViewModel { get; set; }

        public WeatherViewModel()
        {
            CityViewModel = new CityViewModel();
        }
    }
}
