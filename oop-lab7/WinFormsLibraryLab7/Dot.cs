using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibraryWinFormLab7
{
    public class Dot:Shape
    {
        public int width;
        public int height;
        public Dot(int width,int height, int x,int y,int R,int G,int B)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
            this.R = R;
            this.G = G;
            this.B = B;

        }
        Random random = new Random();
        
        public Dot()
        {
            width= 7;
            height = 7;
            x = random.Next(0, 700);
            y = random.Next(0, 300);
            R = random.Next(0, 255);
            G = random.Next(0, 255);
            B = random.Next(0, 255);
            
        }
        public Dot(Dot obj)
        {
            width = obj.width;
            height = obj.height;
            x = obj.x;
            y = obj.y;
            R=obj.R;
            G=obj.G;
            B=obj.B;
        }
      
        public void Draw(Graphics graphics,int x,int y,Color color)
        {
            Brush brush = new SolidBrush(color);
            graphics.FillEllipse(brush,x,y,width,height);

        }
    }
}
