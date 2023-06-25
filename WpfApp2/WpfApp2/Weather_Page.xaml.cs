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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Weather_Page.xaml
    /// </summary>
    public partial class Weather_Page : Page
    {
        public Weather_Page()
        {
            InitializeComponent();
        }

        

        private void ban_Click(object sender, RoutedEventArgs e)
        {
            App.Theme = "NightTheme";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Theme = "MorningTheme";

        }

        private void x_click(object sender, RoutedEventArgs e)
        {
            //this.Resources["but1"] = this.Resource["dynamicResource"];
            //x.Background = this.FindResource("dynamicResource");
            App.Theme = "DayTheme";

        }
    }
}
