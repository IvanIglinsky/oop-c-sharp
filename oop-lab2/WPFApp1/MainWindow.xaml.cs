using System;
using System.Collections.Generic;
using System.Windows;

namespace WPFApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox1_Checke1dChanged(object sender, RoutedEventArgs e)
        {
            int par = 0, count = 0;
            var a = new List<int>();
            foreach (var s in TextBox1.Text.Split(',', '.'))
            {
                a.Add(Convert.ToInt32(s));
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                if (a[i] % 2 == 0)
                    par++;
                TextBox2.Text = $"{par}";
            }
        }
        private void CheckBox1_UnChecke1dChanged(object sender, RoutedEventArgs e)
        {
            int nepar = 0, count = 0;
            var a = new List<int>();
            foreach (var s in TextBox1.Text.Split(',', '.'))
            {
                a.Add(Convert.ToInt32(s));
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                if (a[i] % 2 != 0)
                    nepar++;
            }
            TextBox2.Text = $"{nepar}";
        }
    }
}
