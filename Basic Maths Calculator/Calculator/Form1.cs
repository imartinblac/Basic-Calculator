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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string op = null;
        decimal answer;
        string entry1 = null;
        string entry2 = null;
        private void btn1_Click(object sender, EventArgs e)
        {
            if(op == null && entry2 == null)
            {
                txtEntry.Text = "";
                entry1 += "1";
                txtEntry.Text = entry1;
            }
            else if(!(op == null))
            {
                txtEntry.Text = "";
                entry2 += "1";
                txtEntry.Text = entry2;

            }


            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (op == null && entry2 == null)
            {
                txtEntry.Text = "";
                entry1 += "2";
                txtEntry.Text = entry1;
            }
            else if (!(op == null))
            {
                txtEntry.Text = "";
                entry2 += "2";
                txtEntry.Text = entry2;

            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (op == null && entry2 == null)
            {
                txtEntry.Text = "";
                entry1 += "3";
                txtEntry.Text = entry1;
            }
            else if (!(op == null))
            {
                txtEntry.Text = "";
                entry2 += "3";
                txtEntry.Text = entry2;

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (op == null && entry2 == null)
            {
                txtEntry.Text = "";
                entry1 += "4";
                txtEntry.Text = entry1;
            }
            else if (!(op == null))
            {
                txtEntry.Text = "";
                entry2 += "4";
                txtEntry.Text = entry2;

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (op == null && entry2 == null)
            {
                txtEntry.Text = "";
                entry1 += "5";
                txtEntry.Text = entry1;
            }
            else if (!(op == null))
            {
                txtEntry.Text = "";
                entry2 += "5";
                txtEntry.Text = entry2;

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (op == null && entry2 == null)
            {
                txtEntry.Text = "";
                entry1 += "6";
                txtEntry.Text = entry1;
            }
            else if (!(op == null))
            {
                txtEntry.Text = "";
                entry2 += "6";
                txtEntry.Text = entry2;

            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (op == null && entry2 == null)
            {
                txtEntry.Text = "";
                entry1 += "7";
                txtEntry.Text = entry1;
            }
            else if (!(op == null))
            {
                txtEntry.Text = "";
                entry2 += "7";
                txtEntry.Text = entry2;

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (op == null && entry2 == null)
            {
                txtEntry.Text = "";
                entry1 += "8";
                txtEntry.Text = entry1;
            }
            else if (!(op == null))
            {
                txtEntry.Text = "";
                entry2 += "8";
                txtEntry.Text = entry2;

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (op == null && entry2 == null)
            {
                txtEntry.Text = "";
                entry1 += "9";
                txtEntry.Text = entry1;
            }
            else if (!(op == null))
            {
                txtEntry.Text = "";
                entry2 += "9";
                txtEntry.Text = entry2;

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if (op == null && entry2 == null)
            {
                txtEntry.Text = "";
                entry1 += "0";
                txtEntry.Text = entry1;
            }
            else if (!(op == null))
            {
                txtEntry.Text = "";
                entry2 += "0";
                txtEntry.Text = entry2;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEntry.Clear();
            entry1 = null;
            entry2 = null;
            op = null;
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            txtEntry.Text = Calculate().ToString();
            entry1 = txtEntry.Text;
            entry2 = null;
            op = null;

        }

        private decimal Calculate()
        {
            if(op == "plus")
            {
                answer = Convert.ToDecimal(entry1) + Convert.ToDecimal(entry2);
            }
            else if(op == "minus")
            {
                answer = Convert.ToDecimal(entry1) - Convert.ToDecimal(entry2);
            }
            else if (op == "times")
            {
                answer = Convert.ToDecimal(entry1) * Convert.ToDecimal(entry2);
            }
            else if (op == "by")
            {
                if(entry2 == "0")
                {
                    txtEntry.Text = "Entry error!";
                    op = null;
                    //entry1 = null;
                    //entry2 = null;
                }
                else
                {
                    answer = Convert.ToDecimal(entry1) / Convert.ToDecimal(entry2);
                }
                
            }
            return answer;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            op = "plus";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            op = "minus";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            op = "times";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            op = "by";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
