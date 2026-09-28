using System;
using System.Threading;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double overall = 0.0;

        string action = "";

        bool isNewInput = true;

        double lastNumber = 0.0;
        string lastAction = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

            double OperationHandler(double a, double b,string operation)
        {
            switch (operation)
            {
                case "plus":
                    return a + b;

                case "minus":
                    return a - b;

                case "multiply":
                    return a * b;

                case "divide":
                    if (b == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return a;
                    }

                    return a / b;

                default:
                    return a;
            }
        }

        void AppendNumber(string appendingNumber)
        {
            if (isNewInput)
            {
                TextBox.Text = appendingNumber == "."
                    ? "0."
                    : appendingNumber;

                isNewInput = false;
            }
            else if (TextBox.Text == "0" &&
                     appendingNumber != ".")
            {
                TextBox.Text = appendingNumber;
            }
            else
            {
                TextBox.Text += appendingNumber;
            }
        }

        void SetOperation(string newAction, string symbol)
        {
            if (action == "")
            {
                if (double.TryParse(TextBox.Text, out double number))
                {
                    overall = number;
                }
            }
            else
            {
                if (double.TryParse(TextBox.Text, out double number))
                {
                    overall = OperationHandler(overall, number, action);
                }
            }

            action = newAction;

            TextBox.Text = "0";
            TextBox1.Text = overall + " " + symbol + " ";
        }

        string GetSymbol(string operation)
        {
            switch (operation)
            {
                case "plus": return "+";
                case "minus": return "-";
                case "multiply": return "×";
                case "divide": return "÷";
                default: return "";
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string text = TextBox.Text;

            if (text.Length <= 1)
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text = text.Substring(0, text.Length - 1);
            }

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            SetOperation("minus", "-");
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.IndexOf(".") == -1)
            {
            AppendNumber(".");
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
            TextBox1.Text = "";
            overall = 0;
            action = "";
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            SetOperation("plus", "+");
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            SetOperation("multiply", "x");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            SetOperation("divide", "÷");

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
            
                if (double.TryParse(TextBox.Text, out double number))
                {

                TextBox1.Text = $"sqr({TextBox.Text})";
                TextBox.Text = number * number + "";
                isNewInput = true;
            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
          
            TextBox1.Text = $"1 / {TextBox.Text}";
                if (double.TryParse(TextBox.Text, out double number))
                {
                if(number == 0)
                {
                    MessageBox.Show("Cannot divide by zero.");
                    return;
                }
                TextBox.Text = (1 / number) + "";
                }

           
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TextBox.Text, out double number))
            {
                if(number < 0)
                {
                    MessageBox.Show("Cannot calculate square root of a negative number.");
                    return;
                }

                TextBox1.Text = $"√({number})";
                TextBox.Text = Math.Sqrt(number) + "";

                isNewInput = true;
            }
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            if (action != "")
            {
                if (!double.TryParse(TextBox.Text, out double number))
                    return;

                lastNumber = number;
                lastAction = action;

                double firstNumber = overall;

                overall = OperationHandler(overall, number, action);

                TextBox1.Text =
                    $"{firstNumber} {GetSymbol(action)} {number} =";

                TextBox.Text = overall.ToString();

                action = "";
                isNewInput = true;

                return;
            }

            if (lastAction != "")
            {
                double currentNumber = double.Parse(TextBox.Text);

                overall = OperationHandler(
                    currentNumber,
                    lastNumber,
                    lastAction
                );

                TextBox1.Text =
                    $"{currentNumber} {GetSymbol(lastAction)} {lastNumber} =";

                TextBox.Text = overall.ToString();

                isNewInput = true;

                return;
            }

            TextBox.Text = TextBox.Text;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (overall == 0)
            {
                return;
            }

            if(double.TryParse(TextBox.Text, out double number))
            {
                double value = overall * number / 100;

                TextBox.Text = value.ToString();

            }

        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            if(double.TryParse(TextBox.Text, out double number)){
                if (number == 0) return;
                TextBox.Text = number * -1 + "";
            }
        }
    }
}
