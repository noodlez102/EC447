using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Rectangle : BaseObject
    {
        private Point start;

        private Point end;

        private Pen pen;

        private Brush brush;

        public Rectangle(Point start, Point end, Pen pen, Brush brush)
        {
            this.start = start;
            this.end = end;
            this.pen = pen;
            this.brush = brush;
        }

        public override void Draw(Graphics g)
        {
            int width = Math.Abs(end.X - start.X);
            int height = Math.Abs(end.Y - start.Y);
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);
            if (brush != null)
            {
                g.FillRectangle(brush, x, y, width, height);
            }
            if (pen != null)
            {
                g.DrawRectangle(pen, x, y, width, height);
            }
        }
    }
}
