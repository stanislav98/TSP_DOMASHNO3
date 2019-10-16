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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int isNumber = 0;
            if (!int.TryParse(textBox1.Text, out isNumber) || !int.TryParse(textBox2.Text, out isNumber))
            {
                MessageBox.Show("МОЛЯ ВЪВЕДЕТЕ ЧИСЛО! ");
            }
            else
            {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                textBox3.Text = Math.Pow(a, b).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
