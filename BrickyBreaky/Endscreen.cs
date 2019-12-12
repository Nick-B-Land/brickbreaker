using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        public bool won;
        private LeaderboardDBDataSet db = new LeaderboardDBDataSet();
        private string dbConnection;

        public Endscreen()
        {
            InitializeComponent();
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public bool beatGame
        {
            get { return beatGame; }
            set { beatGame = value; }
        }

        private void Endscreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaderboardDBDataSet1.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.leaderboardDBDataSet1.Player);
            scoreLbl.Text = score.ToString();
            if (won == true)
            {
                gameOverLbl.Text = "You beat the game!";
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var s = new Startscreen();
            s.Show();
            this.Hide();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var name = nameTxtBx.Text;
            var message = commentTxtBx.Text;
            string insertLeader = "INSERT into Player (Name,Message,Score) " +
                   " VALUES ('" + name + "', '" + message + "', '" + score + "')";
            dbConnection = ConfigurationManager.ConnectionStrings["BrickyBreaky.Properties.Settings.LeaderboardDBConnectionString"].ConnectionString;

            using (SqlConnection myConnection = new SqlConnection(dbConnection))
            {
                using (SqlCommand s = new SqlCommand(insertLeader))
                {
                    s.Connection = myConnection;
                    myConnection.Open();
                    s.ExecuteNonQuery();
                    myConnection.Close();
                }
            }
            Startscreen start = new Startscreen();
            start.Show();
            this.Close();
        }
    }
}