﻿using System;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private object _frame;

        public Page1()
        {
            InitializeComponent();
        }
        //REVIEW: В команду!
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.ShowDialog();
            //_frame.NavigationService.Navigate(new Uri("Page2.xaml", UriKind.Relative));
        }
    }
}
