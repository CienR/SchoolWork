using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        public delegate void Formula();
        public delegate T Formula<T>(T args1);

        CalculatorClass cal;

        public class CalculatorClass
        {
            public Formula<double> info;

            public double GetSum(double sum)
            {
                return sum;
            }

            public double GetSum(double num1, double num2)
            {
                return num1 + num2;
            }

            public double GetDifference(double diff)
            {
                return diff;
            }

            public double GetDifference(double num1, double num2)
            {
                return num1 - num2;
            }

            public double GetProduct(double prod)
            {
                return prod;
            }

            public double GetProduct(double num1, double num2)
            {
                return num1 * num2;
            }

            public double GetQuotient(double quot)
            {
                return quot;
            }

            public double GetQuotient(double num1, double num2)
            {
                return num1 / num2;
            }

            public event Formula<double> CalculateEvent
            {
                add
                {
                    Console.WriteLine("Delegate Added");
                    info += value;
                }
                remove
                {
                    Console.WriteLine("Delegate Removed");
                    info -= value;
                }
            }



        }
        public FrmCalculator()
        {
            InitializeComponent();
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");

            cal = new CalculatorClass();

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            String oprtr = cbOperator.Text.ToString();
            double num1 = double.Parse(txtBoxInput1.Text);
            double num2 = double.Parse(txtBoxInput2.Text);
            if (oprtr == "+")
            {
               
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }
            else if (oprtr == "-")
            {
               
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);

            }
            else if (oprtr == "*")
            {
                
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);

            }
            else if (oprtr == "/")
            {
                
                cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);

            }
           
        }
    }
}
