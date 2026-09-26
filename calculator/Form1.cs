using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double overall = 0.0;

        string action = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        double OperationHandler(double a, double b,string operation)
        {
            if (operation == "plus") return a + b;
            if (operation == "minus") return a - b;
            return a + b;
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

            TextBox1.Text = "overall = " + overall;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string text = TextBox.Text;

            if(text.Length == 1)
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
            }

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {   
            if(action == "")
            {

            overall -= double.Parse(TextBox.Text);
            }
            else
            {
                if(double.TryParse(TextBox.Text, out double number))
                {
                    overall = OperationHandler(overall, number, action);
                }
            }
            action = "minus";
            TextBox.Text = "0";
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
            if (TextBox.Text.IndexOf(".") == -1)
            {
            TextBox.Text += ".";
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            if (action == "")
            {
                action = "plus";
                overall += double.Parse(TextBox.Text);
            }
            else
            {
                if (double.TryParse(TextBox.Text, out double number))
                {
                    overall = OperationHandler(overall, number, action);
                }
               
            }

            TextBox.Text = "0";
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
