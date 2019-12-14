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
        //level of the game
        public int level = 1;

        //main "ball" object
        public PictureBox ball = new PictureBox();

        //list to track the current bricks
        public List<PictureBox> CurrentBricks = new List<PictureBox>();

        //speed for ball
        public int speedX = 7;

        public int speedY = 7;

        //tracks score
        public int points = 0;

        public int Level { get; set; }

        public int Points { get; set; }

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sets ball size and location and adds it to the board
            Size tBall = ball.Size;
            tBall.Width = 25;
            tBall.Height = 25;
            ball.Size = tBall;
            ball.BackColor = Color.Red;
            ball.Location = new Point(190, 350);
            board.Controls.Add(ball);
            lvlLbl.Text = level.ToString();
            scoreLbl.Text = points.ToString();

            //starting points for bricks to render at (x values)
            int startPoint = 130;
            int start2 = 130;
            int start3 = 130;
            int start4 = 130;
            int start5 = 130;
            int start6 = 130;

            //renders the bricks based on the level
            //render in stacking rows as the level increases
            for (int i = 1; i <= level * 5; ++i)
            {
                if (i <= 10)
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
                else if (i > 10 && i <= 20)
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
                else if (i > 20 && i <= 30)
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
                else if (i > 30 && i <= 40)
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
                else if (i > 40 && i <= 50)
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
                else if (i > 50 && i <= 60)
                {
                    PictureBox brick = new PictureBox();
                    brick.BackColor = Color.Gray;
                    brick.Location = new Point(start6, 302);
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

        //function that checks if a brick should be deleted or not
        //updates currentBricks if so
        public void BrickDelete()
        {
            foreach (var b in CurrentBricks)
            {
                if (b.Bounds.IntersectsWith(ball.Bounds))
                {
                    CurrentBricks.Remove(b);
                    board.Controls.Remove(b);
                    speedY = -speedY;
                    points += 10;
                    scoreLbl.Text = points.ToString();
                    LevelComplete();
                    break;
                }
            }
        }

        //function to check if level is complete
        //loads a new level if it is
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

        //function to load the end game screen
        public void EndGame()
        {
            Endscreen e = new Endscreen();
            e.score = points;
            e.Show();
            this.Close();
        }

        //tick timer for moving ball and updating speed
        //also where functions are called, serves as the event to trigger them
        private void Timer1_Tick(object sender, EventArgs e)
        {
            BrickDelete();

            ball.Left += speedX;
            ball.Top += speedY;

            //check if ball has it paddle, and then update ball speed/direction
            //this part can be potentially a little buggy
            //couldn't figure out why, works 95% of the time though
            if (ball.Bounds.IntersectsWith(paddle.Bounds))
            {
                int paddleMiddle = paddle.Width / 2;
                if (speedX > 20 || speedX < -20)
                {
                    speedX = 8;
                    speedY = 8;
                }

                if (ball.Location.X < paddle.Location.X + (paddleMiddle + 25))
                {
                    speedY += 1;
                    speedX += 3;
                    speedY = -speedY;
                }
                else if (ball.Location.X > paddle.Location.X + (paddleMiddle - 25))
                {
                    speedY += 1;
                    speedX += 3;
                    speedY = -speedY;
                }
                else
                {
                    speedY += 1;
                    speedX += 1;
                    speedY = -speedY;
                }
            }

            //bounds checking to reverse ball direction
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

            if (ball.Location.Y >= 500)
            {
                timer1.Enabled = false; // stop the game
                EndGame();
            }
        }

        //bind left and right keys to moving the paddle
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (paddle.Left > board.Left)
                    {
                        paddle.Left = paddle.Left - 65;
                    }
                    break;

                case Keys.Right:
                    if (paddle.Right < board.Right)
                    {
                        paddle.Left = paddle.Left + 65;
                    }
                    break;
            }
        }
    }
}