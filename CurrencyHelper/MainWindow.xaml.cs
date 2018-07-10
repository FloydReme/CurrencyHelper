using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using CurrencyHelper.ViewModel;

namespace CurrencyHelper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();

            //задаю background для кнопок по нажатию
            var bg = new SolidColorBrush(new Color{R = 27 , G = 116, B = 203, A = 255});

            
            
           

 
        }

        public event PropertyChangedEventHandler PropertyChanged;


        private void MainpageBtn_Click(object sender, RoutedEventArgs e)
        {

            var bg = new SolidColorBrush(new Color { R = 27, G = 116, B = 203, A = 255 });


        }

        

        private void Converter_Click(object sender, RoutedEventArgs e)
        {
            var bg = new SolidColorBrush(new Color { R = 27, G = 116, B = 203, A = 255 });

        }

        private void Favourites_Click(object sender, RoutedEventArgs e)
        {
            var bg = new SolidColorBrush(new Color { R = 27, G = 116, B = 203, A = 255 });


        }

        private void Notes_Click(object sender, RoutedEventArgs e)
        {
            var bg = new SolidColorBrush(new Color { R = 27, G = 116, B = 203, A = 255 });


        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            var bg = new SolidColorBrush(new Color { R = 27, G = 116, B = 203, A = 255 });


        }

        private void Feedback_Click(object sender, RoutedEventArgs e)
        {
            var bg = new SolidColorBrush(new Color { R = 27, G = 116, B = 203, A = 255 });



        }

        
    }
    
}
