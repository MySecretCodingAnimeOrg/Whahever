using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string theme;

        public static string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                var d = new ResourceDictionary { Source = new Uri($"/Properties/Styles/{value}.xaml", UriKind.Relative) };
                Current.Resources.MergedDictionaries.RemoveAt(0);
                //Current.Resources.MergedDictionaries.Clear();
                Current.Resources.MergedDictionaries.Add(d);
                WpfApp2.Properties.Settings.Default.CurrentTheme = theme;
                WpfApp2.Properties.Settings.Default.Save();

            }
        }
        public async Task CheckTimeAsync()
        {
           
            DateTime currentTime = DateTime.Now;
            if (currentTime.Minute >= 0 && currentTime.Minute <= 3)
            {
                WpfApp2.Properties.Settings.Default.CurrentTheme = "NightTheme";
                WpfApp2.Properties.Settings.Default.Save();
                Theme = WpfApp2.Properties.Settings.Default.CurrentTheme;
            }
            else if(currentTime.Minute >= 4 && currentTime.Minute <= 11)
            {
                WpfApp2.Properties.Settings.Default.CurrentTheme = "MorningTheme";
                WpfApp2.Properties.Settings.Default.Save();
                Theme = WpfApp2.Properties.Settings.Default.CurrentTheme;
            }
            else if (currentTime.Minute >= 12 && currentTime.Minute <= 16)
            {
                //DayTheme

                WpfApp2.Properties.Settings.Default.CurrentTheme = "DayTheme";
                WpfApp2.Properties.Settings.Default.Save();
                Theme = WpfApp2.Properties.Settings.Default.CurrentTheme;
            }   
            else if (currentTime.Minute >= 17 && currentTime.Hour <= 23)
            {
                WpfApp2.Properties.Settings.Default.CurrentTheme = "MorningTheme";
                WpfApp2.Properties.Settings.Default.Save();
                Theme = WpfApp2.Properties.Settings.Default.CurrentTheme;
            }
        }
        public async Task InitializeApp()
        {
            
            await CheckTimeAsync();
        }

        public App() { 
            InitializeComponent();
            InitializeApp();






        }


    }
}
