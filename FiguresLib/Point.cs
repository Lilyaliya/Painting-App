using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Point
    {
        private int X;
        private int Y;
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public int getX() => this.X;
        public int getY() => this.Y;

        public void SetX(int x)
        {
            this.X = x;
        }

        public void SetY(int y)
        {
            this.Y = y;
        }
    }
}
