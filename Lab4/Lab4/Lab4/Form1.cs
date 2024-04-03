using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Palidromes by Arthur Hua";
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24, FontStyle.Bold);
            this.label1.Text = "Find Numeric Palidromes";
            this.label2.Text = "Enter a starting integer (0-1,000,000,000): ";
            this.label3.Text = "Enter count (1-100): ";
            this.button1.Text = "Generate";
            this.label4.Text = string.Empty;
            this.listBox1.TabIndex = 10;

            this.Size = new System.Drawing.Size(790,450);
        }

        private bool IsPalindrome(int i)
        {
            string text = i.ToString();
            char[] check =new char[text.Length];
            for (int j = 0; j < text.Length; j++)
            {
                check[j] = text[text.Length - 1 - j];
            }
            if (text.SequenceEqual(check))
            {
                return true;
            }
            return false;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int numtoPalidromes = 0;
            int numOfPalidromes = 100;
            int PalidromeNum = 0;
            listBox1.Items.Clear();
            label4.Text = string.Empty;
            try
            {
                PalidromeNum = Convert.ToInt32(textBox1.Text);
                numOfPalidromes = Convert.ToInt32(textBox2.Text);
                if (numOfPalidromes < 1 || numOfPalidromes > 100 || PalidromeNum > 1000000000 || PalidromeNum < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                label4.Text = "Please enter a positive integer within range.";
                return;
            }
            while (numtoPalidromes < numOfPalidromes)
            {
                if (IsPalindrome(PalidromeNum))
                {
                    listBox1.Items.Add(PalidromeNum.ToString());
                    numtoPalidromes++;
                }
                PalidromeNum++;
            }
        }
    }
}
