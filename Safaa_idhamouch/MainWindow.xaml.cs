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

namespace Safaa_idhamouch
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberaffiche1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number1.Text = numberaffiche1.Value.ToString("000");
            numberTextBox1.Text = numberaffiche1.Value.ToString("000");

        }

        private void numberTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            number2.Text = numberTextBox2.Text;

        }

        private void numberaffiche2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number2.Text = numberaffiche2.Value.ToString("000");
        }

        private void numberaffiche3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number3.Text = numberaffiche3.Value.ToString("000");

        }

        private void numberTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            number3.Text = numberTextBox3.Text;

        }

        private void numberText_previewInt(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);

        }

        private void numberText_PreviewInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);

        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            value1.Text = number2.Text; value2.Text = number3.Text; value3.Text = number1.Text;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] listnumber = new string[3];
            for (int i = 0; i < 3; i++)
            {
                listnumber[i] = "Value 1 " + value1.Text;
                listnumber[i + 1] = "Value 2 " + value2.Text;
                listnumber[i + 2] = "Value 3 " + value3.Text;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
