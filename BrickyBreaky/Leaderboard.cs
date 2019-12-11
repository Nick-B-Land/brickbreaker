using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BrickyBreaky
{
    public partial class Leaderboard : Form
    {
        LeaderboardDBDataSet db = new LeaderboardDBDataSet();
        string dbConnection;
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void leaderBoardBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaderboardDBDataSet1.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.leaderboardDBDataSet1.Player);
            dbConnection = ConfigurationManager.ConnectionStrings["BrickyBreaky.Properties.Settings.LeaderboardDBConnectionString"].ConnectionString;

            using (SqlConnection myConnection = new SqlConnection(dbConnection))
            using (SqlDataAdapter clientDataAdapter = new SqlDataAdapter("SELECT * FROM Player", myConnection))
            {
                DataTable clientData = new DataTable();

                myConnection.Open();
                clientDataAdapter.Fill(clientData);
                myConnection.Close();
                for (int row = 0; row < clientData.Rows.Count; row++)
                {
                    string name = (string)clientData.Rows[row]["Name"];
                    int score = (int)clientData.Rows[row]["Score"];
                    string message = (string)clientData.Rows[row]["Message"];

                    leaderBoardBox.Items.Add($"Name: {name, -20} Score: {score, -20} Message: {message}");
                }
            }
        }
    }
}
