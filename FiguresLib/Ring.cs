using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresLib
{
    public class Ring
    {
        private Point       centre;
        private Circle      around;     // внешний круг
        private Circle      inside;     // внутренний круг
        private int         R1;         // внутренний радиус
        private int         R2;         // внешний радиус
        private const int   width = 740;
        private const int   heigth = 572;
        public Ring()
        {
            Random rnd = new Random();
            this.R1 = rnd.Next(15, width / 2);
            centre = new Point(rnd.Next(Math.Abs(width - R1)),
                                    rnd.Next(Math.Abs(width - R1)));
            R2 = R1 + 12;
            initCircles();
        }

        public Ring(Point centre, int r)
        {
            this.centre = centre;
            this.R1 = r;
            this.R2 = R1 + 12;
            initCircles();
        }

        public void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            inside.Show(gc);
            around.Show(gc);
        }

        public void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 3);
            inside.Show(gc, color);
            around.Show(gc, color);
        }

        public void MoveTo(Point point)
        {
            int x = centre.getX() + point.getX();
            int y = centre.getY() + point.getY();
            centre.SetX(x);
            centre.SetY(y);
            initCircles();
        }

        private void initCircles()
        {
            inside = new Circle(new Point(centre.getX() + 6, centre.getY() + 6), R1);
            around = new Circle(centre, R2);
        }

        ~Ring() { }
        public Point getCoords() { return (centre); }

        public int getRadius1() => R1;

        public int getRadius2() => R2;
        public void Set(int[] paramets)
        {
            centre = new Point(paramets[0], paramets[1]);
            this.R1 = paramets[2];
            this.R2 = R1 + 12;
        }
    }
}
