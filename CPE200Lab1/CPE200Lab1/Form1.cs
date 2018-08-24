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
            if (lblDisplay.Text.Length <= 7) {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + ((Button)sender).Text;
                }
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(lblDisplay.Text);
            Operation = 1;
            lblDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(lblDisplay.Text);
            Operation = 2;
            lblDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(lblDisplay.Text);
            Operation = 3;
            lblDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(lblDisplay.Text);
            Operation = 4;
            lblDisplay.Text = "0";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(lblDisplay.Text);

            if (Operation == 1)
            {
                result = num + num*(num2/100);
                lblDisplay.Text = Convert.ToString(result);
                num = result;
            }
            if (Operation == 2)
            {
                result = num - num * (num2 / 100);
                lblDisplay.Text = Convert.ToString(result);
                num = result;
            }
            if (Operation == 3)
            {
                result = num *( num * (num2 / 100));
                lblDisplay.Text = Convert.ToString(result);
                num = result;
            }
            if (Operation == 4)
            {
                if (num2 == 0)
                {
                    lblDisplay.Text = "ERROR";
                }
                else
                {
                    result = num / (num * (num2 / 100));
                    lblDisplay.Text = Convert.ToString(result);
                    num = result;
                }

            }
            if(Operation == 0)
            {
                result = num2 / 100;
                lblDisplay.Text = Convert.ToString(result);
                num = result;
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text;
            }

       }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text = lblDisplay.Text + "0";
            }
            else
            {
                lblDisplay.Text = "0";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(lblDisplay.Text);

            if (Operation == 1)
            {
                result = num + num2;
                lblDisplay.Text = Convert.ToString(result);
                num = result;
            }
            if (Operation == 2)
            {
                result = num - num2;
                lblDisplay.Text = Convert.ToString(result);
                num = result;
            }
            if (Operation == 3)
            {
                result = num * num2;
                lblDisplay.Text = Convert.ToString(result);
                num = result;
            }
            if (Operation == 4)
            {
                if (num2 == 0)
                {
                    lblDisplay.Text = "ERROR";
                }
                else
                {
                    result = num / num2;
                    lblDisplay.Text = Convert.ToString(result);
                    num = result;
                }
            }
            if(lblDisplay.Text.Length > 8)
                {
                    lblDisplay.Text = "ERROR";
                }
            else
            {
                lblDisplay.Text = lblDisplay.Text;
            }
            
        }

   
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }
    }
}
