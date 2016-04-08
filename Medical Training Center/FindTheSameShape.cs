using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_Training_Center
{
    public partial class FindTheSameShape : Form
    {
        public FindTheSameShape()
        {
            InitializeComponent();
        }

        private void FindTheSameShape_Load(object sender, EventArgs e)
        {
            pnlFindTheShape1.Visible = true;
            pnlFindTheShape2.Visible = false;
            pnlFindTheShape3.Visible = false;

        }

        private void pBoxAnswer1_Click(object sender, EventArgs e)
        {
         
        }

        private void bBoxQ1_Click(object sender, EventArgs e)
        {
            
        }

        private void pBoxOption2_Click(object sender, EventArgs e)
        {

        }

        private void pBoxAnswer2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
        }

        private void pBoxQ2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try Again");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Correct");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Try Again");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Try Again");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Try Again");
        }

        private void pnlFindTheShape3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlFindTheShape2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pnlFindTheShape1.Visible == true)
            {
                pnlFindTheShape1.Visible = false;
                pnlFindTheShape2.Visible = true;
            }
            else if (pnlFindTheShape2.Visible == true)
            {
                pnlFindTheShape2.Visible = false;
                pnlFindTheShape3.Visible = true;
            }
        }

        private void pnlFindTheShape1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pBoxAnswer1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Correct");
        }

        private void bBoxQ1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Try again");
        }
    }
}
