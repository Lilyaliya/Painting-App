using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresLib
{
    public class Rectangle
    {
        private int         x, y; // ширина и высота прямоугольника
        private Point       coords;
        private const int   width = 740;
        private const int   heigth = 572;
        public Rectangle()
        {
            Random rnd = new Random();
            this.x = rnd.Next(2, width / 2);
            this.y = rnd.Next(3, heigth / 2);
            coords = new Point(rnd.Next(Math.Abs(width - x)),
                            rnd.Next(Math.Abs(heigth - y)));
            //generate randomly
        }

        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Rectangle(Point coords, int x, int y)
        {
            this.coords = coords;
            this.x = x;
            this.y = y;
        }
        public void Show(Graphics gc, Color color, Point point)
        {
            Pen pen = new Pen(color, 3);
            this.coords = point;
            gc.DrawRectangle(pen, coords.getX(), coords.getY(), x, y);
        }

        public void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            if (coords != null)
                gc.DrawRectangle(pen, coords.getX(), coords.getY(), x, y);
        }

        public void Show(Graphics gc, Color color)
        {
            Pen pen1 = new Pen(color, 3);
            if (coords != null)
                gc.DrawRectangle(pen1, coords.getX(), coords.getY(), x, y);
        }
        public void MoveTo(Point point)
        {
            int x = coords.getX() + point.getX();
            int y = coords.getY() + point.getY();
            coords.SetX(x);
            coords.SetY(y);
        }
        ~Rectangle() { }
        public int[] getSize() { return new int[] { x, y }; }

        public Point getCoords() { return (coords); }
        public void Set(int[] points)
        {
            this.x = points[0];
            this.y = points[1];
        }
    }
}
