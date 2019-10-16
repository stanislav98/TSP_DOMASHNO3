using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int input_m = Int32.Parse(textBox1.Text);
                int input_d = Int32.Parse(textBox2.Text);
                int input_y = Int32.Parse(textBox3.Text);
                if (input_m >= 0 && input_m <= 12 && input_d >= 0 && input_d <= 31 && input_y <= DateTime.Today.Year)
                {
                    int day = DateTime.Today.Day;
                    int month = DateTime.Today.Month;
                    int year = DateTime.Today.Year;
                    int calced_year;
                    int calced_month;
                    if (input_m < month && input_m > month)
                    {
                        calced_month = month - input_m;
                    }
                    else
                    {
                        calced_month = 0;
                        calced_year=-1;
                    }
                    calced_year = year - input_y;
                    if (input_m == month)
                    {
                        if (input_d > day)
                        {
                            calced_year--;
                            calced_month = 11;
                        }
                    }
                    MessageBox.Show("You are :  " + calced_year + "years old and " + calced_month + " month .", "CALC");
                }
                else
                {
                    MessageBox.Show("Въведете коректни данни ! ", "ERROR");
                }
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни ! ", "ERROR");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
