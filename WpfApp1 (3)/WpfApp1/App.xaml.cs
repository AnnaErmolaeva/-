using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandlerException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Необработанная ошибка:" + e.Exception.Message, "ExceptionSample", MessageBoxButton.OK, MessageBoxImage.Warning);
            e.Handled = true;
        }

    }
}
