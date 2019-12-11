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
    public partial class Startscreen : Form
    {
        public Startscreen()
        {            
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {            
            var startGame = new Form1();
            startGame.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            var leaderboard = new Leaderboard();
            leaderboard.Show();
        }
    }
}
