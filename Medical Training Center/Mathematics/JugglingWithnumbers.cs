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
    public partial class JugglingWithnumbers : Form
    {
        int[] NumberArray;
        bool Nextflag = false;
        public JugglingWithnumbers()
        {
            InitializeComponent();
        }

        private void JugglingWithnumbers_Load(object sender, EventArgs e)
        {
            NumberArray = new int[8];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool errorFlag = false;
                int iLength = NumberArray.Length;

                NumberArray[0] = Convert.ToInt32(textBox1.Text);
                NumberArray[1] = Convert.ToInt32(textBox2.Text);
                NumberArray[2] = Convert.ToInt32(textBox3.Text);
                NumberArray[3] = Convert.ToInt32(textBox4.Text);
                NumberArray[4] = Convert.ToInt32(textBox5.Text);
                NumberArray[5] = Convert.ToInt32(textBox6.Text);
                NumberArray[6] = Convert.ToInt32(textBox7.Text);
                NumberArray[7] = Convert.ToInt32(textBox8.Text);

                if (Nextflag)
                {
                    NumberArray[8] = Convert.ToInt32(textBox9.Text);
                    NumberArray[9] = Convert.ToInt32(textBox10.Text);
                }

                for (int i = 0; i < iLength; i++)
                {
                    for (int j = i + 1; j < iLength; j++)
                    {
                        if (NumberArray[i] == NumberArray[j])
                        {
                            errorFlag = true;
                        }
                    }
                    if (i % 2 == 0)
                    {
                        if ((NumberArray[i] + NumberArray[i + 1]) != iLength - 1)
                        {
                            errorFlag = true;
                        }
                    }
                }
                if (errorFlag)
                {
                    MessageBox.Show("Incorrect");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter numeric value!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            textBox9.Visible = true;
            textBox10.Visible = true;
            NumberArray = new int[10];
            Nextflag = true;
        }
    }
}
