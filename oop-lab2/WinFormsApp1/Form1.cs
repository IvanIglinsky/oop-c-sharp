using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public object MessageBoxButton { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, h, y;
            bool ok;
            int n = 1;
            ok = double.TryParse(TextBoxA.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = double.TryParse(TextBoxB.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = double.TryParse(TextBoxH.Text, out h);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення h!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        

            for (double x = a; x < b; x += h)
            {
                TextBoxR.Text = null;
                
                TextBoxR.Text = "Selection starts at character #" + TextBoxR.SelectionStart + Environment.NewLine;
                y = (x + Math.Cos(2 * x)) / 3 * x;
                TextBoxR.Text = y.ToString("F2");
                y = 0;
                n++;
            }

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
