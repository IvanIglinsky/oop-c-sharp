namespace TravelForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCountry.SelectedIndex = 0;
        }
        private void Summ_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            int day =Convert.ToInt32( textBoxDay.Text);
            double Sum = 0;
            if (radioButtonLito.Checked == true)
            {
                if (comboBoxCountry.SelectedIndex == 0)
                    Sum = day * 100;
                if (comboBoxCountry.SelectedIndex == 1)
                    Sum = day * 160;
                if (comboBoxCountry.SelectedIndex == 2)
                    Sum = day * 120;
            }
            if(radioButtonZima.Checked == true)
            {
                if (comboBoxCountry.SelectedIndex == 0)
                    Sum = day * 150;
                if (comboBoxCountry.SelectedIndex == 1)
                    Sum = day * 200;
                if (comboBoxCountry.SelectedIndex == 2)
                    Sum = day * 180;
            }
            if (checkBoxGid.Checked == true)
                label3.Text = $"{Sum + 50 * day} $";
            else
                label3.Text = $"{Sum } $";
        }
    }
}