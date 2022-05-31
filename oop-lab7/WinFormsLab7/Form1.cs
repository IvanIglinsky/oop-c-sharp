using ClassLibraryWinFormLab7;
namespace WinFormsLab7
{
    public partial class Form1 : Form
    {
        Bitmap canvas;
        public Form1()
        {
            InitializeComponent();
            canvas = new Bitmap(pictureBox1.Width,
                            pictureBox1.Height);

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(DefaultBackColor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            int rnds;
            Random random = new Random();
            
            for (int i = 0; i < 20; i++)
            {
                rnds = random.Next(0, 5);
                if (rnds == 0)
                {
                    Dot dot = new Dot();
                    Color color = Color.FromArgb(dot.R, dot.G, dot.B);
                    dot.Draw(graphics, dot.x, dot.y, color);
                }
                if (rnds == 1)
                {
                    Line line = new Line();
                    line.Draw(graphics);
                }
                if (rnds == 2)
                {
                    Circle circle = new Circle();
                    circle.Draw(graphics);
                }
                if (rnds == 3)
                {
                    Rectang rect = new Rectang();
                    rect.Draw(graphics);
                }
                if (rnds == 4)
                {
                    Elips elips = new Elips();
                    elips.Draw(graphics);
                }
                rnds = 0;
            }
        }


        }
    }
