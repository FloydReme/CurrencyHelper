using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Color = System.Windows.Media.Color;

namespace CurrencyHelper.Pages
{
    /// <summary>
    /// Логика взаимодействия для Feedback.xaml
    /// </summary>
    public partial class Feedback : Page
    {

        public Feedback()
        {
            InitializeComponent();
            var sb = new SolidColorBrush(new Color { R = 81, G = 114, B = 141, A = 130 }); //создаю свой цвет подсказки
           

            TextEmail.Text = "Examplemail@example.com";
            TextEmail.FontStyle = FontStyles.Italic;
            TextEmail.Foreground = sb;

            TextMessage.MaxLength = 370;
            TextMessage.Text = "Message Example";
            TextMessage.FontStyle = FontStyles.Italic;
            TextMessage.Foreground = sb;
        }

        






        private void textEmail_GotFocus(object sender, RoutedEventArgs e) //Выбран ли TextBox, следовательно, пишу пустую строку
        {
            
            var tintb = new SolidColorBrush(new Color{R = 81, G = 114, B = 141, A = 255});

            TextEmail.FontStyle = FontStyles.Normal;
            TextEmail.Text = "";
            TextEmail.Foreground = tintb;
        }

        private void textEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextEmail.Text == "")
            {
                var tintb = new SolidColorBrush(new Color { R = 81, G = 114, B = 141, A = 130 });

                TextEmail.Foreground = tintb;
                TextEmail.FontStyle = FontStyles.Italic;
                TextEmail.Text = "Examplemail@example.com";  
            }
        }



        private void TextMessage_GotFocus(object sender, RoutedEventArgs e)
        {
            var tintb = new SolidColorBrush(new Color { R = 81, G = 114, B = 141, A = 255 });

            TextMessage.FontStyle = FontStyles.Normal;
            TextMessage.Text = "";
            TextMessage.Foreground = tintb;

        }

        private void TextMessage_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextMessage.Text == "")
            {
                var tintb = new SolidColorBrush(new Color { R = 81, G = 114, B = 141, A = 130 });

                TextMessage.Foreground = tintb;
                TextMessage.FontStyle = FontStyles.Italic;
                TextMessage.Text = "Message example";

            }           
        }

      
    }
}
