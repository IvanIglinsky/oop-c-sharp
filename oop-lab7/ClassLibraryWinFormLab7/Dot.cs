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
        protected double width { get; set; }
        protected double height { get; set; }
        public Dot(double width,double height, double x,double y, string color)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
            this.color = color;
        }
        Random random = new Random();
        public Dot()
        {
            width=random.Next(0,700);
            height = random.Next(0, 300);
            x = random.Next(0, 700);
            y = random.Next(0, 300);
            color = $"{random.Next(0, 255)}" + $"{random.Next(0, 255)}" + $"{random.Next(0, 255)}";
        }
        public Dot(Dot obj)
        {
            width = obj.width;
            height = obj.height;
            x = obj.x;
            y = obj.y;
            color = obj.color;
        }
      
        Graphics g;
        public void Draw()
        {
            
        }
    }
}
