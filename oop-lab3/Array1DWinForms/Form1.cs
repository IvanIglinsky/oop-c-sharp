namespace Array1DWinForms
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        int count;
        double dob = 1;
        private void button1_gen_Click(object sender, EventArgs e)
        {
            dob = 1;
            count = (int)numericUpDownCount.Value;
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = count;
            Random rnd = new Random();
            double[] arr=new double[count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-15000, 20000) / 100.0;
                if (arr[i] < 0)
                    dob *= Math.Abs(arr[i]);
                dataGridViewArray[i, 0].Value = arr[i];
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
            }

        }
        private void button2_roz_Click(object sender, EventArgs e)
        {   
            TextBoxRoz.Text =$"{dob:F2}";
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