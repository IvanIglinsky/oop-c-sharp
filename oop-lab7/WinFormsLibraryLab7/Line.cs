using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWinFormLab7
{
    public class Line:Dot
    {
        public Line(int x,int y,int R,int G,int B,int width,int height)
        {
            this.x = x;
            this.y = y;
            this.R = R;
            this.G = G;
            this.B = B;
            this.width = width;
            this.height = height;
        }

        public Line()
        {
            
            width = random.Next(0,700);
            height =random.Next(0, 300);
            x = random.Next(0,700);
            y = random.Next(0, 300);
            R = random.Next(0, 255);
            G = random.Next(0, 255);
            B = random.Next(0, 255);
        }
        public Line(Line obj)
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

            Dot dot=new Dot();
            
            Color color = Color.FromArgb(R, G, B);
            dot.Draw(graphics, x-2, y-2, color);
            Pen pen = new Pen(color);
            graphics.DrawLine(pen, width, height, x, y);
            dot.Draw(graphics, width-2, height-2,color);
        }
       
    }
}
