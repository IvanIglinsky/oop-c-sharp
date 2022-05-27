﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWinFormLab7
{
   public class Elips:Circle
    {
        public Elips(int x, int y, int R, int G, int B, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.R = R;
            this.G = G;
            this.B = B;
            this.width = width;
            this.height = height;
        }

        public Elips()
        {

            width = random.Next(25, 300);
            height = random.Next(25, 200);
            x = random.Next(0, 400);
            y = random.Next(0, 100);
            R = random.Next(0, 255);
            G = random.Next(0, 255);
            B = random.Next(0, 255);
        }
        public Elips(Elips obj)
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
            Dot dot = new Dot();
            Color color = Color.FromArgb(R, G, B);
            Pen pen = new Pen(color);
            Rectangle rect = new Rectangle();
            rect.Width = width;
            rect.Height = height;
            rect.X = x;
            rect.Y = y;
            int xDot = rect.X + width / 2;
            int yDot = rect.Y + height / 2;
            graphics.DrawEllipse(pen, rect);
            dot.Draw(graphics, xDot-3, yDot-3, color);
            graphics.DrawLine(pen, xDot, yDot, xDot + width / 2, yDot);
            graphics.DrawLine(pen, xDot, yDot,xDot,yDot-height/2 );
        }
        
    }
}
