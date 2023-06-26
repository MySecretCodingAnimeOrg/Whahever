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
    /// Логика взаимодействия для UC_Graf.xaml
    /// </summary>
    public partial class UC_Graf : UserControl
    {
        public int a = 0;

        public UC_Graf()
        {
            InitializeComponent();
        }

        private void x_click(object sender, RoutedEventArgs e)
        {
            //this.Resources["but1"] = this.Resource["dynamicResource"];
            //x.Background = this.FindResource("dynamicResource");
            //App.Theme = "DayTheme";

            /*x.Style = (Style)FindResource("Button_Cliked");
            MessageBox.Show("sd");
            x.Style = (Style)FindResource("but1");
            */
            a = 1;
            Clicked_buttons(a);

        }
        public void Clicked_buttons(int a)
        {

            if (a == 1)
            {
                x.Style = (Style)FindResource("Button_Cliked");
                y.Style = (Style)FindResource("but1");
                z.Style = (Style)FindResource("but1");

            }
            

            else if (a == 2)
            {
                x.Style = (Style)FindResource("but1");
                y.Style = (Style)FindResource("Button_Cliked");
                z.Style = (Style)FindResource("but1");
            }
            

            else if (a == 3)
            {
                x.Style = (Style)FindResource("but1");
                y.Style = (Style)FindResource("but1");
                z.Style = (Style)FindResource("Button_Cliked");
            }
            else
            {
                x.Style = (Style)FindResource("but1");
                y.Style = (Style)FindResource("but1");
                z.Style = (Style)FindResource("but1");
            }
        }




        private void y_click(object sender, RoutedEventArgs e)
        {
            a = 2;
            Clicked_buttons(a);
        }

        private void z_click(object sender, RoutedEventArgs e)
        {
            a = 3;
            Clicked_buttons(a);
        }
    }
}
