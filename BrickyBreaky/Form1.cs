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

        public List<PictureBox> CurrentBricks = new List<PictureBox>();

        // speed for ball
        public int speedX = 4;

        public int speedY = 4;

        // points counter
        public int points = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            //this.FormBorderStyle = FormBorderStyle.None; //removes border
            //this.TopMost = true; // brings the form to the front
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            paddle.Top = board.Bottom - (board.Bottom / 10); // setting the position of the paddle
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (level == 1)
            {
                for (int i = 0; i < 10; ++i)
                {
                    if (i == 0)
                    {
                        PictureBox brick0 = new PictureBox();
                        brick0.BackColor = Color.Gray;
                        brick0.Location = new Point(100, 50);
                        CurrentBricks.Add(brick0);
                        board.Controls.Add(brick0);
                    }
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
                    board.Controls.Remove(b);
                    speedX = -speedX;
                    speedY = -speedY;
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            BrickDelete();
            paddle.Left = Cursor.Position.X - (paddle.Width / 2);

            ball.Left += speedX;
            ball.Top += speedY;

            //if (ball.Bottom >= paddle.Top && ball.Bottom <= paddle.Bottom && ball.Left >= paddle.Left && ball.Right <= paddle.Right)
            //{
            //speedY += 2;
            //speedX += 2;

            //speedY = -speedY;
            //points += 1;
            //}
            if (ball.Bounds.IntersectsWith(paddle.Bounds))
            {
                speedY += 2;
                speedX += 2;

                speedY = -speedY;
                points += 1;
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
            if (ball.Bottom >= board.Bottom)
            {
                timer1.Enabled = false; // stop the game
            }
        }
    }
}