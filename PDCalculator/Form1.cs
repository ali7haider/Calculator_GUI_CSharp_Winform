using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDCalculator
{
    public partial class FormCalculator : Form
    {
        public static char equalOperator;
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 8;
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 0;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 7;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 9;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + '+';
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + '.';
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + '-';
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + '/';
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + '*';
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length>2)
            {
                string o1 = parse_data(1);
                string o2 = parse_data(2);
                if(o1=="")
                {
                    o1 = "0";
                }
                if (o2 == "")
                {
                    o2 = "0";
                }
                float num1 = float.Parse(o1);
                float num2 = float.Parse(o2);
                float res = 0;
                if (equalOperator == '+')
                {
                    res = num1 + num2;
                }
                else if (equalOperator == '/')
                {
                    res = num1 / num2;

                }
                else if (equalOperator == '*')
                {
                    res = num1 * num2;

                }
                else if (equalOperator == '-')
                {
                    res = num1 - num2;

                }
                txtOutput.Text = res.ToString();
            }
        }
        private string parse_data(int field)
        {
            string item = "";
            int operation = 1;
            for (int i = 0; i < txtOutput.Text.Length; i++)
            {
                if (txtOutput.Text[i] == '+' || txtOutput.Text[i] == '/' || txtOutput.Text[i] == '-' || txtOutput.Text[i] == '*')
                {
                    equalOperator = txtOutput.Text[i];
                    operation++;
                }
                else if (operation == field)
                {
                    item = item + txtOutput.Text[i];
                }
            }
            return item;
        }
    }
}
