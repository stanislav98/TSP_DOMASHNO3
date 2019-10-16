using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathFormulas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int isNumber = 0;
            if (!int.TryParse(textBox1.Text, out isNumber) || !int.TryParse(textBox2.Text, out isNumber))
            {
                MessageBox.Show("МОЛЯ ВЪВЕДЕТЕ ЧИСЛО! ");
            }
            else if (radioButton1.Checked)
            {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                textBox3.Text = (Math.Pow(a, 2) + 2 * (a * b) + Math.Pow(b, 2)).ToString();
            }
            else if (radioButton2.Checked)
            {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                textBox3.Text = (Math.Pow(a, 2) - 2 * (a * b) + Math.Pow(b, 2)).ToString();
            }
            else if (radioButton4.Checked)
            {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                textBox3.Text = (Math.Pow(a, 2) - Math.Pow(b, 2)).ToString();
            }
            else if (radioButton3.Checked)
            {   
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                textBox3.Text = (Math.Pow(a, 3) + 3* ((Math.Pow(a,2)) * b) +  3 * (a * (Math.Pow(b,2))) + Math.Pow(b, 3)).ToString();
            }
            else if (radioButton5.Checked)
            {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                textBox3.Text = (Math.Pow(a, 3) - 3 * ((Math.Pow(a, 2)) * b) + 3 * (a * (Math.Pow(b, 2))) - Math.Pow(b, 3)).ToString();
            }
            else if (radioButton6.Checked)
            {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                textBox3.Text = (Math.Pow(a, 3) + Math.Pow(b, 3)).ToString();
            }
            else if (radioButton7.Checked)
            {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                textBox3.Text = (Math.Pow(a, 3) - Math.Pow(b, 3)).ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
