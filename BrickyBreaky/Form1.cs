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

            this.FormBorderStyle = FormBorderStyle.None; //removes border
            this.TopMost = true; // brings the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;
            paddle.Top = board.Bottom - (board.Bottom / 10); // setting the position of the paddle
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Board_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            paddle.Left = Cursor.Position.X - (paddle.Width / 2);

            ball.Left += speedX;
            ball.Top += speedY;

            if(ball.Bottom >= paddle.Top && ball.Bottom <= paddle.Bottom && ball.Left >= paddle.Left && ball.Right <= paddle.Right)
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
