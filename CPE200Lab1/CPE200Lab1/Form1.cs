using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        double num, num2, result = 0;
        int Operation = 0;

        private void btnN_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblDisplay.Text == "0" || lblDisplay.Text == string.Format("{0:0}",num) || lblDisplay.Text == string.Format("{0:0}",result))
            {
                lblDisplay.Text = "";
            }
            if (lblDisplay.Text.Length <= 8)
                lblDisplay.Text = lblDisplay.Text + btn.Text;
            

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num = double.Parse(lblDisplay.Text);
            Operation = 1;
            lblDisplay.Text = string.Format("{0:0}", num);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num = double.Parse(lblDisplay.Text);
            Operation = 2;
            lblDisplay.Text = string.Format("{0:0}", num);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num = double.Parse(lblDisplay.Text);
            Operation = 3;
            lblDisplay.Text = string.Format("{0:0}", num);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num = double.Parse(lblDisplay.Text);
            Operation = 4;
            lblDisplay.Text = string.Format("{0:0}", num);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(lblDisplay.Text);
            num2 = num * num2 / 100;
            lblDisplay.Text = string.Format("{0:0}", num2);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(lblDisplay.Text);
            result = 0;
            lblDisplay.Text = string.Format("{0:0}", num2);
            if (Operation == 1) result = num + num2;
            else if (Operation == 2) result = num - num2;
            else if (Operation == 3) result = num * num2;
            else if (Operation == 4) result = num / num2;

            lblDisplay.Text = string.Format("{0:0}", result);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }
    }
}
