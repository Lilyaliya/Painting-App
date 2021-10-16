using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FiguresLib
{
    public class Circle
    {
        private int x, y, r;
        private const int width = 740;
        private const int heigth = 572;
        public Circle()
        {
            Random rnd = new Random();
            this.r = rnd.Next(2, width / 2);
            Point p2 = new Point(rnd.Next(Math.Abs(width - 2 * r)),
                                    rnd.Next(Math.Abs(heigth - 2 * r)));
            this.x = p2.X;
            this.y = p2.Y;
            //generate randomly
        }
        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            gc.DrawEllipse(pen, this.x, this.y, r, r);
        }

        public void Show(Graphics gc, Color color)
        {
            Pen pen1 = new Pen(color, 3);
            gc.DrawEllipse(pen1, this.x, this.y, r, r);
        }

        public void MoveTo(Graphics gc, Point point)
        {
            this.x += point.X;
            this.y += point.Y;
        }
        ~Circle() { }
        public int[] get() { return new int[] { x, y, r }; }
        public void Set(int[] paramets)
        {
            this.x = paramets[0];
            this.y = paramets[1];
            this.r = paramets[2];
        }
    }
}