using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickyBreaky
{
    public partial class Bricks : UserControl
    {
        public PictureBox ball;
        public List<PictureBox> CurrentBricks = new List<PictureBox>();

        public Bricks()
        {
            InitializeComponent();
        }

        public PictureBox ID
        {
            get { return ball; }
            set { ball = value; }
        }

        public void BrickDelete()
        {
            foreach (var b in CurrentBricks)
            {
                if (b.Bounds.IntersectsWith(ball.Bounds))
                {
                    //Bricks
                }
            }
        }

        private void Bricks_Load(object sender, EventArgs e)
        {
            CurrentBricks.Add(brick1);
            CurrentBricks.Add(brick2);
            CurrentBricks.Add(brick3);
            CurrentBricks.Add(brick4);
            CurrentBricks.Add(brick5);
            CurrentBricks.Add(brick6);
            CurrentBricks.Add(brick7);
            CurrentBricks.Add(brick8);
            CurrentBricks.Add(brick9);
            CurrentBricks.Add(brick10);
        }
    }
}