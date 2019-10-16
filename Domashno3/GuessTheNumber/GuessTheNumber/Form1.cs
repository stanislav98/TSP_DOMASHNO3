using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int guess = Int32.Parse(textBox1.Text);
                if (guess > number)
                {
                    MessageBox.Show("Числото е по-малко от " + guess);
                }
                else if (guess < number)
                {
                    MessageBox.Show("Числото е по-голямо от " + guess);
                }
                else if (guess == number)
                {
                    MessageBox.Show("Поздравления,вие познахте числото !!! ");
                }
            }
            catch
            {
                MessageBox.Show("Въведете цяло число!");
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            number = rand.Next(1, 100);
        }
    }
}
