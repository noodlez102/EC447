using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Line : BaseObject
    {
        private Point start;

        private Point end;

        private Pen pen;

        public Line(Point start, Point end, Pen pen)
        {
            this.start = start;
            this.end = end;
            this.pen = pen;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, start, end);
        }
    }
}
