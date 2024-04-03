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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private SettingDialog setWindow = new SettingDialog();
        private ArrayList shapes = new ArrayList();
        private Point startPoint;

        private Point endPoint;
        private Point firstPoint;

        private Point resetPoint = new Point(0,0);
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) //this is for the exit
        {
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) //this is clear
        {
            shapes.Clear();    
            panel2.Invalidate();
        }

        private void Settings_Click(object sender, EventArgs e) // to open up the settings dialog
        {
            setWindow.ShowDialog();
        }
        private bool isFirst()
        {
            bool isFirst = true;
            if(firstPoint == resetPoint)
            {
                isFirst = true;
                
            }
            else
            {
                isFirst = false;
            }
            return isFirst;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach (BaseObject ob in shapes)
            {
                ob.Draw(graphics);
            }
            if (!isFirst())
            {
                graphics.FillEllipse(Brushes.Black, startPoint.X - 5, startPoint.Y - 5, 10, 10);
            }
        }



        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (isFirst())
            {
                startPoint = e.Location;
                firstPoint = startPoint;
                panel2.Invalidate();
                return;
            }
            endPoint = e.Location;
            firstPoint = resetPoint;
            Brush Penc = null;
            Brush Fillc = null;
            Pen pen = null;
            int selectedIndex = setWindow.PenColor.SelectedIndex;
            int selectedIndex2 = setWindow.FillColor.SelectedIndex;

            if (selectedIndex == 1)
            {
                Penc= Brushes.Black;
            }
            else if (selectedIndex == 2)
            {
                Penc= Brushes.Red;
            }
            else if (selectedIndex == 3)
            {
                Penc= Brushes.Blue;
            }
            else if (selectedIndex == 4)
            {
                Penc= Brushes.Green;
            }
            if (selectedIndex2 != 0)
            {
                if (selectedIndex2 == 1)
                {
                    Fillc = Brushes.Black;
                }
                else if (selectedIndex2 == 2)
                {
                    Fillc = Brushes.Red;
                }
                else if (selectedIndex2 == 3)
                {
                    Fillc = Brushes.Blue;
                }
                else if (selectedIndex2 == 4)
                {
                    Fillc = Brushes.Green;
                }
            }

            if (Penc!= null)
            {
                pen = new Pen(Penc, int.Parse((string)setWindow.PenWidth.SelectedItem));
            }
            
            try
            {
                if (Fillc == null && pen == null)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Fill and or pen/outline color must be selected.");
                panel2.Invalidate();
                return;
            }

            if (pen != null && LineButton.Checked)
            {
                shapes.Add(new Line(startPoint, endPoint, pen));
            }
            if (Fillc != null || pen != null)
            {
                if (RectangleButton.Checked)
                {
                    shapes.Add(new Rectangle(startPoint, endPoint, pen, Fillc));
                }
                if (EclipseButton.Checked)
                {
                    shapes.Add(new Eclipse(startPoint, endPoint, pen, Fillc));
                }
            }
            panel2.Invalidate();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e) //the undo button
        {
            if (shapes.Count > 0)
            {
                shapes.RemoveAt(shapes.Count - 1);
            }
            panel2.Invalidate();
        }
    }
}
