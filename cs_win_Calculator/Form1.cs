using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_win_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double val = 0;
        string operation = "";
        bool oper_pressed = false;

        int dotCount = 0;


        private void button_Click(object sender, EventArgs e)
        {
            if ((CalculationBox.Text == "0") || (oper_pressed))
            {
                CalculationBox.Clear();
                dotCount = 0;
            }

            oper_pressed = false;
            Button b = (Button)sender;
            if (b.Text == "." && dotCount < 1)
            {
                dotCount++;
                CalculationBox.Text = CalculationBox.Text + b.Text;
                //oper_pressed = true;
            }
            if (b.Text != ".")
            {
                CalculationBox.Text = CalculationBox.Text + b.Text;
                //oper_pressed = true;
            }

        }
        
        private void operator_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                operation = b.Text;
                val = Double.Parse(CalculationBox.Text);
                oper_pressed = true;
                label1.Text = val + " " + operation;
            }
            catch (Exception formatexception)
            {
                MessageBox.Show("wrong fromat " + formatexception.Message, "syntax error", MessageBoxButtons.OK);
            }
        }

        private void buttonCe_Click(object sender, EventArgs e)
        {
            CalculationBox.Text = "0";
            val = 0;
            dotCount = 0;
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (CalculationBox.Text.Length > 0)
                CalculationBox.Text = (CalculationBox.Text.Substring(0, CalculationBox.Text.Length - 1));
            dotCount = 0;
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "";
                switch (operation)
                {
                    #region case for different buttons
                    case "+": CalculationBox.Text = (val + Double.Parse(CalculationBox.Text)).ToString(); break;
                    case "-": CalculationBox.Text = (val - Double.Parse(CalculationBox.Text)).ToString(); break;
                    case "*": CalculationBox.Text = (val * Double.Parse(CalculationBox.Text)).ToString(); break;
                    case "/":
                        if
                            (Double.Parse(CalculationBox.Text) == 0) MessageBox.Show("Cannot divide by zero", "Math error", MessageBoxButtons.OK);
                        else
                            CalculationBox.Text = (val / Double.Parse(CalculationBox.Text)).ToString();
                        break;
                    case "x^y": CalculationBox.Text = Math.Pow(val, Double.Parse(CalculationBox.Text)).ToString(); break;
                    case "x^2": CalculationBox.Text = Math.Pow(val, 2).ToString(); break;
                    case "x^3": CalculationBox.Text = Math.Pow(val, 3).ToString(); break;
                    case "%": CalculationBox.Text = (val % Double.Parse(CalculationBox.Text)).ToString(); break;

                    case "1/x": CalculationBox.Text = (1 / val).ToString(); break;
                    case "sqrt":
                        if (Double.Parse(CalculationBox.Text) < 0)
                        {
                            MessageBox.Show("negative sqrt is not allowed", "Math error", MessageBoxButtons.OK);
                        }
                        else
                            CalculationBox.Text = Math.Sqrt(val).ToString();
                        break;
                    case "ln x":
                        if (Double.Parse(CalculationBox.Text) > 0)
                        {
                            CalculationBox.Text = Math.Log(Double.Parse(CalculationBox.Text)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("ln does not exist", "Math error", MessageBoxButtons.OK);
                        }
                        break;
                    case "log x":
                        if (Double.Parse(CalculationBox.Text) > 0)
                        {
                            CalculationBox.Text = Math.Log10(val).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Log does not exist", "Math error", MessageBoxButtons.OK);
                        }
                        break;
                    case "e": CalculationBox.Text = Math.Exp(val).ToString(); break;



                    default:

                        break;
                        #endregion
                }
                
                    double ans = double.Parse(CalculationBox.Text);
                    if (ans == (double)ans)
                    {
                        dotCount = 1;
                        oper_pressed = true;

                    }
                    else
                        dotCount = 0; oper_pressed = true;
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " +
                   ex.Message,"Math error", MessageBoxButtons.OK);
            }
        }
                
        private void buttonPi_Click(object sender, EventArgs e)
        {
            CalculationBox.Text += Math.PI;
        }
               
        private void buttonBracketOpen_Click(object sender, EventArgs e)
        {
            CalculationBox.Text += buttonBracketOpen.Text;
        }

        private void buttonBracketClose_Click(object sender, EventArgs e)
        {
            CalculationBox.Text += buttonBracketClose.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //public class SyntaxException : Exception
        //{
        //    public SyntaxException()
        //    {

        //        //this.type = "Syntax error";
        //        MessageBox.Show("You made a mistake","Syntax error", MessageBoxButtons.OK);
        //    }
        //}

        //public class SqrtException : Exception
        //{
        //    public SqrtException(double x)
        //    {

        //        MessageBox.Show("Sqrt(" + x + ") does not exsists", "Math error", MessageBoxButtons.OK);
        //    }
        //}

        //public class DividedByZeroException : Exception
        //{
        //    public DividedByZeroException()
        //    {

        //        MessageBox.Show("Division by zero is impossible", "Math error", MessageBoxButtons.OK);
        //    }
        //}

        //public class LogException : Exception
        //{
        //    public LogException(double x)
        //    {

        //        MessageBox.Show("Log(" + x + ") does not exsists", "Math error", MessageBoxButtons.OK);
        //    }
        //}
    }       
}
