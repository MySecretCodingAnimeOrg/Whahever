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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            Application.Current.MainWindow = this;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Theme = "NightTheme";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Theme = "DayTheme";
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                (sender as Window2).DragMove();
        }

        private void Settings_Page(object sender, RoutedEventArgs e)
        {
            App.Theme = "MorningTheme";
        }
    }
}
