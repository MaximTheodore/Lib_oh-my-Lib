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

namespace MyLib
{
    /// <summary>
    /// Логика взаимодействия для PageSecond.xaml
    /// </summary>
    public partial class PageSecond : Page
    {
        public PageSecond()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).Page.Content = new PageMain();
        }
        private void Light_click(object sender, RoutedEventArgs e)
        {
            App.Theme = "LightTheme.xaml";
        }

        private void Darck_click(object sender, RoutedEventArgs e)
        {
            App.Theme = "DarkTheme.xaml";
        }
    }
}
