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
using WpfApp2.ViewModel;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для UC_MainWindow_City.xaml
    /// </summary>
    public partial class UC_MainWindow_City : UserControl
    {
        public UC_MainWindow_City()
        {
            InitializeComponent();
            DataContext = new UC_MainWindow_CityViewModel();
        }

    }
}
