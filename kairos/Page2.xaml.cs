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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void cat3(object sender, RoutedEventArgs e)
        {
            Process.Start("https://banstra.github.io/iiCars/");
        }

        private void SIZ(object sender, RoutedEventArgs e)
        {
            Process.Start("https://demo.roboflow.com/ai-fswt8/1?publishable_key=rf_wnouWHH6xeUBMtzm5Ej7cicEYat2");
        }
    }
}
