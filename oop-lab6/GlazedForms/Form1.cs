namespace GlazedForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMaterial.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            
            double Height = Convert.ToDouble(textBoxHeight.Text);
            double Width = Convert.ToDouble(textBoxWidth.Text);
            double Square = Height * Width;
            double Cost = 0;
            if (RadioButtonSingle.Checked == true)
            {
                if (comboBoxMaterial.SelectedIndex == 0)
                {
                    Cost = Square * 0.25;
                }
                if (comboBoxMaterial.SelectedIndex == 1)
                {
                    Cost = Square * 0.05;
                }
                if (comboBoxMaterial.SelectedIndex == 2)
                {
                    Cost = Square * 0.15;
                }
            }
            if (RadioButtonDouble.Checked == true)
            {
                if (comboBoxMaterial.SelectedIndex == 0)
                {
                    Cost = Square * 0.30;
                }
                if (comboBoxMaterial.SelectedIndex == 1)
                {
                    Cost = Square * 0.10;
                }
                if (comboBoxMaterial.SelectedIndex == 2)
                {
                    Cost = Square * 0.20;
                }
            }
            if (Windowsill.Checked == true)
            label7.Text = $"{Cost+35} грн.";
            else
                label7.Text = $"{Cost} грн.";
        }  
    }
}