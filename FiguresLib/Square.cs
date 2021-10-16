using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresLib { 
    public class Square
    {
        private int x;
        private int x0, y0;
        private const int width = 740;
        private const int heigth = 572;
        public Square()
        {
            Random rnd = new Random();
            this.x = rnd.Next(2, width / 2);
            Point p = new Point(rnd.Next(Math.Abs(width- x)),
                                    rnd.Next(Math.Abs(heigth - x)));
            this.x0 = p.X;
            this.y0 = p.Y;
        }

        public Square(int x)
        {
            this.x = x;
        }

        public Square(int x0, int y0, int x)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.x = x;
        }

        public void Show(Graphics gc, Color color, Point point)
        {
            Pen pen = new Pen(color, 3);
            this.x0 = point.X;
            this.y0 = point.Y;
            gc.DrawRectangle(pen, point.X, point.Y, x, x);
        }

        public void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            gc.DrawRectangle(pen, x0, y0, x, x);
        }

        public void Show(Graphics gc, Color color)
        {
            Pen pen1 = new Pen(color, 3);
            gc.DrawRectangle(pen1, x0, y0, x, x);
        }

        public void MoveTo(Graphics gc, Point point)
        {
            this.x0 += point.X;
            this.y0 += point.Y;
        }
        ~Square() { }
        public int getLength() { return x; }

        public int[] getCoords() { return new int[] { x0, y0 }; }
        public void Set(int x) { this.x = x; }
    }
}
