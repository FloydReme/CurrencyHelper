using System.Windows.Controls;
using System.Windows.Input;

namespace CurrencyHelper.Pages
{
    /// <summary>
    /// Логика взаимодействия для Converter.xaml
    /// </summary>
    public partial class Converter : Page
    {
        public Converter()
        {
            InitializeComponent();

           
        }

        private void TXHaving_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void TXWanting_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
