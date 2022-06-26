using ClassLibraryWinFormLab7;
namespace WinFormsLab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Weather weather = new Weather();
            textBoxTemperature.Text =weather.Temperatures()+ " °C";
            textBoxWind.Text=weather.Winds()+" ì/c";
            textBoxWhatWind.Text = weather.WhatWinds();
            textBoxHumidity.Text = weather.Humiditys();
            textBoxWatherTemperature.Text = weather.WatherTemperatures();
            textBoxWeather.Text = weather.AllWathers();
            pictureBox1.ImageLocation = weather.Imgs();
        }
    }
}