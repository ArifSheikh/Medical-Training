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
    public partial class Missingnumbers : Form
    {
        public List<Label> lstLabel = new List<Label>();
        public List<TextBox> lstTextBox = new List<TextBox>();
        public Missingnumbers()
        {
            InitializeComponent();

            lstLabel.Add(label1);
            lstLabel.Add(label2);
            lstLabel.Add(label3);
            lstLabel.Add(label4);
            lstLabel.Add(label5);
            lstLabel.Add(label6);
            lstLabel.Add(label7);
            lstLabel.Add(label8);
            lstLabel.Add(label9);
            lstLabel.Add(label10);
            lstLabel.Add(label11);
            lstLabel.Add(label12);
            lstLabel.Add(label13);
            lstLabel.Add(label14);
            lstLabel.Add(label15);
            lstLabel.Add(label19);
            lstLabel.Add(label20);
            lstLabel.Add(label21);
            lstLabel.Add(label25);
            lstLabel.Add(label26);
            lstLabel.Add(label27);
            lstLabel.Add(label31);
            lstLabel.Add(label32);
            lstLabel.Add(label33);
           
            lstTextBox.Add(textBox1);
            lstTextBox.Add(textBox2);
            lstTextBox.Add(textBox3);
            lstTextBox.Add(textBox4);
            lstTextBox.Add(textBox5);
            lstTextBox.Add(textBox6);
            lstTextBox.Add(textBox7);
            lstTextBox.Add(textBox8);
            lstTextBox.Add(textBox9);
            lstTextBox.Add(textBox10);
            lstTextBox.Add(textBox11);
            lstTextBox.Add(textBox12);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = 12;
            try
            {
                
                bool flag = false;
                for (int i = 1; i <= 12; i++)
                {
                    int j = i + 12;

                    Label l1 = lstLabel.Find(item => item.Tag.ToString() == i.ToString());
                    Label l2 = lstLabel.Find(item => item.Tag.ToString() == j.ToString());
                    TextBox t = lstTextBox.Find(item => item.Tag.ToString() == i.ToString());

                    if ((Convert.ToInt32(l1.Text)) +
                        (Convert.ToInt32(t.Text)) !=
                        (Convert.ToInt32(l2.Text)))
                    {
                        score--;    // for calculating score
                        flag = true;
                    }
                }

                if (!flag)
                {
                    MessageBox.Show("Correct ! Score is "+score);
                }
                else
                {
                    MessageBox.Show("InCorrect ! Score is " + score);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter numeric value");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }
    }
}
