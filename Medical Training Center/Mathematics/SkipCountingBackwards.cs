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
    public partial class SkipCountingBackwards : Form
    {
        public SkipCountingBackwards()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBackWardValues();
        }

        private void CheckBackWardValues()
        {
            bool blnflag1 = false;
            bool blnflag2 = false;
            bool blnflag3 = false;
            bool blnflag4 = false;
            bool blnflag5 = false;
            bool blnflag6 = false;
            try
            {
                int idifference1 = Convert.ToInt32(textBox1.Tag);
                int idifference2 = Convert.ToInt32(textBox5.Tag);
                int idifference3 = Convert.ToInt32(textBox9.Tag);
                int idifference4 = Convert.ToInt32(textBox13.Tag);
                int idifference5 = Convert.ToInt32(textBox17.Tag);
                int idifference6 = Convert.ToInt32(textBox21.Tag);

                int iQ_1_1 = Convert.ToInt32(textBox1.Text);
                int iQ_1_2 = Convert.ToInt32(textBox2.Text);
                int iQ_1_3 = Convert.ToInt32(textBox3.Text);
                int iQ_1_4 = Convert.ToInt32(textBox4.Text);

                int iQ_2_1 = Convert.ToInt32(textBox5.Text);
                int iQ_2_2 = Convert.ToInt32(textBox6.Text);
                int iQ_2_3 = Convert.ToInt32(textBox7.Text);
                int iQ_2_4 = Convert.ToInt32(textBox8.Text);

                int iQ_3_1 = Convert.ToInt32(textBox9.Text);
                int iQ_3_2 = Convert.ToInt32(textBox10.Text);
                int iQ_3_3 = Convert.ToInt32(textBox11.Text);
                int iQ_3_4 = Convert.ToInt32(textBox12.Text);

                int iQ_4_1 = Convert.ToInt32(textBox13.Text);
                int iQ_4_2 = Convert.ToInt32(textBox14.Text);
                int iQ_4_3 = Convert.ToInt32(textBox15.Text);
                int iQ_4_4 = Convert.ToInt32(textBox16.Text);

                int iQ_5_1 = Convert.ToInt32(textBox17.Text);
                int iQ_5_2 = Convert.ToInt32(textBox18.Text);
                int iQ_5_3 = Convert.ToInt32(textBox19.Text);
                int iQ_5_4 = Convert.ToInt32(textBox20.Text);

                int iQ_6_1 = Convert.ToInt32(textBox21.Text);
                int iQ_6_2 = Convert.ToInt32(textBox22.Text);
                int iQ_6_3 = Convert.ToInt32(textBox23.Text);
                int iQ_6_4 = Convert.ToInt32(textBox24.Text);

           

            if ((iQ_1_1 - idifference1) == (iQ_1_2))
            {
                if ((iQ_1_2 - idifference1) == (iQ_1_3))
                {
                    if ((iQ_1_3 - idifference1) == (iQ_1_4))
                    {
                        blnflag1 = true;
                    }
                }
            }

            if ((iQ_2_1 - idifference2) == (iQ_2_2))
            {
                if ((iQ_2_2 - idifference2) == (iQ_2_3))
                {
                    if ((iQ_2_3 - idifference2) == (iQ_2_4))
                    {
                        blnflag2 = true;
                    }
                }
            }

            if ((iQ_3_1 - idifference3) == (iQ_3_2))
            {
                if ((iQ_3_2 - idifference3) == (iQ_3_3))
                {
                    if ((iQ_3_3 - idifference3) == (iQ_3_4))
                    {
                        blnflag3 = true;
                    }
                }
            }

            if ((iQ_4_1 - idifference4) == (iQ_4_2))
            {
                if ((iQ_4_2 - idifference4) == (iQ_4_3))
                {
                    if ((iQ_4_3 - idifference4) == (iQ_4_4))
                    {
                        blnflag4 = true;
                    }
                }
            }

            if ((iQ_5_1 - idifference5) == (iQ_5_2))
            {
                if ((iQ_5_2 - idifference5) == (iQ_5_3))
                {
                    if ((iQ_5_3 - idifference5) == (iQ_5_4))
                    {
                        blnflag5 = true;
                    }
                }
            }

            if ((iQ_6_1 - idifference6) == (iQ_6_2))
            {
                if ((iQ_6_2 - idifference6) == (iQ_6_3))
                {
                    if ((iQ_6_3 - idifference6) == (iQ_6_4))
                    {
                        blnflag6 = true;
                    }
                }
            }
            if (blnflag1 && blnflag2 && blnflag3 && blnflag4 && blnflag5 && blnflag6)
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Incorrect!");
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
    }
}
