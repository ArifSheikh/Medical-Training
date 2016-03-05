using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Medical_Training_Center
{
    public partial class Puzzle : Form
    {
        public Puzzle(string Title, string Image)
        {
            InitializeComponent();
            strTitle = Title;
            strImage = Image;
            objQuestion = new QuestionVO();
            ImagesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
        }

        private string strTitle = string.Empty;
        private string strImage = string.Empty;
        QuestionVO objQuestion;
        string ImagesDirectory = string.Empty;


        // The current full picture.
        private Bitmap FullPicture = null;

        // The board's background.
        private Bitmap Background = null;

        // The board.
        private Bitmap Board = null;

        // The pieces.
        private List<Piece> Pieces = null;

        // The target size. (Initially easy.)
        private int TargetSize = 300;

        // The number and size of the rows and columns.
        private int NumRows, NumCols, RowHgt, ColWid;

        // The piece the user is moving.
        private Piece MovingPiece = null;
        private Point MovingPoint;

        // True when the game is over.
        private bool GameOver = true;

        // Load this file.
        public void LoadPicture()
        {
            try
            {

                pbSamplePicture.Image = Image.FromFile(strImage);

                // Load the picture.
                using (Bitmap bm = new Bitmap(strImage))
                {
                    FullPicture = new Bitmap(bm.Width, bm.Height);
                    using (Graphics gr = Graphics.FromImage(FullPicture))
                    {
                        gr.DrawImage(bm, 0, 0, bm.Width, bm.Height);
                    }
                }

                // Make the Board and background bitmaps.
                Background = new Bitmap(FullPicture.Width, FullPicture.Height);
                Board = new Bitmap(FullPicture.Width, FullPicture.Height);
                picPuzzle.Width = FullPicture.Size.Width - 220;
                picPuzzle.Height = FullPicture.Size.Height - 220;

                panel1.Height = picPuzzle.Height + 300;
                picPuzzle.Image = Board;
                this.ClientSize = new Size(
                    picPuzzle.Right + picPuzzle.Left,
                    picPuzzle.Bottom + picPuzzle.Left);

                // Start a new game.
                StartGame();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Start a new game.
        private void StartGame()
        {
            if (FullPicture == null) return;
            GameOver = false;

            // Figure out how big the pieces should be.
            NumRows = FullPicture.Height / TargetSize;
            RowHgt = FullPicture.Height / NumRows;
            NumCols = FullPicture.Width / TargetSize;
            ColWid = FullPicture.Width / NumCols;

            // Make the pieces.
            Random rand = new Random();
            Pieces = new List<Piece>();
            for (int row = 0; row < NumRows; row++)
            {
                int hgt = RowHgt;
                if (row == NumRows - 1) hgt = FullPicture.Height - row * RowHgt;
                for (int col = 0; col < NumCols; col++)
                {
                    int wid = ColWid;
                    if (col == NumCols - 1) wid = FullPicture.Width - col * ColWid;

                    Rectangle rect = new Rectangle(col * ColWid, row * RowHgt, wid, hgt);
                    Piece new_piece = new Piece(FullPicture, rect);

                    // Randomize the initial location.
                    new_piece.CurrentLocation = new Rectangle(
                        rand.Next(0, FullPicture.Width - wid),
                        rand.Next(0, FullPicture.Height - hgt),
                        wid, hgt);

                    // Add to the Pieces collection.
                    Pieces.Add(new_piece);
                }
            }

            // Make the background.
            MakeBackground();

            // Draw the board.
            DrawBoard();
        }

        // Make the background image without MovingPiece.
        private void MakeBackground()
        {
            using (Graphics gr = Graphics.FromImage(Background))
            {
                gr.Clear(picPuzzle.BackColor);

                // Draw a grid on the background.
                DrawGrid(gr);

                // Draw the pieces.
                DrawPieces(gr);
            }

            picPuzzle.Visible = true;
            picPuzzle.Refresh();
        }

        // Draw a grid on the background.
        private void DrawGrid(Graphics gr)
        {
            using (Pen thick_pen = new Pen(Color.DarkGray, 4))
            {
                for (int y = 0; y <= FullPicture.Height; y += RowHgt)
                {
                    gr.DrawLine(thick_pen, 0, y, FullPicture.Width, y);
                }
                gr.DrawLine(thick_pen, 0, FullPicture.Height, FullPicture.Width, FullPicture.Height);

                for (int x = 0; x <= FullPicture.Width; x += ColWid)
                {
                    gr.DrawLine(thick_pen, x, 0, x, FullPicture.Height);
                }
                gr.DrawLine(thick_pen, FullPicture.Width, 0, FullPicture.Width, FullPicture.Height);
            }
        }

        // Draw the pieces.
        private void DrawPieces(Graphics gr)
        {
            using (Pen white_pen = new Pen(Color.White, 3))
            {
                using (Pen black_pen = new Pen(Color.Black, 3))
                {
                    foreach (Piece piece in Pieces)
                    {
                        // Don't draw the piece we are moving.
                        if (piece != MovingPiece)
                        {
                            gr.DrawImage(FullPicture,
                                piece.CurrentLocation,
                                piece.HomeLocation,
                                GraphicsUnit.Pixel);
                            if (!GameOver)
                            {
                                if (piece.IsHome())
                                {
                                    // Draw locked pieces with a white border.
                                    gr.DrawRectangle(white_pen, piece.CurrentLocation);
                                }
                                else
                                {
                                    // Draw locked pieces with a black border.
                                    gr.DrawRectangle(black_pen, piece.CurrentLocation);
                                }
                            }
                        }
                    }
                }
            }
        }

        // Draw the board.
        private void DrawBoard()
        {
            using (Graphics gr = Graphics.FromImage(Board))
            {
                // Restore the background.
                gr.DrawImage(Background, 0, 0, Background.Width, Background.Height);

                // Draw MovingPiece.
                if (MovingPiece != null)
                {
                    gr.DrawImage(FullPicture,
                        MovingPiece.CurrentLocation,
                        MovingPiece.HomeLocation,
                        GraphicsUnit.Pixel);

                    using (Pen blue_pen = new Pen(Color.Blue, 12))
                    {
                        gr.DrawRectangle(blue_pen, MovingPiece.CurrentLocation);
                    }
                }
            }

            picPuzzle.Visible = true;
            picPuzzle.Refresh();
        }

        // Start moving a piece.
        private void picPuzzle_MouseDown(object sender, MouseEventArgs e)
        {
            // See which piece contains this point.
            // Skip fixed pieces.
            // Keep the last one because it's on the top.
            MovingPiece = null;
            foreach (Piece piece in Pieces)
            {
                if (!piece.IsHome() && piece.Contains(e.Location))
                    MovingPiece = piece;
            }
            if (MovingPiece == null) return;

            // Save this location.
            MovingPoint = e.Location;

            // Move it to the top of the stack.
            Pieces.Remove(MovingPiece);
            Pieces.Add(MovingPiece);

            // Redraw.
            MakeBackground();
            DrawBoard();
        }

        // Move the selected piece.
        private void picPuzzle_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingPiece == null) return;

            // Move the piece.
            int dx = e.X - MovingPoint.X;
            int dy = e.Y - MovingPoint.Y;
            MovingPiece.CurrentLocation.X += dx;
            MovingPiece.CurrentLocation.Y += dy;

            // Save the new mouse location.
            MovingPoint = e.Location;

            // Redraw.
            DrawBoard();
        }

        // Stop moving the piece and see if it is where it belongs.
        private void picPuzzle_MouseUp(object sender, MouseEventArgs e)
        {
            if (MovingPiece == null) return;

            // See if the piece is in its home position.
            if (MovingPiece.SnapToHome())
            {
                // Move the piece to the bottom.
                Pieces.Remove(MovingPiece);
                Pieces.Reverse();
                Pieces.Add(MovingPiece);
                Pieces.Reverse();

                // See if the game is over.
                GameOver = true;
                foreach (Piece piece in Pieces)
                {
                    if (!piece.IsHome())
                    {
                        GameOver = false;
                        break;
                    }
                }
                if (GameOver)
                {
                    MessageBox.Show("Well Done !");
                }
            }

            // Stop moving the piece.
            MovingPiece = null;

            // Redraw.
            MakeBackground();
            DrawBoard();
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {
            pbSamplePicture.Image = Image.FromFile(strImage);
            LoadPicture();

            //for 4 - resolution : 863 x 655
            //for 6 - 1024 x 768
            //for 8 - 1200x1000
        }

        private void picPuzzle_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPicture();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Puzzle_Load_1(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GlobalData.CurrentQuestionID++;
            objQuestion.QuestionID = GlobalData.CurrentQuestionID;

            if (GlobalData.dtQuestionData.Rows[GlobalData.CurrentQuestionID][0] != null)
            {
                objQuestion.QuestionType = Convert.ToString(GlobalData.dtQuestionData.Rows[GlobalData.CurrentQuestionID][1]);
                objQuestion.QuestionTitle = Convert.ToString(GlobalData.dtQuestionData.Rows[GlobalData.CurrentQuestionID][2]);
                objQuestion.QuestionName = Convert.ToString(GlobalData.dtQuestionData.Rows[GlobalData.CurrentQuestionID][3]).Split('~');
            }
            if (objQuestion.QuestionType.Equals("P"))
            {
                strTitle = objQuestion.QuestionTitle;
                strImage = ImagesDirectory + @"\" + objQuestion.QuestionName[0] + ".jpg";
                LoadPicture();
            }
            else
            {
                //Except puzzle
            }
        }
    }
}
