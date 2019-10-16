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
        double pddo,pdzo;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && !int.TryParse(textBox1.Text, out isNumber))
            {
                e.Handled = true; textBox1.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(textBox1.Text);
                if (radioButton1.Checked)
                {
                    pddo = 0.089;
                    pdzo = 0;
                }
                else
                {
                    pddo = 0.067;
                    pdzo = 0.022;
                }
                label6.Text = (a * pddo).ToString() + " лв.";
                label7.Text = (a * pdzo).ToString() + " лв.";
                label8.Text = (a * 0.032).ToString() + " лв.";
                label9.Text = ((a * pdzo) + (a * pddo) + (a * 0.032)).ToString() + " лв.";
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(textBox1.Text);
                if (radioButton1.Checked)
                {
                    pddo = 0.089;
                    pdzo = 0;
                }
                else
                {
                    pddo = 0.067;
                    pdzo = 0.022;
                }
                label6.Text = (a * pddo).ToString() + " лв.";
                label7.Text = (a * pdzo).ToString() + " лв.";
                label8.Text = (a * 0.032).ToString() + " лв.";
                label9.Text = ((a * pdzo) + (a * pddo) + (a * 0.032)).ToString() + " лв.";
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear();
            }
        }
    }
}
