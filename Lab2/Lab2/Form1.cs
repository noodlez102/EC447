using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {

        private ArrayList circleCenters = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            circleCenters = new ArrayList(); // Initialize the circle center
            this.MouseClick += Form1_MouseClick;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Set the center of the circle at the click location
                Point p = new Point(e.X, e.Y);
                this.circleCenters.Add(p);
                this.Invalidate(); // Redraw the panel
            }

            if (e.Button == MouseButtons.Right)
            {
                // Set the center of the circle at the click location
                circleCenters.Clear();
                this.Invalidate(); // Redraw the panel
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            const int WIDTH = 10;
            const int HEIGHT =10;
            foreach (Point center in circleCenters)
            {
                g.FillEllipse(Brushes.Black,
                center.X - WIDTH / 2, center.Y - WIDTH / 2, WIDTH, HEIGHT);
            }

            if (checkBox1.Checked)
            {
                if (circleCenters.Count >= 2)
                {
                    for (int i = 1; i < circleCenters.Count; i++)
                    {
                        g.DrawLine(Pens.Black, (Point)circleCenters[i - 1], (Point)circleCenters[i]);
                    }
                    g.DrawLine(Pens.Black, (Point)circleCenters[0], (Point)circleCenters[circleCenters.Count - 1]);
                }
            }else if (checkBox2.Checked)
            {
                for (int i = 0; i < circleCenters.Count-1; i++)
                {
                    for (int j = 1; j < circleCenters.Count; j++)
                    {
                        g.DrawLine(Pens.Black, (Point)circleCenters[i], (Point)circleCenters[j]);
                    }
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                MessageBox.Show("Error: Do not check more than 2 check boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Invalidate();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                MessageBox.Show("Error: Do not check more than 2 check boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Invalidate();
        }
    }
}
