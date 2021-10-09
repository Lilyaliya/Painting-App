using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiguresLib;

namespace Paint._2._0
{
    public partial class MainWindow : Form
    {
        private object      currObj = null;
        Graphics            graphics;
        private Square[]    squares;
        private FiguresLib.Rectangle[] rectangles;
        private Circle[]    circles;
        Pen pen = new Pen(Color.FromArgb(0, 255, 0), 3f);
        Bitmap bitmap = new Bitmap(500, 500);
        private bool isClicked = false;
        private bool inBounds = false;
        Object obj; // Настоящий выделенный объект перемещения
        string objType = null; // отдельная обработка перемещения для различных фигур
        bool movingMode = false;
        int dX;
        int dY;
        
        public MainWindow()
        {
            InitializeComponent();
            SetSize();
            this.MouseClick += new MouseEventHandler(mouseClick);
            graphics = canva.CreateGraphics();
            message.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private Square[] AddSquare(Square[] squares, Square obj)
        {
            if (squares == null)
            {
                squares = new Square[1];
                squares[0] = obj;
                return (squares);
            }
            else
            {
                Square[] squares2 = new Square[squares.Length + 1];
                for (int i = 0; i < squares.Length; i++)
                    squares2[i] = squares[i];
                squares2[squares.Length] = obj;
                return (squares2);
            }
        }

        private Circle[] AddCircle(Circle[] circles, Circle obj)
        {
            if (circles == null)
            {
                circles = new Circle[1];
                circles[0] = obj;
                return (circles);
            }
            else
            {
                Circle[] circles2 = new Circle[circles.Length + 1];
                for (int i = 0; i < circles.Length; i++)
                    circles2[i] = circles[i];
                circles2[circles.Length] = obj;
                return (circles2);
            }
        }
        private FiguresLib.Rectangle[] AddRect(FiguresLib.Rectangle[] rectangles, FiguresLib.Rectangle obj)
        {
            if (rectangles == null)
            {
                rectangles = new FiguresLib.Rectangle[1];
                rectangles[0] = obj;
                return (rectangles);
            }
            else
            {
                FiguresLib.Rectangle[] rectangles2 = new FiguresLib.Rectangle[rectangles.Length + 1];
                for (int i = 0; i < rectangles.Length; i++)
                    rectangles2[i] = rectangles[i];
                rectangles2[rectangles.Length] = obj;
                return (rectangles2);
            }
        }

        private Square[] RemoveSquare(Square[] squares, int index)
        {
            Square[] squares2 = new Square[squares.Length - 1];
            for (int i = 0; i < index; i++)
                squares2[i] = squares[i];
            for (int i = index; i < squares.Length - 1; i++)
            {
                squares2[i] = squares[i + 1];
            }
            return (squares2);
        }

        private FiguresLib.Rectangle[] RemoveRectangle(FiguresLib.Rectangle[] rectangles, int index)
        {
            FiguresLib.Rectangle[] rectangles2 = new FiguresLib.Rectangle[rectangles.Length - 1];
            for (int i = 0; i < index; i++)
                rectangles2[i] = rectangles[i];
            for (int i = index; i < rectangles.Length - 1; i++)
                rectangles2[i] = rectangles[i + 1];
            return (rectangles2);
        }

        private Circle[] RemoveCircle(Circle[] circles, int index)
        {
            Circle[] circles2 = new Circle[circles.Length - 1];
            for (int i = 0; i < index; i++)
                circles2[i] = circles[i];
            for (int i = index; i < circles.Length - 1; i++)
                circles2[i] = circles[i + 1];
            return (circles2);
        }

        private void SetSize()
        {
            System.Drawing.Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(bitmap);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void mouseClick(object sender, MouseEventArgs e)
        {
            string tag = sender.GetType().GetProperty("Tag").GetValue(sender).ToString();
            checkBefore();
            currObj = (tag == "button" || tag == "reserved") ? sender : null;
            if (currObj != null)
            {
                if (tag == "button")
                    currObj.GetType().GetProperty("BackColor").SetValue(currObj, Color.FromArgb(255, 192, 128));
                currObj.GetType().GetProperty("Tag").SetValue(currObj, (tag == "button") ? "reserved" : "button");
                showTag(currObj);
            }
        }

        private void checkBefore()
        {
            string tag;
            if (currObj != null)
            {
                tag = currObj.GetType().GetProperty("Tag").GetValue(currObj).ToString();
                if (tag == "reserved")
                    currObj.GetType().GetProperty("BackColor").SetValue(currObj, Color.Transparent);
                currObj.GetType().GetProperty("Tag").SetValue(currObj, (tag == "reserved") ? "button" : tag);
                showTag(currObj);
            }
        }

        private void showTag(object sender)
        {
            string tag = sender.GetType().GetProperty("Tag").GetValue(sender).ToString();
            switch (WhichReserved())
            {
                case "rectangle":
                    message.Text = "ПРЯМОУГОЛЬНИК";
                    break;
                case "square":
                    message.Text = "КВАДРАТ";
                    break;
                case "circle":
                    message.Text = "КРУГ";
                    break;
                case "none":
                    message.Text = "none";
                    break;
            }
            if (!message.Visible)
            {
                message.Visible = true;
                boxHeigth.Visible = false;
                boxWidth.Visible = false;
                textBox1.Visible = false;
            }
            if (message.Text != "none")
                timerMessage.Enabled = true;
        }

        private string LastElement(string fType)
        {
            string name = "none";
            switch (fType)
            {
                case "square":
                    name = "КВАДРАТ";
                    name += " №" + squares.Length;
                    break;
                case "circle":
                    name = "КРУГ";
                    name += " №" + circles.Length;
                    break;
                case "rectangle":
                    name = "ПРЯМОУГОЛЬНИК";
                    name += " №" + rectangles.Length;
                    break;
            }
            return (name);
        }

        private string WhichReserved()
        {
            if (squareControl.Tag.ToString() == "reserved")
                return ("square");
            else if (rectanControl.Tag.ToString() == "reserved")
                return ("rectangle");
            else if (circleControl.Tag.ToString() == "reserved")
                return ("circle");
            else
                return ("none");
        }

        private bool onlyDigit(string status)
        {
            switch (status)
            {
                case "square":
                    foreach (char c in boxWidth.Text)
                    {
                        if (!Char.IsDigit(c))
                            return (false);
                    }
                    break;
                case "circle":
                    foreach (char c in textBox1.Text)
                    {
                        if (!Char.IsDigit(c))
                            return (false);
                    }
                    break;
                case "rectangle":
                    foreach (char c in boxWidth.Text)
                    {
                        if (!Char.IsDigit(c))
                            return (false);
                    }
                    foreach (char c in boxHeigth.Text)
                    {
                        if (!Char.IsDigit(c))
                            return (false);
                    }
                    break;
            }
            return (true);
        }

        private void canva_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timerMessage_Tick(object sender, EventArgs e)
        {
            Color cl = message.ForeColor;
            if (cl.R < 20 || cl.G < 20 || cl.B < 20)
            {
                message.ForeColor = Color.FromArgb(255, 255, 255);
                message.Visible = false;
                ChooseFigure();
                timerMessage.Enabled = false;
            }
            else
            {
                message.ForeColor = Color.FromArgb(cl.R - 15, cl.G - 15, cl.B - 15);
            }
        }

        private void ChooseFigure()
        {
            switch (WhichReserved())
            {
                case "square":
                    boxWidth.Visible = true;
                    boxWidth.Enabled = true;
                    break;
                case "circle":
                    textBox1.Visible = true;
                    textBox1.Enabled = true;
                    break;
                case "rectangle":
                    boxWidth.Enabled = true;
                    boxWidth.Visible = true;
                    boxHeigth.Enabled = true;
                    boxHeigth.Visible = true;
                    break;
            }
        }

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var el in itemList.CheckedItems)
            {
                if (el.ToString().Contains("КВАДРАТ"))
                {
                    additional.Visible = true;
                    additional.Enabled = true;
                    CheckSelected();
                    return;
                }
                additional.Visible = false;
                additional.Enabled = false;
            }
            CheckSelected();
        }

        private void CheckSelected()
        {
            if (itemList.CheckedItems.Count > 1)
            {
                ChangeBtns(false, false);
            }
            else if (itemList.CheckedItems.Count == 1)
            {
                ChangeBtns(true, true);
            }
            else if (itemList.CheckedItems.Count < 1)
            {
                ChangeBtns(false, false);
            }
        }

        private void ChangeBtns(bool a, bool b)
        {
            trashBtn.Enabled = a;
            trashBtn.Visible = a;
            moveBtn.Enabled = b;
            moveBtn.Visible = b;
        }

        private void additional_Click(object sender, EventArgs e)
        {
            if (additional.Text.Contains("УВЕЛИЧИТЬ"))
            {
                IncreaseSquare();
                return;
            }
            additional.Text = "УВЕЛИЧИТЬ СТОРОНЫ КВАДРАТА(ОВ) В 2 РАЗА";
            additional.Size = new Size(additional.Size.Width, additional.Size.Height + 55);
        }

        private void IncreaseSquare()
        {
            foreach (var el in itemList.CheckedItems)
            {
                if (el.ToString().Contains("КВАДРАТ"))
                {
                    int index = SquareIndex(el.ToString());
                    squares[index - 1].Set(2 * squares[index - 1].getLength());
                }
            }
            reDraw();
        }

        private int SquareIndex(string name)
        {
            int index = name.IndexOf('№');
            string n1 = name.Substring(0, index + 1);
            string n2 = name.Remove(0, n1.Length);
            return (Convert.ToInt32(n2));
        }

        public void reDraw()
        {
            graphics.Clear(canva.BackColor);
            if (squares != null)
                foreach (var obj in squares)
                    obj.Show(graphics);
            if (rectangles != null)
                foreach (var obj in rectangles)
                    obj.Show(graphics);
            if (circles != null)
                foreach (var obj in circles)
                     obj.Show(graphics);
        }

        private void trashBtn_Click(object sender, EventArgs e)
        {
           int length = itemList.CheckedItems.Count;
           int[] deleted = new int[length];
           for (int i = 0; i < length; i++)
            {
                var el = itemList.CheckedItems[i];
                int index = SquareIndex(el.ToString()) - 1;
                if (el.ToString().Contains("КВАДРАТ"))
                {
                    squares = RemoveSquare(squares, index);
                }
                else if (el.ToString().Contains("КРУГ"))
                {
                    circles = RemoveCircle(circles, index);
                }
                else if (el.ToString().Contains("ПРЯМОУГОЛЬНИК"))
                {
                    rectangles = RemoveRectangle(rectangles, index);
                }
                deleted[i] = itemList.Items.IndexOf(el);
                renameFigures(el.ToString(), index);
            }
            for (int i = itemList.Items.Count - 1; i >= 0; i--)
                if (deleted.Contains<int>(i))
                    itemList.Items.Remove(itemList.Items[i]);
            reDraw();
        }

        private void renameFigures(string sort, int index)
        {
            for (int i = 0; i < itemList.Items.Count; i++)
            {
                
                if (itemList.Items[i].ToString().Contains(sort.Substring(0, sort.IndexOf('№') + 1)))
                {
                    int numb = Convert.ToInt32(itemList.Items[i].ToString().Substring(sort.IndexOf('№') + 1));
                    if (numb - 1 > index)
                    {
                        itemList.Items[itemList.Items.IndexOf(itemList.Items[i])] = sort.Substring(0, sort.IndexOf('№') + 1)
                            + (numb - 1).ToString();
                        
                    }
                    itemList.Refresh();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd;
            switch (WhichReserved())
            {
                case "square":
                    rnd = new Random();
                    int x = rnd.Next(2, canva.Width / 2);
                    Point p = new Point(rnd.Next(Math.Abs(canva.Width - x)), 
                                    rnd.Next(Math.Abs(canva.Height - x)));
                    Square square = new Square(x);
                    squares = AddSquare(squares, square);
                    squares[squares.Length - 1].Show(graphics, Color.Green, p);
                    itemList.Items.Add(LastElement("square"));
                    break;
                case "circle":
                    rnd = new Random();
                    int r = rnd.Next(2, canva.Width / 2);
                    Point p2 = new Point(rnd.Next(Math.Abs(canva.Width - 2 * r)),
                                    rnd.Next(Math.Abs(canva.Height - 2 * r)));
                    circles = AddCircle(circles, new Circle(p2.X, p2.Y, r));
                    circles[circles.Length - 1].Show(graphics);
                    itemList.Items.Add(LastElement("circle"));
                    break;
                case "rectangle":
                    rnd = new Random();
                    int a = rnd.Next(2, canva.Width / 2);
                    int b = rnd.Next(3, canva.Height / 2);
                    Point p3 = new Point(rnd.Next(Math.Abs(canva.Width - a)), 
                                    rnd.Next(Math.Abs(canva.Height - b)));
                    rectangles = AddRect(rectangles, new FiguresLib.Rectangle(a, b));
                    rectangles[rectangles.Length - 1].Show(graphics, Color.Green, p3);
                    itemList.Items.Add(LastElement("rectangle"));
                    break;
                case "none":
                    message.Text = "ВЫБЕРИТЕ ТИП ФИГУРЫ";
                    timerMessage.Enabled = true;
                    break;
            }
        }

        private void canva_MouseClick(object sender, MouseEventArgs e)
        {
            if (movingMode)
                return;
            switch (WhichReserved())
            {
                case "square":
                    Point p1 = new Point(e.X, e.Y);
                    if (onlyDigit("square"))
                    {
                        squares = AddSquare(squares, new Square(p1.X, p1.Y, 
                                        Convert.ToInt32(boxWidth.Text)));
                        squares[squares.Length - 1].Show(graphics);
                        itemList.Items.Add(LastElement("square"));
                    }
                    else
                    {
                        message.Text = "ВВЕДИТЕ КОРРЕКТНЫЕ ДАННЫЕ";
                        timerMessage.Enabled = true;
                    }
                    break;
                case "circle":
                    Point p2 = new Point(e.X, e.Y);
                    if (onlyDigit("circle"))
                    {
                        circles = AddCircle(circles, new Circle(p2.X, p2.Y, 
                                        Convert.ToInt32(textBox1.Text)));
                        circles[circles.Length - 1].Show(graphics);
                        itemList.Items.Add(LastElement("circle"));
                    }
                    else 
                    {
                        message.Text = "ВВЕДИТЕ КОРРЕКТНЫЕ ДАННЫЕ";
                        timerMessage.Enabled = true;
                    }
                    break;
                case "rectangle":
                    Point p3 = new Point(e.X, e.Y);
                    if (onlyDigit("rectangle"))
                    {
                        rectangles = AddRect(rectangles, new FiguresLib.Rectangle(p3.X, p3.Y, 
                            Convert.ToInt32(boxWidth.Text), Convert.ToInt32(boxHeigth.Text)));
                        rectangles[rectangles.Length - 1].Show(graphics);
                        itemList.Items.Add(LastElement("rectangle"));
                    }
                    else
                    {
                        message.Text = "ВВЕДИТЕ КОРРЕКТНЫЕ ДАННЫЕ";
                        timerMessage.Enabled = true;
                    }
                    break;
                case "none":
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
                textBox1.Text = "РАДИУС";
        }

        private void boxHeigth_TextChanged(object sender, EventArgs e)
        {
            if (boxHeigth.Text == null || boxHeigth.Text == "")
                boxHeigth.Text = "ВЫСОТА";
        }

        private void boxWidth_TextChanged(object sender, EventArgs e)
        {
            if (boxWidth.Text == null || boxWidth.Text == "")
                boxWidth.Text = "ДЛИНА";
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            if (moveBtn.Tag.ToString() != "pressed")
            {
                foreach (var el in itemList.CheckedItems)
                {
                    int index = SquareIndex(el.ToString());
                    if (el.ToString().Contains("КВАДРАТ"))
                    {
                        squares[index - 1].Show(graphics, Color.Red);
                        obj = squares[index - 1];
                        objType = "square";
                    }
                    else if (el.ToString().Contains("КРУГ"))
                    {
                        circles[index - 1].Show(graphics, Color.Red);
                        obj = circles[index - 1];
                        objType = "circle";
                    }
                    else if (el.ToString().Contains("ПРЯМОУГОЛЬНИК"))
                    {
                        rectangles[index - 1].Show(graphics, Color.Red);
                        obj = rectangles[index - 1];
                        objType = "rectangle";
                    }
                }
            }
            else if (moveBtn.Tag.ToString() == "pressed")
            {
                obj = null;
                objType = null;
                movingMode = false;
                moveBtn.Tag = "button";
                moveBtn.BackColor = Color.Transparent;
                return;
            }
            moveBtn.Tag = "pressed";
            movingMode = true;
            moveBtn.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void canva_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;

            if (obj == null)
                return;
            if (objType == "circle")
            {
                Circle circle = (Circle)obj;
                int x = circle.get()[0];
                int y = circle.get()[1];
                int r = circle.get()[2];
                if (e.X > x - r && e.Y > y - r && e.X < x + r && e.Y < y + r)
                { 
                    inBounds = true;
                    dX = e.X - x;
                    dY = e.Y - y;
                }
            }
            else if (objType == "square")
            {
                Square square = (Square)obj;
                int x0 = square.getCoords()[0];
                int y0 = square.getCoords()[1];
                int x = square.getLength();
                if ((e.X < x0 + x) && (e.X > x0) && (e.Y < y0 + x) && (e.Y > y0))
                {
                    inBounds = true; 
                    dX = e.X - x0;
                    dY = e.Y - y0;
                }
            }
            else
            {
                FiguresLib.Rectangle rectangle = (FiguresLib.Rectangle)obj;
                int x0 = rectangle.getCoords()[0];
                int y0 = rectangle.getCoords()[1];
                int x = rectangle.getSize()[0];
                int y = rectangle.getSize()[1];
                if ((e.X < x0 + x) && (e.X > x0) && (e.Y < y0 + y) && (e.Y > y0))
                {
                    inBounds = true;
                    dX = e.X - x0;
                    dY = e.Y - y0;
                }
            }
        }

        private void canva_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            inBounds = false;
        }

        private void canva_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked && inBounds)
            {
                switch (objType)
                {
                    case "square":
                        Square square = (Square)obj;
                        Square currentS = squares.First<Square>(x => x == square);
                        currentS.MoveTo(graphics, new Point(-currentS.getCoords()[0] + e.X - dX, 
                            -currentS.getCoords()[1] + e.Y - dY));
                        break;
                    case "circle":
                        Circle circle = (Circle)obj;
                        Circle currentC = circles.First<Circle>(x => x == circle);
                        currentC.MoveTo(graphics, new Point(-currentC.get()[0] + e.X - dX,
                            -currentC.get()[1] + e.Y - dY));
                        break;
                    case "rectangle":
                        FiguresLib.Rectangle rectangle = (FiguresLib.Rectangle)obj;
                        FiguresLib.Rectangle currentR = rectangles.First<FiguresLib.Rectangle>(x => x == rectangle);
                        currentR.MoveTo(graphics, new Point(-currentR.getCoords()[0] + e.X - dX,
                            -currentR.getCoords()[1] + e.Y - dY));
                        break;
                }
                reDraw();
            }
        }

    }
}
