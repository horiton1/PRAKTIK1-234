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

namespace PRAK1_2345
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(NumberA.Text, out double a1))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(NumberB1.Text, out double b1))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(NumberC1.Text, out double c1))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(NumberA2.Text, out double a2))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(NumberB2.Text, out double b2))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(NumberC2.Text, out double c2))
            {
                MessageBox.Show("Введите число!");
            }
            double d, x, y;
            d = a1 * b2 - a2 * b1;
            x = (c1 * b2 - c2 * b1) / d;
            y = (a1 * c2 - a2 * c1) / d;

            Answer123.Text += $"X = {x} \n Y = {y}";
        }
    }
}
