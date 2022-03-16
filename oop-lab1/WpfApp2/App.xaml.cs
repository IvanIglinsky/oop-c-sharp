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

namespace WPFApp1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double a,b,c,d,x1,x2;
            bool ok;
            ok = double.TryParse(textBoxA.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = double.TryParse(textBoxB.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = double.TryParse(textBoxC.Text, out c);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення c!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            d = Math.Pow(b, 2) - 4 * a * c;
            textBoxD.Text = d.ToString("F2");
            if (d < 0)
            {
                
                textBoxX1.Text = "Коренів не існує";
                textBoxX2.Text = "Коренів не існує";
            }
            else
            {
                if (a == 0)
                {

                    x1 = c / b;
                    Console.WriteLine("Корінь = {0:F3}", x1);
                    textBoxX1.Text = x1.ToString("F2");
                }
                else
                {
                    double s = Math.Pow(b, 2) - 4 * a * c;
                    Console.WriteLine("Дискримінант = {0:F3}", s);
                    if (s > 0)
                    {
                        x1 = ((-b) - (Math.Sqrt(s))) / 2 * a;
                        x2 = ((-b) + (Math.Sqrt(s))) / 2 * a;
                        Console.WriteLine("Перший корінь = {0:F3}", x1);
                        Console.WriteLine("Другий корінь = {0:F3}", x2);
                        textBoxX1.Text = x1.ToString("F2");
                        textBoxX2.Text = x2.ToString("F2");

                    }
                    if (s < 0)
                    {
                        textBoxX1.Text = ("Коренів не існує");

                    }
                    if (s == 0)
                    {

                        x1 = -(b / 2 * a);
                        Console.WriteLine("Корінь = {0:F3}", 1);
                        textBoxX1.Text = x1.ToString("F2");
                    }
                }
            }
        
    }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                       System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
    }
}
