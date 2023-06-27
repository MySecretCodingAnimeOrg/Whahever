using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ViewModel.Helpers;

namespace WpfApp2.Model
{
    public class City : BindingHelper
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public City() {}

        public City(string name, string countryCode, double latitude, double longitude)
        {
            Name = name;
            CountryCode = countryCode;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
