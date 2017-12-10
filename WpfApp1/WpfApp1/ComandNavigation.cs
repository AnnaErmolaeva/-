using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public class ComandNavigation
    {
        public static void MoveToWindow2()
        {
            Navigate<Window2, Window2ViewModel>();
        }
        protected static void Navigate<TWindow, TViewModel>()
            where TWindow : Window, new()
            where TViewModel : class
        {
            TWindow w = new TWindow();
            w.Show();
            TViewModel vm = Activator.CreateInstance(typeof(TViewModel)) as TViewModel;
            w.DataContext = vm;
        }
    }
}
