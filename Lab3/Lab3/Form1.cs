using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Sin Wave by Arthur Hua";
            this.Size = new System.Drawing.Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            float scale = Math.Min(ClientRectangle.Width / 400f, ClientRectangle.Height / 400f);
            if (scale != 0f)
            {
                graphics.TranslateTransform(ClientRectangle.Width / 2f, ClientRectangle.Height / 2f);
                graphics.ScaleTransform(scale, scale);
                graphics.DrawLine(Pens.Black, -200, 0, 200, 0);
                graphics.DrawLine(Pens.Black, 0, -200, 0, 200);
                for (int i = -179; i <= 180; i++)
                {
                    graphics.FillEllipse(Brushes.Black, i, 100f * (float)Math.Sin(Math.PI / 180 * i), 2f, 2f);
                }
            }
            else { 
                return;
            }
        }

    }
}
