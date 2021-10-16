using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresLib { 
    public class Square
    {
        private int         x; // длина стороны квадрата
        private Point       coords;
        private const int   width = 740;
        private const int   heigth = 572;
        public Square()
        {
            Random rnd = new Random();
            this.x = rnd.Next(2, width / 2);
            coords = new Point(rnd.Next(Math.Abs(width - x)),
                                    rnd.Next(Math.Abs(heigth - x)));
        }

        public Square(int x)
        {
            this.x = x;
        }

        public Square(Point coords, int x)
        {
            this.coords = coords;
            this.x = x;
        }

        public void Show(Graphics gc, Color color, Point point)
        {
            Pen pen = new Pen(color, 3);
            this.coords = point;
            gc.DrawRectangle(pen, coords.getX(), coords.getY(), x, x);
        }

        public void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            if (coords != null)
                gc.DrawRectangle(pen, coords.getX(), coords.getY(), x, x);
        }

        public void Show(Graphics gc, Color color)
        {
            Pen pen1 = new Pen(color, 3);
            if (coords != null)
                gc.DrawRectangle(pen1, coords.getX(), coords.getY(), x, x);
        }

        public void MoveTo(Point point)
        {
            int x = coords.getX() + point.getX();
            int y = coords.getY() + point.getY();
            coords.SetX(x);
            coords.SetY(y);
        }
        ~Square() { }
        public int getLength() { return x; }

        public Point getCoords() { return (coords); }
        public void Set(int x) { this.x = x; }
    }
}
