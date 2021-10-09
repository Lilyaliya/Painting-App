using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint._2._0
{
    class Rectangle
    {
        private int x, y;
        private int x0, y0;
        private Pen pen;
        public Rectangle()
        {
            pen = new Pen(Color.Green, 3);
        }

        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
            if (pen == null)
                pen = new Pen(Color.Green, 3);
        }

        public Rectangle(int x0, int y0, int x, int y)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.x = x;
            this.y = y;
            if (pen == null)
                pen = new Pen(Color.Green, 3);
        }
        public void Show(Graphics gc, Color color, Point point)
        {
            pen = new Pen(color, 3);
            this.x0 = point.X;
            this.y0 = point.Y;
            gc.DrawRectangle(pen, point.X, point.Y, x, y);
        }

        public void Show(Graphics gc)
        {
            gc.DrawRectangle(pen, x0, y0, x, y);
        }

        public void Show(Graphics gc, Color color)
        {
            Pen pen1 = new Pen(color, 3);
            gc.DrawRectangle(pen1, x0, y0, x, y);
        }
        public void MoveTo(Graphics gc, Point point)
        {
            this.x0 += point.X;
            this.y0 += point.Y;
            //gc.DrawRectangle(pen, point.X, point.Y, x, y);
        }
        ~Rectangle() { }
        public int[] getSize() { return new int[] { x, y }; }

        public int[] getCoords() { return new int[] { x0, y0 }; }
        public void Set(int[] points)
        {
            this.x = points[0];
            this.y = points[1];
        }
    }
}
