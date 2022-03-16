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
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            bool ok;
            ok = double.TryParse(textBoxX.Text, out x);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = double.TryParse(textBoxY.Text, out y);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = double.TryParse(textBoxZ.Text, out z);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double s = Math.Pow((Math.Cos(x) - Math.Sin(y)), (1 + 2 * Math.Sin(z))) * (z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3) + Math.Pow(z, 4) / 4; 
            textBoxR.Text = s.ToString("F2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
