using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;

namespace Medical_Training_Center
{
    public partial class StartForm : Form
    {
        QuestionVO objQuestion;
        ToolTip tooltip;
        string ImagesDirectory = string.Empty;
        static int CurrentQuestionID = 0;
        string caseSelection = string.Empty;
        static int intVisualMemPicCount = 0;
        DataSet ds;
        PictureBox LocalPictureBox;


        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tooltip = new ToolTip();
            LocalPictureBox = new PictureBox();
            objQuestion = new QuestionVO();
            ImagesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='c:\users\arif\documents\visual studio 2010\Projects\Medical Training Center\Medical Training Center\MedicalDB.mdf';Integrated Security=True;User Instance=True");
            string DBPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)) + @"\MedicalDB.mdf";
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + DBPath + ";Integrated Security=True;User Instance=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from QuestionTB", con);

            ds = new System.Data.DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            adapter.Fill(ds);

            GlobalData.dtQuestionData = ds.Tables[0];

            objQuestion.QuestionID = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            CurrentQuestionID = objQuestion.QuestionID;
            objQuestion.QuestionType = Convert.ToString(ds.Tables[0].Rows[CurrentQuestionID][1]);
            objQuestion.QuestionTitle = Convert.ToString(ds.Tables[0].Rows[CurrentQuestionID][2]);
            objQuestion.QuestionName = Convert.ToString(ds.Tables[0].Rows[CurrentQuestionID][3]).Split('~');
            string strOptions = Convert.ToString(ds.Tables[0].Rows[CurrentQuestionID][4]);
            objQuestion.QuestionOptions = strOptions.Split('~');
            objQuestion.QuestionAnswer = Convert.ToString(ds.Tables[0].Rows[CurrentQuestionID][5]).Split('~');

            lblQuestionTitle.Text = objQuestion.QuestionTitle;

            pictureBox1.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[0] + ".jpg");
            pictureBoxOption1.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionOptions[0] + ".jpg");
            pictureBox3.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionOptions[1] + ".jpg");
            pictureBox4.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionOptions[2] + ".jpg");
            pictureBox5.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionOptions[3] + ".jpg");


            // setting tool tip
            tooltip.SetToolTip(this.pictureBoxOption1, "Click to select option");
            tooltip.SetToolTip(this.pictureBox3, "Click to select option");
            tooltip.SetToolTip(this.pictureBox4, "Click to select option");
            tooltip.SetToolTip(this.pictureBox5, "Click to select option");

            con.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBoxStatus.Visible = true;
            if (objQuestion.QuestionAnswer.Equals(objQuestion.QuestionOptions[3]))
            {
                pictureBoxStatus.Image = Image.FromFile(ImagesDirectory + @"\Success" + ".jpg");
            }
            else
            {
                pictureBoxStatus.Image = Image.FromFile(ImagesDirectory + @"\Wrong" + ".png");
            }
            DisablePictureBox(pictureBox5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void EnablePictureBox()
        {
            pictureBoxOption1.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;

            pictureBoxStatus.Image = Image.FromFile(ImagesDirectory + @"\QuestionMark" + ".gif");

            pictureBoxOption1.MouseLeave += pictureBox2_MouseLeave;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            pictureBox5.MouseLeave += pictureBox5_MouseLeave;

            LocalPictureBox.BorderStyle = BorderStyle.None;


            //for visual memory picture boxes
            visualmemorypic1.Visible = true;
            visualmemorypic2.Visible = true ;
            visualmemorypic3.Visible = true;
            visualmemorypic4.Visible = true;
            visualmemorypic5.Visible = true;
            visualmemorypic6.Visible = true;
            visualmemorypic7.Visible = true;
            visualmemorypic8.Visible = true;
            visualmemorypic9.Visible = true;
            visualmemorypic10.Visible = true;
            visualmemorypic11.Visible = true;
            visualmemorypic12.Visible = true;

        }

        private void DisablePictureBox(PictureBox Lpicturebox)
        {
            LocalPictureBox = Lpicturebox;
            pictureBoxOption1.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;

            LocalPictureBox.Enabled = true;

            pictureBoxOption1.MouseLeave -= pictureBox2_MouseLeave;
            pictureBox3.MouseLeave -= pictureBox3_MouseLeave;
            pictureBox4.MouseLeave -= pictureBox4_MouseLeave;
            pictureBox5.MouseLeave -= pictureBox5_MouseLeave;

            LocalPictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBoxStatus.Visible = true;
            if (objQuestion.QuestionAnswer.Equals(objQuestion.QuestionOptions[0]))
            {
                pictureBoxStatus.Image = Image.FromFile(ImagesDirectory + @"\Success" + ".jpg");
            }
            else
            {
                pictureBoxStatus.Image = Image.FromFile(ImagesDirectory + @"\Wrong" + ".png");
            }
            DisablePictureBox(pictureBoxOption1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBoxStatus.Visible = true;
            if (objQuestion.QuestionAnswer.Equals(objQuestion.QuestionOptions[1]))
            {
                pictureBoxStatus.Image = Image.FromFile(ImagesDirectory + @"\Success" + ".jpg");
            }
            else
            {
                pictureBoxStatus.Image = Image.FromFile(ImagesDirectory + @"\Wrong" + ".png");
            }
            DisablePictureBox(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBoxStatus.Visible = true;
            if (objQuestion.QuestionAnswer.Equals(objQuestion.QuestionOptions[2]))
            {
                pictureBoxStatus.Image = Image.FromFile(ImagesDirectory + @"\Success" + ".jpg");
            }
            else
            {
                pictureBoxStatus.Image = Image.FromFile(ImagesDirectory + @"\Wrong" + ".png");
            }
            DisablePictureBox(pictureBox4);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            tooltip.SetToolTip(this.pictureBoxOption1, "Click to select option");

            pictureBoxOption1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxOption1.BorderStyle = BorderStyle.None;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {

            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.None;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = BorderStyle.None;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            intVisualMemPicCount = 0;
            EnablePictureBox();
            CurrentQuestionID++;
            objQuestion.QuestionID = CurrentQuestionID;
            //CurrentQuestionID = objQuestion.QuestionID;
            GlobalData.CurrentQuestionID = CurrentQuestionID;
            try
            {
                if (ds.Tables[0].Rows[CurrentQuestionID][0] != null)
                {
                    objQuestion.QuestionType = Convert.ToString(ds.Tables[0].Rows[CurrentQuestionID][1]);
                    objQuestion.QuestionTitle = Convert.ToString(ds.Tables[0].Rows[CurrentQuestionID][2]);
                    objQuestion.QuestionName = Convert.ToString(ds.Tables[0].Rows[CurrentQuestionID][3]).Split('~');
                    string strOptions = Convert.ToString(ds.Tables[0].Rows[CurrentQuestionID][4]);
                    objQuestion.QuestionOptions = strOptions.Split('~');
                    objQuestion.QuestionAnswer = Convert.ToString(ds.Tables[0].Rows[CurrentQuestionID][5]).Split('~');

                    lblQuestionTitle.Text = objQuestion.QuestionTitle;
                    caseSelection = objQuestion.QuestionType.Trim();

                    if (caseSelection != "VMM" && !caseSelection.Equals("P"))
                    {
                        pictureBox1.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[0] + ".jpg");
                    }
                    if (!caseSelection.Equals("P"))
                    {
                        pictureBoxOption1.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionOptions[0] + ".jpg");
                        pictureBox3.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionOptions[1] + ".jpg");
                        pictureBox4.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionOptions[2] + ".jpg");
                        pictureBox5.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionOptions[3] + ".jpg");
                    }
                }
                switch (caseSelection)
                {
                    case "VD":
                        break;
                    case "VM":
                        visualmemorypanel.Visible = false;
                        panel1.Visible = true;
                        pictureBox1.Visible = true;
                        panel2.Visible = true;
                        lblQuestionTitle.Visible = true;
                        pictureBoxOption1.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;
                        pictureBox5.Visible = true;
                        pictureBoxStatus.Visible = true;
                        VisiblePictureBoxes(false);
                        timer1.Start();
                        break;
                    case "VMM":
                        visualmemorypanel.Visible = true;
                        panel1.Visible = false;
                        pictureBox1.Visible = false;
                        panel2.Visible = false;
                        lblQuestionTitle.Visible = false;
                        pictureBoxOption1.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBoxStatus.Visible = false;
                        visualmemorypic1.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[0] + ".jpg");
                        visualmemorypic2.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[1] + ".jpg");
                        visualmemorypic3.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[2] + ".jpg");
                        visualmemorypic4.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[3] + ".jpg");
                        visualmemorypic5.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[4] + ".jpg");
                        visualmemorypic6.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[5] + ".jpg");
                        visualmemorypic7.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[6] + ".jpg");
                        visualmemorypic8.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[7] + ".jpg");
                        visualmemorypic9.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[8] + ".jpg");
                        visualmemorypic10.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[9] + ".jpg");
                        visualmemorypic11.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[10] + ".jpg");
                        visualmemorypic12.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionName[11] + ".jpg");
                        visualmemoryanswer.Visible = false;
                        timer1.Start();
                        break;
                    case "P":
                        this.Hide();
                        Puzzle objPuzzle = new Puzzle(objQuestion.QuestionTitle, (ImagesDirectory + @"\" + objQuestion.QuestionName[0] + ".jpg"));
                        objPuzzle.Show();
                        objPuzzle.LoadPicture();
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Game Finished");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void VisiblePictureBoxes(bool visibility)
        {
            pictureBoxOption1.Visible = visibility;
            pictureBox3.Visible = visibility;
            pictureBox4.Visible = visibility;
            pictureBox5.Visible = visibility;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (caseSelection != "VMM")
            {
                pictureBox1.Image = Image.FromFile(ImagesDirectory + @"\QuestionMark" + ".gif");
                VisiblePictureBoxes(true);
                timer1.Stop();
            }
            else
            {
                visualmemorypic1.Visible = false;
                visualmemorypic2.Visible = false;
                visualmemorypic3.Visible = false;
                visualmemorypic4.Visible = false;
                visualmemorypic5.Visible = false;
                visualmemorypic6.Visible = false;
                visualmemorypic7.Visible = false;
                visualmemorypic8.Visible = false;
                visualmemorypic9.Visible = false;
                visualmemorypic10.Visible = false;
                visualmemorypic11.Visible = false;
                visualmemorypic12.Visible = false;

                visualmemoryanswer.Visible = true;
                visualmemoryanswer.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionOptions[0] + ".jpg");
                visualmemoryanswer.Tag = objQuestion.QuestionOptions[0];
            }
            timer1.Stop();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void visualmemorypic7_Click(object sender, EventArgs e)
        {

        }

        private void visualmemorypic6_Click(object sender, EventArgs e)
        {

        }

        private void visualmemorypic8_Click(object sender, EventArgs e)
        {

        }

        private void visualmemorypic1_Click(object sender, EventArgs e)
        {

        }

        private void visualmemorypic2_Click(object sender, EventArgs e)
        {

        }

        private void visualmemorypic3_Click(object sender, EventArgs e)
        {

        }

        private void visualmemorypic4_Click(object sender, EventArgs e)
        {

        }

        private void visualmemorypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVisualNext_Click(object sender, EventArgs e)
        {
            intVisualMemPicCount++;
            if (intVisualMemPicCount <= 11)
            {
                visualmemoryanswer.Image = Image.FromFile(ImagesDirectory + @"\" + objQuestion.QuestionOptions[intVisualMemPicCount] + ".jpg");
                visualmemoryanswer.Tag = objQuestion.QuestionOptions[intVisualMemPicCount];
            }
            else
            {
                MessageBox.Show("Options Over!");
                btnNext_Click(null, null);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            bool flag = false;

            if (objQuestion.QuestionAnswer.Contains(visualmemoryanswer.Tag))
            {
                flag = true;
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
