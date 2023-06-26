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
        public ICommand WindowMouseDownCommand { get; set; }

        public StartViewModel()
        {
            WindowMouseDownCommand = new RelayCommand(WindowMouseDown);
        }

        private void WindowMouseDown()
        {
            var mainWindow = App.Current.MainWindow as MainWindow;
            mainWindow?.DragMove();
        }
    }
}
