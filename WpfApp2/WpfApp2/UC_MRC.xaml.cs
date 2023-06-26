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
    /// Логика взаимодействия для UC_MRC.xaml
    /// </summary>
    public partial class UC_MRC : UserControl
    {
        private bool Maximized;

        public UC_MRC()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive).Close();
            Environment.Exit(0);
        }

        private void Resize_Click(object sender, RoutedEventArgs e)
        {
            Maximized = !Maximized;
            if (Maximized)
            {
                try
                {
                    Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive).WindowState = WindowState.Maximized;
                }
                catch { }
            }
            else
                Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive).WindowState = WindowState.Normal;
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive).WindowState = WindowState.Minimized;
        }
    }
}
