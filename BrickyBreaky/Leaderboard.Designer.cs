namespace BrickyBreaky
{
    partial class Leaderboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.leaderBoardBox = new System.Windows.Forms.ListBox();
            this.leaderboardDS = new System.Windows.Forms.BindingSource(this.components);
            this.leaderboardDBDataSet1 = new BrickyBreaky.LeaderboardDBDataSet1();
            this.playerTableAdapter = new BrickyBreaky.LeaderboardDBDataSet1TableAdapters.PlayerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // leaderBoardBox
            // 
            this.leaderBoardBox.FormattingEnabled = true;
            this.leaderBoardBox.Location = new System.Drawing.Point(12, 12);
            this.leaderBoardBox.Name = "leaderBoardBox";
            this.leaderBoardBox.Size = new System.Drawing.Size(776, 329);
            this.leaderBoardBox.TabIndex = 0;
            this.leaderBoardBox.SelectedIndexChanged += new System.EventHandler(this.leaderBoardBox_SelectedIndexChanged);
            // 
            // leaderboardDS
            // 
            this.leaderboardDS.DataMember = "Player";
            this.leaderboardDS.DataSource = this.leaderboardDBDataSet1;
            // 
            // leaderboardDBDataSet1
            // 
            this.leaderboardDBDataSet1.DataSetName = "LeaderboardDBDataSet1";
            this.leaderboardDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leaderBoardBox);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox leaderBoardBox;
        private System.Windows.Forms.BindingSource leaderboardDS;
        private LeaderboardDBDataSet1 leaderboardDBDataSet1;
        private LeaderboardDBDataSet1TableAdapters.PlayerTableAdapter playerTableAdapter;
    }
}