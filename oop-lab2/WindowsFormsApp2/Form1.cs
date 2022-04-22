using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
                int par = 0, nepar = 0;
                int count = 10;
                for (int i = 0; i < count; i++)
                {
                    string a = TextBox1.Text;
                    int a_1 = Convert.ToInt32(a);
                    if (a_1 % 2 == 0) { par++; }
                    else { nepar++; }
                    count++;
                }
                TextBox2.Text = checkBox1.Checked ? TextBox2.Text = $"{nepar}" : TextBox2.Text = $"{par}";
            }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
