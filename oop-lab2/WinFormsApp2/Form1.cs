using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_Checke1dChanged(object sender, EventArgs e)
        {
            int par = 0, nepar = 0, count = 0;
            var a = new List<int>();
            foreach (var s in TextBox1.Text.Split(',','.'))
            {
                a.Add(Convert.ToInt32(s));
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                if (a[i] % 2 == 0)
                    par++;
                if (a[i] % 2 != 0)
                    nepar++;
            }
            TextBox2.Text = checkBox1.Checked ? TextBox2.Text = $"{par}" : TextBox2.Text = $"{nepar}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                                   System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

      
    }
}
