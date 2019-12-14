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
        //backing fields needed for displaying data
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
            get { return won; }
            set { won = value; }
        }

        //loads the screen and sets form details
        //loads database
        private void Endscreen_Load(object sender, EventArgs e)
        {
            this.playerTableAdapter.Fill(this.leaderboardDBDataSet1.Player);
            scoreLbl.Text = score.ToString();
            if (won == true)
            {
                gameOverLbl.Text = "You beat the game!";
            }
        }

        //go back to main menu
        private void exitBtn_Click(object sender, EventArgs e)
        {
            var s = new Startscreen();
            s.Show();
            this.Hide();
        }

        //updates the database with user supplied fields
        //then loads start screen
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