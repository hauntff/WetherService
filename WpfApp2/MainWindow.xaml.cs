using WeatherService;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GetWeather _weatherservice { get; set; }
        public MainWindow()
        {

            InitializeComponent();
            _weatherservice = new GetWeather();
                
        }

        private void SaveWeather(object sender, RoutedEventArgs e)
        {

        }

        private void ShowWeather(object sender, RoutedEventArgs e)
        {
            var weather = _weatherservice.GetWeathers(citytxt.Text);
            weather.main.ConToC();
            this.DataContext = weather;
        }
    }
}