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

namespace WPFApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, h,y,x;
            bool ok;
        
            ok = double.TryParse(TextBoxA.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = double.TryParse(TextBoxB.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = double.TryParse(TextBoxH.Text, out h);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення h!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            TextBoxR.Text = "X      Y" + Environment.NewLine;
            for (; a < b; a += h)
            {
                x = a;
                y = (x + Math.Cos(2 * x)) / 3 * x;
                TextBoxR.Text += $"{x:F2}   {y:F2}" + Environment.NewLine;
                TextBoxR.AcceptsReturn = true;
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
