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
using WeatherApp.Services;

namespace WeatherApp.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Temperature { get; set; }
        public MainWindow()
        {
            InitializeComponent();
             
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWeatherServices openWeatherServices = new OpenWeatherServices();
            WeatherInfo info = openWeatherServices.GetWeatherFor(searchTextBox.Text);
            temperatureLabel.Content = info.Main.temp + " °C";
            mainWindow.Icon = new BitmapImage(new Uri($"http://openweathermap.org/img/wn/{info.weather[0].icon}@2x.png"));


        }
    }
}
