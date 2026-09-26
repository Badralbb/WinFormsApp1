using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = TextBox.Text;

            if (text.Length > 1 &&
                text.StartsWith("0") &&
                !text.StartsWith("0."))
            {
                TextBox.Text = text.Substring(1);
                TextBox.SelectionStart = TextBox.Text.Length;
            }


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            TextBox.Text += "7";
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            TextBox.Text += "1";
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            TextBox.Text += "2";
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            TextBox.Text += "3";
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            TextBox.Text += "4";
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            TextBox.Text += "5";
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            TextBox.Text += "6";
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            TextBox.Text += "8";
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            TextBox.Text += "9";
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            TextBox.Text += "0";
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.EndsWith("."))
            {

            TextBox.Text += ".";
            }

        }
    }
}
