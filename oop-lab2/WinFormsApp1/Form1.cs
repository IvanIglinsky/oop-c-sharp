namespace WinFormsApp1
{
     public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       


        private void button1_Click_1(object sender, EventArgs e)
        {
            double a, b, h, y,x;
            bool ok;
          
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
            TextBoxR.Text ="X      Y" + Environment.NewLine;
            for (; a < b; a += h)
            {
                x = a;
                y = (x + Math.Cos(2*x)) / 3 * x;
                TextBoxR.Text+= $"{x:F2}   {y:F2}" + Environment.NewLine;
                TextBoxR.AcceptsReturn=true;
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