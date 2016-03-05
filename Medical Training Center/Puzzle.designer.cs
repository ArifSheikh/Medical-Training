namespace Medical_Training_Center
{
    partial class Puzzle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puzzle));
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.picPuzzle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbSamplePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPuzzle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSamplePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdPicture
            // 
            this.ofdPicture.Filter = "Graphics Files|*.jpg;*.gif;*.png|All Files|*.*";
            // 
            // picPuzzle
            // 
            this.picPuzzle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picPuzzle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPuzzle.Location = new System.Drawing.Point(192, 286);
            this.picPuzzle.Name = "picPuzzle";
            this.picPuzzle.Size = new System.Drawing.Size(389, 201);
            this.picPuzzle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPuzzle.TabIndex = 1;
            this.picPuzzle.TabStop = false;
            this.picPuzzle.Visible = false;
            this.picPuzzle.Click += new System.EventHandler(this.picPuzzle_Click);
            this.picPuzzle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPuzzle_MouseDown);
            this.picPuzzle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPuzzle_MouseMove);
            this.picPuzzle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPuzzle_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(103, 250);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(331, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Join the pictures looking at the sample picture";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pbSamplePicture
            // 
            this.pbSamplePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbSamplePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSamplePicture.Location = new System.Drawing.Point(330, 15);
            this.pbSamplePicture.Name = "pbSamplePicture";
            this.pbSamplePicture.Size = new System.Drawing.Size(251, 232);
            this.pbSamplePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSamplePicture.TabIndex = 3;
            this.pbSamplePicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sample Picture";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.picPuzzle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pbSamplePicture);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 641);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(95, 159);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 72);
            this.btnNext.TabIndex = 7;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1324, 502);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Puzzle";
            this.Text = "Puzzle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Puzzle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picPuzzle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSamplePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.PictureBox picPuzzle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbSamplePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNext;
    }
}

