using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWinFormLab7
{
    public class Rectang:Line
    {
        public Rectang(int x, int y, int R, int G, int B, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.R = R;
            this.G = G;
            this.B = B;
            this.width = width;
            this.height = height;
        }

        public Rectang()
        {

            width = random.Next(0, 400);
            height = random.Next(0, 200);
            x = random.Next(0, 400);
            y = random.Next(0, 250);
            R = random.Next(0, 255);
            G = random.Next(0, 255);
            B = random.Next(0, 255);
        }
        public Rectang(Line obj)
        {
            width = obj.width;
            height = obj.height;
            x = obj.x;
            y = obj.y;
            R = obj.R;
            G = obj.G;
            B = obj.B;
        }
        public void Draw(Graphics graphics)
        { 
            Color color = Color.FromArgb(R, G, B);
            Pen pen = new Pen(color);
            Dot dot = new Dot();
            graphics.DrawRectangle(pen, x, y, width, height);
            dot.Draw(graphics, x - 2, y - 2, color);
            dot.Draw(graphics,x+width-3,y+height-3, color);
        }
    }
}
