using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class simpleCalculator : Form
    {
        public simpleCalculator()
        {
            InitializeComponent();
        }

        public decimal Result { get; set; }
        public decimal Value {  get; set; }
        private enum Operations
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        private Operations selectedOption { get; set; }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            display.Text += "5";

        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void buttonComa_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(","))
            {
                display.Text = display.Text + ",";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            selectedOption = Operations.Add;
            Value = Convert.ToDecimal(display.Text);
            operationSign.Text = "+";
            display.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            selectedOption = Operations.Subtract;
            Value = Convert.ToDecimal(display.Text);
            operationSign.Text = "-";
            display.Clear();
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            selectedOption = Operations.Multiply;
            Value = Convert.ToDecimal(display.Text);
            operationSign.Text = "X";
            display.Clear();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            selectedOption = Operations.Divide;
            Value = Convert.ToDecimal(display.Text);
            operationSign.Text = "/";
            display.Clear();
        }

        private void buttonEquals_Click(object sender, EventArgs e) 
        { 
            switch(selectedOption)
            {
                case Operations.Add:
                    Result = Value + Convert.ToDecimal(display.Text);
                    break;
                case Operations.Subtract:
                    Result = Value - Convert.ToDecimal(display.Text);
                    break;
                case Operations.Multiply:
                    Result = Value * Convert.ToDecimal(display.Text);
                    break;
                case Operations.Divide:
                    Result = Value / Convert.ToDecimal(display.Text);
                    break;
            }
            display.Text = Convert.ToString(Result);
            operationSign.Text = "";
        }

        private void financeModule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O módulo 'Financeiro' está em desenvolvimento.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '0':
                    display.Text += e.KeyChar.ToString();
                    break;

                case '1':
                    display.Text += e.KeyChar.ToString(); 
                    break;

                case '2':
                    display.Text += e.KeyChar.ToString();
                    break;

                case '3':
                    display.Text += e.KeyChar.ToString();
                    break;

                case '4':
                    display.Text += e.KeyChar.ToString();
                    break;

                case '5':
                    display.Text += e.KeyChar.ToString();
                    break;

                case '6':
                    display.Text += e.KeyChar.ToString();
                    break;

                case '7':
                    display.Text += e.KeyChar.ToString();
                    break;

                case '8':
                    display.Text += e.KeyChar.ToString();
                    break;

                case '9':
                    display.Text += e.KeyChar.ToString();
                    break;

                case '+':
                    selectedOption = Operations.Add;
                    Value = Convert.ToDecimal(display.Text);
                    operationSign.Text = "+";
                    display.Clear();
                    break;

                case '-':
                    selectedOption = Operations.Subtract;
                    Value = Convert.ToDecimal(display.Text);
                    operationSign.Text = "-";
                    display.Clear();
                    break;

                case '*':
                    selectedOption = Operations.Multiply;
                    Value = Convert.ToDecimal(display.Text);
                    operationSign.Text = "X";
                    display.Clear();
                    break;

                case '/':
                    selectedOption = Operations.Divide;
                    Value = Convert.ToDecimal(display.Text);
                    operationSign.Text = "/";
                    display.Clear();
                    break;

                case '\b':
                    display.Clear();
                    break;

                case '=':
                    switch (selectedOption)
                    {
                        case Operations.Add:
                            Result = Value + Convert.ToDecimal(display.Text);
                            break;
                        case Operations.Subtract:
                            Result = Value - Convert.ToDecimal(display.Text);
                            break;
                        case Operations.Multiply:
                            Result = Value * Convert.ToDecimal(display.Text);
                            break;
                        case Operations.Divide:
                            Result = Value / Convert.ToDecimal(display.Text);
                            break;
                    }
                    display.Text = Convert.ToString(Result);
                    operationSign.Text = "";
                break;

                case ',':
                    if (!display.Text.Contains(","))
                    {
                        display.Text = display.Text + ",";
                    }
                    break;
            }
        }
    }

}