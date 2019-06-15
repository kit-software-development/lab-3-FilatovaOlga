using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        string operation;
        float a = 0, b = 0;
        int cnt;
        
        private void OnDigitClick(object sender, EventArgs e)
        {
            if (cnt == 0)
            {
                Display.Text = "";
            }
            if (cnt < 7)
            {
                Display.Text += Convert.ToString((sender as Button).Text);
                cnt++;
            }
        }

        private void OnOperationClick(object sender, EventArgs e)
        {
            if (cnt != 0)
            {
                a = float.Parse(Display.Text);
            }
            operation = Convert.ToString((sender as Button).Text);
            Middle.Text = a.ToString() + Convert.ToString((sender as Button).Text);
            Display.Text = "";
            cnt = 0;
        }

        private void OnCEClick(object sender, EventArgs e)
        {
            Display.Text = "0";
            Middle.Text = "";
            cnt = 0;
            b = 0;
        }

        private void OnDotClick(object sender, EventArgs e)
        {
            if (!Display.Text.Contains(","))
            {
                cnt++;
                Display.Text += ",";
            }
        }

        private void OnEqualClick(object sender, EventArgs e)
        {
            Calculate();
        }

        private void OnKeyPress(object sender, KeyEventArgs e)
        {
            Button b = new Button();
            switch (e.KeyCode)
            {
                case (Keys.D0):
                case (Keys.NumPad0):
                    b.Text = "0";
                    OnDigitClick(b, e);
                    break;
                case (Keys.D1):
                case (Keys.NumPad1):
                    b.Text = "1";
                    OnDigitClick(b, e);
                    break;
                case (Keys.D2):
                case (Keys.NumPad2):
                    b.Text = "2";
                    OnDigitClick(b, e);
                    break;
                case (Keys.D3):
                case (Keys.NumPad3):
                    b.Text = "3";
                    OnDigitClick(b, e);
                    break;
                case (Keys.D4):
                case (Keys.NumPad4):
                    b.Text = "4";
                    OnDigitClick(b, e);
                    break;
                case (Keys.D5):
                case (Keys.NumPad5):
                    b.Text = "5";
                    OnDigitClick(b, e);
                    break;
                case (Keys.D6):
                case (Keys.NumPad6):
                    b.Text = "6";
                    OnDigitClick(b, e);
                    break;
                case (Keys.D7):
                case (Keys.NumPad7):
                    b.Text = "7";
                    OnDigitClick(b, e);
                    break;
                case (Keys.D8):
                case (Keys.NumPad8):
                    b.Text = "8";
                    OnDigitClick(b, e);
                    break;
                case (Keys.D9):
                case (Keys.NumPad9):
                    b.Text = "9";
                    OnDigitClick(b, e);
                    break;
                case (Keys.Delete):
                    b.Text = "del";
                    OnCEClick(b, e);
                    break;
                case (Keys.OemPeriod):
                case (Keys.Decimal):
                    b.Text = ",";
                    OnDotClick(b, e);
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    b.Text = "+";
                    OnOperationClick(b, e);
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    b.Text = "-";
                    OnOperationClick(b, e);
                    break;
                case Keys.Multiply:
                    b.Text = "*";
                    OnOperationClick(b, e);
                    break;
                case Keys.OemQuestion:
                case Keys.Divide:
                    b.Text = "/";
                    OnOperationClick(b, e);
                    break;
                case (Keys.Enter):
                    b.Text = "=";
                    OnEqualClick(b, e);
                    break;
            }
        }
        
        private void Calculate()
        {
            switch (operation)
            {
                case "+":
                    b = a + float.Parse(Display.Text);
                    break;
                case "-":
                    b = a - float.Parse(Display.Text);
                    break;
                case "*":
                    b = a * float.Parse(Display.Text);
                    break;
                case "/":
                    b = a / float.Parse(Display.Text);
                    break;
            }
            Middle.Text = "";
            Clipboard.SetText(b.ToString());
            Display.Text = b.ToString();
            operation = "";
            a = 0;
        }
    }
}
