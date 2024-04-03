using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class SettingDialog : Form
    {
        private int fillc;

        private int pen;

        private int width;

        public SettingDialog()
        {
            InitializeComponent();
            base.StartPosition = FormStartPosition.CenterParent;
            FillColor.SelectedIndex = 0;
            PenColor.SelectedIndex = 0;
            base.ClientSize = new System.Drawing.Size(380, 280);
            PenWidth.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e) //cancel
        {
            FillColor.SelectedIndex = fillc;
            PenColor.SelectedIndex = pen;
            PenWidth.SelectedIndex = width;
            base.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)//OK
        {            
            fillc = FillColor.SelectedIndex;
            pen = PenColor.SelectedIndex;
            width = PenWidth.SelectedIndex;
            base.DialogResult = DialogResult.OK;

        }
        protected override void OnShown(EventArgs e)
        {
            fillc = FillColor.SelectedIndex;
            pen = PenColor.SelectedIndex;
            width = PenWidth.SelectedIndex;
        }
    }
}
