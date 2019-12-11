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
            this.backToMainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // leaderBoardBox
            // 
            this.leaderBoardBox.FormattingEnabled = true;
            this.leaderBoardBox.ItemHeight = 25;
            this.leaderBoardBox.Location = new System.Drawing.Point(24, 23);
            this.leaderBoardBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.leaderBoardBox.Name = "leaderBoardBox";
            this.leaderBoardBox.Size = new System.Drawing.Size(1548, 629);
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
            // backToMainButton
            // 
            this.backToMainButton.Location = new System.Drawing.Point(512, 706);
            this.backToMainButton.Name = "backToMainButton";
            this.backToMainButton.Size = new System.Drawing.Size(519, 113);
            this.backToMainButton.TabIndex = 1;
            this.backToMainButton.Text = "Back To Main Menu";
            this.backToMainButton.UseVisualStyleBackColor = true;
            this.backToMainButton.Click += new System.EventHandler(this.backToMainButton_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.backToMainButton);
            this.Controls.Add(this.leaderBoardBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Button backToMainButton;
    }
}