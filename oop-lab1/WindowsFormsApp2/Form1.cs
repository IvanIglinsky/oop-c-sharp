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
            double a, b, c, x1, x2, d;
            bool ok;
            ok = double.TryParse(textBoxA.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = double.TryParse(textBoxB.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = double.TryParse(textBoxC.Text, out c);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення c!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            d = Math.Pow(b, 2) - 4 * a * c;
            textBox1.Text = d.ToString("F2");
            if (d < 0)
            {
                label6.Visible = false;
                textBox1.Visible = false;
                textBox2.Text = "Коренів не існує";
                textBox3.Text = "Коренів не існує";
            }
            else
            {
                if (a == 0)
                {

                    x1 = c / b;
                    Console.WriteLine("Корінь = {0:F3}", x1);
                    textBox2.Text = x1.ToString("F2");
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
                        textBox2.Text = x1.ToString("F2");
                        textBox3.Text = x2.ToString("F2");

                    }
                    if (s < 0)
                    {
                        textBox2.Text = ("Коренів не існує");

                    }
                    if (s == 0)
                    {

                        x1 = -(b / 2 * a);
                        Console.WriteLine("Корінь = {0:F3}", 1);
                        textBox2.Text = x1.ToString("F2");
                    }
                }
            }
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
