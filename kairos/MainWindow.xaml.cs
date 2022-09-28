using System;
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
       

        private void SIZ(object sender, RoutedEventArgs e)
        {
            Process.Start("https://demo.roboflow.com/ai-fswt8/1?publishable_key=rf_wnouWHH6xeUBMtzm5Ej7cicEYat2");
        }

        private void help(object sender, RoutedEventArgs e)
        {
            NavigationWindow navWIN = new NavigationWindow();
            navWIN.Content = new Page2();
            navWIN.Show();
        }
    }
   
}
