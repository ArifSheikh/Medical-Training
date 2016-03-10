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
    public partial class NumberSequence : Form
    {
        public NumberSequence()
        {
            InitializeComponent();
        }

        private void NumberSequence_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((Convert.ToInt32(textBox1.Text) < Convert.ToInt32(textBox2.Text)) && ((Convert.ToInt32(textBox2.Text)) < (Convert.ToInt32(textBox3.Text))))
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
            if ((Convert.ToInt32(textBox5.Text)) == (Convert.ToInt32(textBox6.Text) - 1))
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
            if ((Convert.ToInt32(textBox7.Text))+1 == (Convert.ToInt32(textBox8.Text)))
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
