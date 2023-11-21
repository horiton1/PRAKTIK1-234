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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out double A)) MessageBox.Show("Поле только для чисел");
            double A1 = Math.Pow(A, 2);
            double A2 = Math.Pow(A, 3);
            double A3 = Math.Pow(A, 5);
            double A4 = Math.Pow(A, 10);
            double A5 = Math.Pow(A, 15);

            TextBox2.Text += A1;
            TextBox3.Text += A2;
            TextBox4.Text += A3;
            TextBox5.Text += A4;
            TextBox6.Text += A5;
        }

        private void ColumnDefinition_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            
        }
    }
}
