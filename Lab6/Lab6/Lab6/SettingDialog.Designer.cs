namespace Lab6
{
    partial class SettingDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PenColor = new System.Windows.Forms.ListBox();
            this.FillColor = new System.Windows.Forms.ListBox();
            this.PenWidth = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(408, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Outline/Pen Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fill Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pen Width";
            // 
            // PenColor
            // 
            this.PenColor.FormattingEnabled = true;
            this.PenColor.ItemHeight = 16;
            this.PenColor.Items.AddRange(new object[] {
            "No Outline",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.PenColor.Location = new System.Drawing.Point(40, 111);
            this.PenColor.Name = "PenColor";
            this.PenColor.Size = new System.Drawing.Size(120, 84);
            this.PenColor.TabIndex = 5;
            // 
            // FillColor
            // 
            this.FillColor.FormattingEnabled = true;
            this.FillColor.ItemHeight = 16;
            this.FillColor.Items.AddRange(new object[] {
            "No Fill",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.FillColor.Location = new System.Drawing.Point(182, 111);
            this.FillColor.Name = "FillColor";
            this.FillColor.Size = new System.Drawing.Size(120, 84);
            this.FillColor.TabIndex = 6;
            // 
            // PenWidth
            // 
            this.PenWidth.FormattingEnabled = true;
            this.PenWidth.ItemHeight = 16;
            this.PenWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PenWidth.Location = new System.Drawing.Point(333, 111);
            this.PenWidth.Name = "PenWidth";
            this.PenWidth.Size = new System.Drawing.Size(120, 164);
            this.PenWidth.TabIndex = 7;
            // 
            // SettingDialog
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PenWidth);
            this.Controls.Add(this.FillColor);
            this.Controls.Add(this.PenColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingDialog";
            this.Text = "SettingDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox PenColor;
        public System.Windows.Forms.ListBox FillColor;
        public System.Windows.Forms.ListBox PenWidth;
    }
}