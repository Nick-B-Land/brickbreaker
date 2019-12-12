using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickyBreaky
{
    public partial class Form1 : Form
    {
        private int level = 1;
        public PictureBox ball = new PictureBox();

        public List<PictureBox> CurrentBricks = new List<PictureBox>();

        // speed for ball
        public int speedX = 10;

        public int speedY = 10;

        // points counter
        public int points = 0;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            //Cursor.Hide();

            //this.FormBorderStyle = FormBorderStyle.None; //removes border
            //this.TopMost = true; // brings the form to the front
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            //paddle.Top = board.Bottom - (board.Bottom / 10); // setting the position of the paddle
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size tBall = ball.Size;
            tBall.Width = 25;
            tBall.Height = 25;
            ball.Size = tBall;
            ball.BackColor = Color.Red;
            ball.Location = new Point(190, 350);
            board.Controls.Add(ball);
            lvlLbl.Text = level.ToString();
            scoreLbl.Text = points.ToString();
            //speedX = level * 2;
            //speedY = level * 2;

            int startPoint = 150;
            int start2 = 150;
            int start3 = 150;
            int start4 = 150;
            int start5 = 150;
            int start6 = 150;
            for (int i = 1; i <= level * 5; ++i)
            {
                if (i < 10)
                {
                    PictureBox brick = new PictureBox();
                    brick.BackColor = Color.Gray;
                    brick.Location = new Point(startPoint, 50);
                    Size temp = brick.Size;
                    temp.Width = 50;
                    temp.Height = 25;
                    brick.Size = temp;
                    CurrentBricks.Add(brick);
                    board.Controls.Add(brick);
                    startPoint += temp.Width + 2;
                }
                else if (i > 10 && i < 20)
                {
                    PictureBox brick = new PictureBox();
                    brick.BackColor = Color.Gray;
                    brick.Location = new Point(start2, 102);
                    Size temp = brick.Size;
                    temp.Width = 50;
                    temp.Height = 25;
                    brick.Size = temp;
                    CurrentBricks.Add(brick);
                    board.Controls.Add(brick);
                    start2 += temp.Width + 2;
                }
                else if (i > 20 && i < 30)
                {
                    PictureBox brick = new PictureBox();
                    brick.BackColor = Color.Gray;
                    brick.Location = new Point(start3, 152);
                    Size temp = brick.Size;
                    temp.Width = 50;
                    temp.Height = 25;
                    brick.Size = temp;
                    CurrentBricks.Add(brick);
                    board.Controls.Add(brick);
                    start3 += temp.Width + 2;
                }
                else if (i > 30 && i < 40)
                {
                    PictureBox brick = new PictureBox();
                    brick.BackColor = Color.Gray;
                    brick.Location = new Point(start4, 202);
                    Size temp = brick.Size;
                    temp.Width = 50;
                    temp.Height = 25;
                    brick.Size = temp;
                    CurrentBricks.Add(brick);
                    board.Controls.Add(brick);
                    start4 += temp.Width + 2;
                }
                else if (i > 40 && i < 50)
                {
                    PictureBox brick = new PictureBox();
                    brick.BackColor = Color.Gray;
                    brick.Location = new Point(start5, 252);
                    Size temp = brick.Size;
                    temp.Width = 50;
                    temp.Height = 25;
                    brick.Size = temp;
                    CurrentBricks.Add(brick);
                    board.Controls.Add(brick);
                    start5 += temp.Width + 2;
                }
                else if (i > 50 && i < 60)
                {
                    PictureBox brick = new PictureBox();
                    brick.BackColor = Color.Gray;
                    brick.Location = new Point(start6, 252);
                    Size temp = brick.Size;
                    temp.Width = 50;
                    temp.Height = 25;
                    brick.Size = temp;
                    CurrentBricks.Add(brick);
                    board.Controls.Add(brick);
                    start6 += temp.Width + 2;
                }
            }
        }

        private void Board_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void BrickDelete()
        {
            foreach (var b in CurrentBricks)
            {
                if (b.Bounds.IntersectsWith(ball.Bounds))
                {
                    CurrentBricks.Remove(b);
                    board.Controls.Remove(b);
                    //speedX = -speedX;
                    speedY = -speedY;
                    points += 10;
                    scoreLbl.Text = points.ToString();
                    LevelComplete();
                    break;
                }
            }
        }

        public void LevelComplete()
        {
            if (CurrentBricks.Count == 0)
            {
                if (level + 1 == 16)
                {
                    Endscreen e = new Endscreen();
                    e.score = points;
                    e.beatGame = true;
                    e.Show();
                    this.Close();
                    return;
                }
                Form1 f = new Form1();
                f.level = level + 1;
                f.points = points;
                f.Show();
                this.Close();
            }
        }

        public void EndGame()
        {
            Endscreen e = new Endscreen();
            e.score = points;
            e.Show();
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            BrickDelete();

            ball.Left += speedX;
            ball.Top += speedY;

            if (ball.Bounds.IntersectsWith(paddle.Bounds))
            {
                int paddleMiddle = paddle.Width / 2;
                if (speedX >= 20)
                {
                    speedX = 15;
                    speedY = 15;
                }

                if (ball.Location.X < paddle.Location.X + (paddleMiddle + 25))
                {
                    speedY += 1;
                    speedX += 3;
                    speedY = -speedY;
                    speedX = +speedX;
                }
                else if (ball.Location.X > paddle.Location.X + (paddleMiddle - 25))
                {
                    speedY += 1;
                    speedX += 1;
                    speedY = -speedY;
                    speedX = -speedX;
                }
                else
                {
                    speedY += 1;
                    speedX += 1;
                    speedY = -speedY;
                }
                //if (ball.Location.X > paddle.Location.Y)
                //if (ball.Left > paddle.Left)
                //{
                //    speedY += 2;
                //    speedX += 2;

                //    speedY = -speedY;
                //    speedX = -speedX;
                //}

                //if (ball.Location.X < paddle.Location.X)
                //{
                //    speedY += 1;
                //    speedX += 1;

                //    speedY = -speedY;
                //    speedX = -speedX;
                //}
                //else if (ball.Location.X > paddle.Location.X)
                //{
                //    speedY += 1;
                //    speedX += 1;

                //    speedY = -speedY;
                //    speedX = -speedX;
                //}

                //speedY += 1;
                //speedX += 1;
                //speedY = -speedY;

                /*
                if(speedX <= 20)
                {
                    speedX = 20;
                }
                if(speedY <= 20)
                {
                    speedY = 20;
                }
                */
            }
            if (ball.Left <= board.Left)
            {
                speedX = -speedX;
            }
            if (ball.Right >= board.Right)
            {
                speedX = -speedX;
            }
            if (ball.Top <= board.Top)
            {
                speedY = -speedY;
            }

            //if (ball.Top <= 45)
            //{
            //    speedY = -speedY;
            //}

            if (ball.Location.Y >= 550)
            {
                timer1.Enabled = false; // stop the game
                EndGame();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (paddle.Left > board.Left)
                    {
                        paddle.Left = paddle.Left - 50;
                    }
                    break;

                case Keys.Right:
                    if (paddle.Right < board.Right)
                    {
                        paddle.Left = paddle.Left + 50;
                    }
                    break;
            }
        }

        private void scoreNameLbl_Click(object sender, EventArgs e)
        {
        }

        private void LvlNameLbl_Click(object sender, EventArgs e)
        {
        }
    }
}