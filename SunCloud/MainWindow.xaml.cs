using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SunCloud.Model;
using SunCloud.ViewModel;
using Newtonsoft.Json;

namespace SunCloud
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ListBox listBox = new ListBox();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var er = new LocationApiModel.Suggestion();
            var cords = ApiHelper.GetCoord(extBox.Text);
            LocationApiModel.Root LatLon = JsonConvert.DeserializeObject<LocationApiModel.Root>(cords);

            double lat = double.Parse((LatLon.suggestions[0].data.geo_lat).Replace('.',','));
            double lon = double.Parse(LatLon.suggestions[0].data.geo_lon.Replace('.', ','));
            var json = ApiHelper.GetWeather(lat, lon);
            YandexApiModel.Model ys = JsonConvert.DeserializeObject<YandexApiModel.Model>(json);

            for (var index = 0; index < 1; index++)
            {
                var item = ys.forecasts[index];
                for (var i = 0; i < item.hours.Count; i++)
                {
                    var forecastByHour = item.hours[i];
                    Box.Items.Add("+" + forecastByHour.temp + $" ℃ в {i} часов");
                }
            }

            var tb = new TextBlock();
            tb.Text = "Погода";
            Box.FontSize = 14;
        }
    }
}
