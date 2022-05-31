using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicPlotter
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            One();
        }
       
        private void Form1_Resize(object sender, EventArgs e)
        {
            One();
        }
        

        void One()
        {
            Show();
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            Pen a = new Pen(Color.Blue, 1);
            Pen b = new Pen(Color.Yellow, 2);
            Font drawFont = new Font("Arial", 12);
            Font signatureFont = new Font("Arial", 7);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            
            int sizeWidth = Form1.ActiveForm.Width;
            int sizeHeight = Form1.ActiveForm.Height;
            Point center = new Point(((int)(sizeWidth / 2) - 8), (int)((sizeHeight / 2) - 19));

            graphics.DrawLine(a, 10, center.Y, center.X, center.Y);
            graphics.DrawLine(a, center.X, center.Y, 2 * center.X - 10, center.Y);

            graphics.DrawLine(a, center.X, 10, center.X, center.Y);
            graphics.DrawLine(a, center.X, center.Y, center.X, 2 * center.Y - 10);

            graphics.DrawString("X", drawFont, drawBrush, new PointF(2 * center.X - 5, center.Y + 10), drawFormat);
            graphics.DrawString("Y", drawFont, drawBrush, new PointF(center.X + 30, 5), drawFormat);
            graphics.DrawString("0", drawFont, drawBrush, new PointF(center.X, center.Y), drawFormat);
            graphics.DrawLine(a, center.X, 10, center.X + 5, 20);//y+
            graphics.DrawLine(a, center.X, 10, center.X - 5, 20);//y-

            graphics.DrawLine(a, sizeWidth - 25, center.Y, sizeWidth - 35, center.Y - 5);
            graphics.DrawLine(a, sizeWidth - 25, center.Y, sizeWidth - 35, center.Y + 5);

            int stepForAsex = 25;
            int lenghtShtih = 3;
            int maxValueForAxesX = 10;
            int maxValueForAxesY = 10;

            float oneDelenieX = (float)maxValueForAxesX / ((float)center.X / (float)stepForAsex);
            float oneDelenieY = (float)maxValueForAxesY / ((float)center.Y / (float)stepForAsex);

            for (int i = center.X, j = center.X, k = 1; i < 2 * center.X - 30; j -= stepForAsex, i += stepForAsex, k++)
            {
                graphics.DrawLine(a, i, center.Y - lenghtShtih, i, center.Y + lenghtShtih);
                graphics.DrawLine(a, j, center.Y - lenghtShtih, j, center.Y + lenghtShtih);
                if (i < 2 * center.X - 55)
                {
                    graphics.DrawString((k * oneDelenieX).ToString("0.0"), signatureFont, drawBrush, new PointF(i + stepForAsex + 9, center.Y + 6), drawFormat);
                    graphics.DrawString(((k * oneDelenieX).ToString("0.0").ToString() + "-"), signatureFont, drawBrush, new PointF(j - stepForAsex + 9, center.Y + 6), drawFormat);
                }
            }
            for (int i = center.Y, j = center.Y, k = 1; i < 2 * center.Y - 30; j -= stepForAsex, i += stepForAsex, k++)
            {
                graphics.DrawLine(a, center.X - lenghtShtih, i + 25, center.X + lenghtShtih, i + 25);
                graphics.DrawLine(a, center.X - lenghtShtih, j - 25, center.X + lenghtShtih, j - 25);
                if (i < 2 * center.X - 55)
                {
                    graphics.DrawString(((k * oneDelenieY).ToString("0.0").ToString() + "-"), signatureFont, drawBrush, new PointF(center.X - 9, i + stepForAsex - 6), drawFormat);
                    graphics.DrawString((k * oneDelenieY).ToString("0.0"), signatureFont, drawBrush, new PointF(center.X - 9, j - stepForAsex - 6), drawFormat);
                }
            }



            int numOfPoint = 100;


            float[] first = new float[numOfPoint];
            for (int i = 0; i < numOfPoint; i++)
            {
                first[i] = (float)maxValueForAxesX * 2 / (float)numOfPoint * (i + 1) - (float)(maxValueForAxesX * 2 / 2);
            }
            float[] second = new float[numOfPoint];
            for (int i = 0; i < numOfPoint; i++)
            {
                second[i] = (float)(first[i] * Math.Sin(5 * first[i]));
            }
            Point[] pointOne = new Point[numOfPoint];
            float tempX = 1 / oneDelenieX * stepForAsex;
            float tempY = 1 / oneDelenieY * stepForAsex;
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < numOfPoint; i++)
            {
                pointOne[i].X = center.X + (int)(first[i] * tempX);
                pointOne[i].Y = center.Y - (int)(second[i] * tempY);
                chart1.Series[0].Points.AddXY(pointOne[i].X, pointOne[i].Y);
            }
            graphics.DrawLines(b, pointOne);
            graphics.DrawCurve(b, pointOne);
         
        }

       
    }
}
