using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = new int[50];
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                nums[i] = rand.Next(49)+1;
            }
            label1.Text = (rand.Next(0, nums.Length)).ToString();
            label2.Text = (rand.Next(0, nums.Length)).ToString();
            label3.Text = (rand.Next(0, nums.Length)).ToString();
            label4.Text = (rand.Next(0, nums.Length)).ToString();
            label5.Text = (rand.Next(0, nums.Length)).ToString();
            label6.Text = (rand.Next(0, nums.Length)).ToString();
        }
    }
}
