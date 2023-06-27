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
            MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApiHelper.JsonRender("Moskva");
            var dw = ApiHelper.ShortObject().WeatherObject.HourlyWeatherForecast;
            foreach (var d in dw)
            {
                Box.Items.Add(d.Temperature);
            }
            var tb = new TextBlock();
            tb.Text = "Погода";
            Box.FontSize = 14;
        }
    }
}
