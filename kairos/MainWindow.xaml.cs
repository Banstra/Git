﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace kairos
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cat(object sender, RoutedEventArgs e)
        {
            
                MainFrame.NavigationService.Navigate(new Otrasl());
                Manager.MainFrame = MainFrame;
     
        }
        private void cat1(object sender, RoutedEventArgs e)
        {

            MainFrame.NavigationService.Navigate(new Page2());
            

        }
    }
   
}
