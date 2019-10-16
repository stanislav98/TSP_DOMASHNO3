using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;
            int month;
            string visokosna;
            try
            {
                year = Int32.Parse(textBox1.Text);
                month = Int32.Parse(textBox2.Text);
                if (DateTime.IsLeapYear(year))
                {
                    visokosna = "е високосна";
                }
                else
                {
                    visokosna = "не е високосна";
                }
                MessageBox.Show("Годината " + visokosna +".Има " + DateTime.DaysInMonth(year, month) +" дни", "COMPLETE");
            }
            catch
            {
                MessageBox.Show("МОЛЯ ВЪВЕДЕТЕ КОРЕКТНИ ДАННИ !", "ERROR");
            }
        }
    }
}
