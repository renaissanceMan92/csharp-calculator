using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1calculator
{
    public partial class Form1 : Form
        // Denna klass implementerar en mycket enkel miniräknare.
        // Användaren kan genom knappar skicka input till programmet som skapar
        // operander och operatorer av detta och utför en operation.
        // Decimaltal går att använda. De går ej att dividera med noll.
        // Den här miniräknaren kan endast räkna på en operator i taget, t.ex 2 x 2 = 4.
    {
        string operation = string.Empty;
        double firstNumber = double.NaN;
        double secondNumber = double.NaN;
        string myoperand;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            CreateNr("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            CreateNr("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            CreateNr("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            CreateNr("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            CreateNr("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            CreateNr("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            CreateNr("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            CreateNr("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            CreateNr("9");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            CreateNr("0");
        }

        private void Btndecimal_Click(object sender, EventArgs e)
        {
            CreateNr(",");
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
            firstNumber = double.NaN;
            secondNumber = double.NaN;
            result = double.NaN;
            myoperand = string.Empty;
            operation = string.Empty;
        }

        private void Btnplus_Click(object sender, EventArgs e)
        {
            CreateOperation("+");
        }

        private void Btnminus_Click(object sender, EventArgs e)
        {
            CreateOperation("-");
        }

        private void Btnmultiply_Click(object sender, EventArgs e)
        {
            CreateOperation("*");
        }

        private void Btndivide_Click(object sender, EventArgs e)
        {
            CreateOperation("/");
        }

        private void Btnequals_Click(object sender, EventArgs e)
            // Skapar den andra operanden samt skapar och utför hela operationen
            // med utgångspunkt från värdet på operanderna och operatorn.
        {
            try
            {
                secondNumber = Convert.ToDouble(myoperand, CultureInfo.InvariantCulture);
                myoperand = string.Empty;
                if (operation == "/" && firstNumber == 0 || operation == "/" && secondNumber == 0 || double.IsNaN(firstNumber) || double.IsNaN(secondNumber) || string.IsNullOrEmpty(operation))
                {
                    ClearAll();
                }
                else
                {
                    if (operation == "+") result = firstNumber + secondNumber;
                    else if (operation == "-") result = firstNumber - secondNumber;
                    else if (operation == "*") result = firstNumber * secondNumber;
                    else result = firstNumber / secondNumber;
                    textBox.Text += "=" + Convert.ToString(result, CultureInfo.InvariantCulture);
                    operation = string.Empty;
                }
            }
            catch (FormatException)
            {
                ClearAll();
            }
        }
        private void CreateOperation(string str)
            // Skapar första operanden samt den enda operatorn.
        {
            try
            {
                if (string.IsNullOrEmpty(operation))
                {
                    firstNumber = Convert.ToDouble(myoperand, CultureInfo.InvariantCulture);
                    myoperand = string.Empty;
                    textBox.Text += str;
                    operation = str;
                }
                else ClearAll();
            }
            catch (FormatException)
            {
                ClearAll();
            }
        }
        private void CreateNr(string str)
            // Skapar ett nummer av användarens input.
        {
            if (string.IsNullOrEmpty(myoperand) && string.IsNullOrEmpty(operation))
            {
                textBox.Text = string.Empty;
            }
            textBox.Text += str;
            myoperand += str;
        }
        private void ClearAll()
            // Om något går fel anropas denna metod som rensar alla värden ur
            // alla variabler så att man kan börja om säkert.
        {
            MessageBox.Show("INVALID! All input will be wiped.");
            textBox.Text = string.Empty;
            firstNumber = double.NaN;
            secondNumber = double.NaN;
            result = double.NaN;
            myoperand = string.Empty;
            operation = string.Empty;
        }
    }
}
