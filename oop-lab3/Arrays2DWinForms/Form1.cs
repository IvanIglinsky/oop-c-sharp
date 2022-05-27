namespace Arrays2DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
        private void dataGridViewMatrix_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                e.PaintBackground(e.CellBounds, true);
                using (SolidBrush br = new SolidBrush(Color.Black))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(e.RowIndex.ToString(),
                   e.CellStyle.Font, br, e.CellBounds, sf);
                }
                e.Handled = true;
            }
        }
        int n, m;
        double summ = 0, max = -999999;

        private void numericUpDown_M_ValueChanged(object sender, EventArgs e)
        {
            button1_gen_Click(sender, e);
        }

        private void numericUpDown_N_ValueChanged(object sender, EventArgs e)
        {
            button1_gen_Click(sender, e);
        }

        private void button1_gen_Click(object sender, EventArgs e)
        {

            n = (int)numericUpDown_N.Value;
            m = (int)numericUpDown_M.Value;
            dataGridViewMatrix.RowHeadersWidth = 80;
            dataGridViewMatrix.RowCount = m;
            dataGridViewMatrix.ColumnCount = n;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridViewMatrix[i, j].Value = Convert.ToDouble(rnd.Next(-123, 163) / 10.0);
                    dataGridViewMatrix[i, j].Value = dataGridViewMatrix[i, j].Value;
                    dataGridViewMatrix.Rows[j].HeaderCell.Value = j.ToString();
                }
                dataGridViewMatrix.Columns[i].HeaderText = i.ToString();
                dataGridViewMatrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
         
        }

        private void button2_roz_Click(object sender, EventArgs e)
        {
            double sumamod = 0;
            double[,] arr = new double[n, m];
            double[] array = new double[m];
            dataGridViewSum.ColumnCount = n;
            dataGridViewSum.RowCount = 1;
            for (int i = 0; i < n; i++)
            {
                summ = 0;
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = double.Parse(dataGridViewMatrix[i, j].Value.ToString());
                    summ += arr[i, j];
                    array[j] = summ;
                    if (summ > max)
                        max = summ;
                }
                dataGridViewSum.Columns[i].HeaderText = $"{summ:F1}";
            }
            TextBoxSum.Text = $"{max:F1}";
            for (int j = 0; j < m; j++)
            {
                sumamod = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i, j] < 0)
                    {
                        sumamod += Math.Abs(arr[i, j]);
                    }
                    array[j] = sumamod;
                    for (int b = j + 1; b < m; b++)
                    {
                        if (array[j] > array[b])
                        {
                            double tmp = arr[i, j];
                            arr[i, j] = arr[i, b];
                            arr[i, b] = tmp;
                        }
                    }
                }
            }
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {                 
                    dataGridViewMatrix[i, j].Value = arr[i, j];
                    dataGridViewMatrix.Columns[i].HeaderText = i.ToString();
                }
                dataGridViewMatrix.Rows[j].HeaderCell.Value = j.ToString();
            }
            max = -99999;    
        }
    }
}

