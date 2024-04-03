using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {

        private int cols = 20;
        private int rows = 20;
        private int cellsX = 50;
        private int cellsY = 25;
        private Grid current;
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
            current = new Grid(cellsX, cellsY);
            this.Text = "Game of Life By Arthur Hua";
            this.Size = new System.Drawing.Size(rows * cellsX+ 50, cols * cellsY+125);
            button4.Enabled= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get next generation
            Grid newg = new Grid(cellsX, cellsY);
            current.Generate(newg);
            //save as current
            current = newg;
            Invalidate();
        }

        private void Form1_MouseDown(object sender,MouseEventArgs e)
        {
            bool fillsquare = false;
            if (e.Button == MouseButtons.Left)
            {
                fillsquare = true;
            }else
            {
                fillsquare = false;
            }
            setCell(e.X,e.Y,fillsquare);
        }

        private void setCell(int x, int y, bool fill)
        {
            int xx = 0;
            int yy = 0;
            bool getCell = false;
            Graphics graphics = CreateGraphics();
            ApplyTransform(graphics);
            PointF[] p = { new Point(x, y) };
            graphics.TransformPoints(CoordinateSpace.World, CoordinateSpace.Device, p);
            xx = (int)p[0].X / rows;
            yy = (int)p[0].Y / cols;
            if (p[0].X < 0 || p[0].Y < 0)
            {
                getCell= false;
            }else if (xx >= cellsX || yy >= cellsY)
            {
                getCell = false;
            }
            else
            {
                getCell= true;

            }
            if (getCell)
            {
                if (fill)
                {
                    current[xx, yy] = true;
                }
                else
                {
                    current[xx, yy] = false;
                }
                GetCellPosition(xx, yy, out var wx, out var wy);
                Invalidate(new Rectangle(wx, wy, (int)Math.Ceiling(rows * 1f), (int)Math.Ceiling(cols * 1f)));
            }

        }

        private void GetCellPosition(int dx, int dy, out int wx, out int wy)
        {
            Graphics graphics = CreateGraphics();
            ApplyTransform(graphics);
            dx *= rows;
            dy *= cols;
            PointF[] p = { new Point(dx, dy) };

            graphics.TransformPoints(CoordinateSpace.Device, CoordinateSpace.World, p);
            wx = (int)p[0].X;
            wy = (int)p[0].Y;
        }


        private void ApplyTransform(Graphics g)
        {
            g.TranslateTransform(10, 60);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(Brushes.Black);
            Graphics graphics = e.Graphics;
            ApplyTransform(graphics);
            for (int i = 0; i <= cellsY; i++)
            {
                graphics.DrawLine(pen, 0, i * cols, cellsX * rows, i * cols);
            }
            for (int j = 0; j <= cellsX; j++)
            {
                graphics.DrawLine(pen, j * rows, 0, j * rows, cellsY * cols);
            }

            for (int k = 0; k < cellsX; k++)
            {
                for (int l = 0; l < cellsY; l++)
                {
                    if (current[k, l])
                    {
                        graphics.FillRectangle(Brushes.Black, k * rows, l * cols, rows, cols);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            current = new Grid(rows,cols);
            Invalidate();
        }
    }
    
}