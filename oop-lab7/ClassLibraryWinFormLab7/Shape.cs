using System.Drawing;

namespace ClassLibraryWinFormLab7
{
    public class Shape
    {
        protected double x { get; set; }
        protected double y { get; set; }
        protected string color { get; set; }

        public Shape(double x, double y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        Random random = new Random();
        public Shape()
        {
            x = random.Next(0, 700);
            y = random.Next(0, 300);
            color=$"{random.Next(0,255)}"+$"{random.Next(0,255)}"+$"{random.Next(0,255)}";
        }
        public Shape(Shape obj)
        {
            x = obj.x;
            y = obj.y;
            color = obj.color;
        }
    }
}