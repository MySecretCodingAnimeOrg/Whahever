using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.ViewModel.Helpers;

namespace WpfApp2.ViewModel
{
    internal class StartViewModel : BindingHelper
    {
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                (sender as MainWindow).DragMove();
        }
    }
}
