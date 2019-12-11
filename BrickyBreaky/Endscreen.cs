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
    public partial class Endscreen : Form
    {
        public int score;

        public Endscreen()
        {
            InitializeComponent();
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        private void Endscreen_Load(object sender, EventArgs e)
        {
            scoreLbl.Text = score.ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var s = new Startscreen();
            s.Show();
            this.Hide();
        }
    }
}