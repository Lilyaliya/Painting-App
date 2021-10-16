using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresLib
{
    public class House
    {
        private Point coordsS;
        private Point highPoint;
        private int x, y; // размеры прямоугольника
        private const int width = 740;
        private const int heigth = 572;
        public House()
        {
            Random rnd = new Random();
            this.x = rnd.Next(10, width / 2);
            this.y = rnd.Next(10, heigth / 2);
            coordsS = new Point(rnd.Next(Math.Abs(width - x)),
                            rnd.Next(Math.Abs(heigth - y)));
            initHigh();
        }

        public House(Point coords, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.coordsS = coords;
            initHigh();
        }

        public void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            if (coordsS != null && highPoint != null)
            {
                gc.DrawRectangle(pen, coordsS.getX(), coordsS.getY(), x, y);
                gc.DrawLine(pen, coordsS.getX(), coordsS.getY(), highPoint.getX(), highPoint.getY());
                gc.DrawLine(pen, highPoint.getX(), highPoint.getY(), coordsS.getX() + x, coordsS.getY());
            }
        }

        public void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 3);
            if (coordsS != null && highPoint != null)
            {
                gc.DrawRectangle(pen, coordsS.getX(), coordsS.getY(), x, y);
                gc.DrawLine(pen, coordsS.getX(), coordsS.getY(), highPoint.getX(), highPoint.getY());
                gc.DrawLine(pen, highPoint.getX(), highPoint.getY(), coordsS.getX() + x, coordsS.getY());
            }
        }
        public void MoveTo(Point point)
        {
            int x = coordsS.getX() + point.getX();
            int y = coordsS.getY() + point.getY();
            coordsS.SetX(x);
            coordsS.SetY(y);
            initHigh();
        }

        private void initHigh()
        {
            int highest = (x > y) ? x : y;
            highest /= 2;
            highPoint = new Point(coordsS.getX() + x / 2, coordsS.getY() - highest);
        }

        ~House() { }
        public int[] getSize() { return new int[] { x, y }; }

        public Point getCoords() { return (coordsS); }

        public Point getHigh() { return (highPoint); }
        public void Set(int[] points)
        {
            this.x = points[0];
            this.y = points[1];
        }
    }
}
