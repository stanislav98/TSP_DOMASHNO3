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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int isNumber = 0;
            if (!int.TryParse(textBox1.Text, out isNumber) || !int.TryParse(textBox2.Text, out isNumber) 
                || !int.TryParse(textBox3.Text, out isNumber))
            {
                MessageBox.Show("МОЛЯ ВЪВЕДЕТЕ ЧИСЛО! ");
            }
            else
            {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                double c = Double.Parse(textBox3.Text);
                double descriminanta = (b * b) - 4 * a * c;
                if (descriminanta < 0)
                {
                    textBox6.Text = "THERE IS NO SOLUTION";
                    textBox5.Text = "THERE IS NO SOLUTION";
                    textBox4.Text = "THERE IS NO SOLUTION";
                }
                else
                {
                    textBox4.Text = descriminanta.ToString();
                    double sqrt = Math.Sqrt(descriminanta);
                    double x1 = (-b + sqrt) / (2 * a);
                    double x2 = (-b - sqrt) / (2 * a);
                    textBox5.Text = x1.ToString();
                    textBox6.Text =x2.ToString();

                }
            }
        }
    }
}
