using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator
{
    public partial class simple : Form
    {
        public simple()
        {
            InitializeComponent();
        }
        decimal result;
        decimal num1;
        decimal num2;
        string operation;


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShowing.Text = ("");
            num2 = 0;
            num1 = 0;
            result = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtShowing.Text =  "1";
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtShowing.Text =  "2";
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtShowing.Text =  "3";
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtShowing.Text =   "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtShowing.Text =  "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtShowing.Text =  "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtShowing.Text =  "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtShowing.Text =  "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtShowing.Text =  "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtShowing.Text =  "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = Convert.ToDecimal(txtShowing.Text);


        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = Convert.ToDecimal(txtShowing.Text);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = Convert.ToDecimal(txtShowing.Text);
        }

        private void brnDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = Convert.ToDecimal(txtShowing.Text);
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDecimal(txtShowing.Text);
            
            if (operation == ("+"))
                result = num1 + num2;

            if (operation== ("-"))
                result = num1 - num2;
            if (operation ==("*"))
                result = num1 * num2;
            if (operation == ("/"))
                result = num1 / num2;
            txtShowing.Text = Convert.ToString(result);
            
        }
    }
}
