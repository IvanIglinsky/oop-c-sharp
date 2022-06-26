using System.Text;
using System.Text.RegularExpressions;
namespace WinFormsAppTask2Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("(^\\+380\\d{3}\\d{2}\\d{2}\\d{2}$)");
            Match match = reg.Match(textBox1.Text);
            if (match.Success)
            {
                label8.Text = "ОК";
                label8.Visible=true;
                label8.ForeColor = Color.Green;
            }
            else
            {
                label8.Text = "Помилка";
                label8.Visible = true;
                label8.ForeColor = Color.Red;
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("\\d{13}");
            Match match = reg.Match(textBox2.Text);
            if (match.Success)
            {
                label9.Text = "ОК";
                label9.Visible = true;
                label9.ForeColor = Color.Green;
            }
            else
            {
                label9.Text = "Помилка";
                label9.Visible = true;
                label9.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
         Regex reg = new Regex("((1031[1-9]{1})|(103[2-9]\\d{1})|(10[4-9]\\d{2})|(1[1-9]\\d{3})|([2-7][0-9]{4})|(8[0-8]{4})|(89[0-5]{3})|(896[0-3]{2})|(8964[0-5]))");
            Match match = reg.Match(textBox3.Text);
            if (match.Success)
            {
                label10.Text = "ОК";
                label10.Visible = true;
                label10.ForeColor = Color.Green;
            }
            else
            {
                label10.Text = "Помилка";
                label10.Visible = true;
                label10.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("(([А-Я]|І|Є){1}(є*[а-я]*є*|[а-я]|і*[а-я]*і*[а-я]*і*)+)");
            Match match = reg.Match(textBox4.Text);
            if (match.Success)
            {
                label11.Text = "ОК";
                label11.Visible = true;
                label11.ForeColor = Color.Green;
            }
            else
            {
                label11.Text = "Помилка";
                label11.Visible = true;
                label11.ForeColor = Color.Red;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("(^[0-2]{1}[0-9]{1}[:][0-5]{1}[0-9]{1}$)");
            Match match = reg.Match(textBox5.Text);
            if (match.Success)
            {
                label12.Text = "ОК";
                label12.Visible = true;
                label12.ForeColor = Color.Green;
            }
            else
            {
                label12.Text = "Помилка";
                label12.Visible = true;
                label12.ForeColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("(([A-Z]|[a-z])([^A-Z,a-z,0-9]{0,1}[A-Z,a-z,0-9])+(\\@gmail?|@ukr)(\\.com)?|(\\.net))");
            Match match = reg.Match(textBox6.Text);
            if (match.Success)
            {
                label13.Text = "ОК";
                label13.Visible = true;
                label13.ForeColor = Color.Green;
            }
            else
            {
                label13.Text = "Помилка";
                label13.Visible = true;
                label13.ForeColor = Color.Red;
            }
        }
    }
}