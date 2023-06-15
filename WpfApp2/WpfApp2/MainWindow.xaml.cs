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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Theme = "LightTheme";
            MessageBox.Show("Light");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Theme = "DayTheme";
            MessageBox.Show("Day");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                (sender as MainWindow).DragMove();
        }

        
    }
}
