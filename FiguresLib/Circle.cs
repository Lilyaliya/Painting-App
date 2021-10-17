using System;
using System.Drawing;
namespace FiguresLib
{
    public class Circle
    {
        private int         r;
        private Point       coords;
        private const int   width = 740;
        private const int   heigth = 572;
        public Circle()
        {
            Random rnd = new Random();
            this.r = rnd.Next(2, width / 2);
            coords = new Point(rnd.Next(Math.Abs(width - 2 * r)),
                                    rnd.Next(Math.Abs(heigth - 2 * r)));
            //generate randomly
        }
        public Circle(Point coords, int r)
        {
            this.coords = coords;
            this.r = r;
        }
        public void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            if (coords != null)
                gc.DrawEllipse(pen, coords.getX(), coords.getY(), r, r);
        }

        public void Show(Graphics gc, Color color)
        {
            Pen pen1 = new Pen(color, 3);
            if (coords != null)
                gc.DrawEllipse(pen1, coords.getX(), coords.getY(), r, r);
        }

        public void MoveTo(Point point)
        {
            int x = coords.getX() + point.getX();
            int y = coords.getY() + point.getY();
            coords.SetX(x);
            coords.SetY(y);
        }
        ~Circle() { }
        public Point getCoords() { return (coords); }

        public int getRadius() => r;
        public void Set(int[] paramets)
        {
            coords = new Point(paramets[0], paramets[1]);
            this.r = paramets[2];
        }
    }
}