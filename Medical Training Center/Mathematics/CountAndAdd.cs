using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_Training_Center.Mathematics
{
    public partial class CountAndAdd : Form
    {
        public CountAndAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="4" && textBox2.Text=="2" && textBox3.Text=="6")
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("InCorrect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "5" && textBox5.Text == "3" && textBox6.Text == "8")
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("InCorrect");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "6" && textBox8.Text == "3" && textBox9.Text == "9")
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("InCorrect");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "3" && textBox11.Text == "3" && textBox12.Text == "6")
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("InCorrect");
            }
        }
    }
}
