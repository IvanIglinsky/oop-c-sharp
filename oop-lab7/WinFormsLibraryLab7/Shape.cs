using System.Drawing;

namespace ClassLibraryWinFormLab7
{
    public class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Shape(int x, int y,int R,int G,int B)
        {
            this.x = x;
            this.y = y;
            this.R = R;
            this.G = G;
            this.B = B;
        }
      public Random random = new Random();
        public Shape()
        {
            x = random.Next(0, 700);
            y = random.Next(0, 300);
            R = random.Next(0, 255);
            G = random.Next(0, 255);
            B = random.Next(0, 255);
        }
        public Shape(Shape obj)
        {
            x = obj.x;
            y = obj.y;
            R = obj.R;
            G = obj.G;
            B = obj.B;
        }
    }
}