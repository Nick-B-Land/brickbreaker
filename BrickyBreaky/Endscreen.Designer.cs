namespace BrickyBreaky
{
    partial class Endscreen
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
            this.gameOverLbl = new System.Windows.Forms.Label();
            this.gameOverTxtLbl = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.commentLbl = new System.Windows.Forms.Label();
            this.commentTxtBx = new System.Windows.Forms.RichTextBox();
            this.scoreNameLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.endScreenDB = new System.Windows.Forms.BindingSource(this.components);
            this.leaderboardDBDataSet1 = new BrickyBreaky.LeaderboardDBDataSet1();
            this.playerTableAdapter = new BrickyBreaky.LeaderboardDBDataSet1TableAdapters.PlayerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.endScreenDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.AutoSize = true;
            this.gameOverLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLbl.Location = new System.Drawing.Point(322, 17);
            this.gameOverLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(423, 79);
            this.gameOverLbl.TabIndex = 0;
            this.gameOverLbl.Text = "Game Over!";
            // 
            // gameOverTxtLbl
            // 
            this.gameOverTxtLbl.AutoSize = true;
            this.gameOverTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverTxtLbl.Location = new System.Drawing.Point(68, 254);
            this.gameOverTxtLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gameOverTxtLbl.Name = "gameOverTxtLbl";
            this.gameOverTxtLbl.Size = new System.Drawing.Size(963, 44);
            this.gameOverTxtLbl.TabIndex = 1;
            this.gameOverTxtLbl.Text = "If you would like to save your score, fill out the following!";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(410, 390);
            this.nameTxtBx.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(342, 31);
            this.nameTxtBx.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(216, 396);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(149, 25);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Enter a Name:";
            // 
            // commentLbl
            // 
            this.commentLbl.AutoSize = true;
            this.commentLbl.Location = new System.Drawing.Point(184, 537);
            this.commentLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.commentLbl.Name = "commentLbl";
            this.commentLbl.Size = new System.Drawing.Size(184, 25);
            this.commentLbl.TabIndex = 5;
            this.commentLbl.Text = "Enter a Comment:";
            // 
            // commentTxtBx
            // 
            this.commentTxtBx.Location = new System.Drawing.Point(410, 531);
            this.commentTxtBx.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.commentTxtBx.Name = "commentTxtBx";
            this.commentTxtBx.Size = new System.Drawing.Size(342, 183);
            this.commentTxtBx.TabIndex = 6;
            this.commentTxtBx.Text = "";
            // 
            // scoreNameLbl
            // 
            this.scoreNameLbl.AutoSize = true;
            this.scoreNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreNameLbl.Location = new System.Drawing.Point(328, 160);
            this.scoreNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.scoreNameLbl.Name = "scoreNameLbl";
            this.scoreNameLbl.Size = new System.Drawing.Size(223, 44);
            this.scoreNameLbl.TabIndex = 7;
            this.scoreNameLbl.Text = "Final Score:";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(562, 131);
            this.scoreLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(222, 79);
            this.scoreLbl.TabIndex = 8;
            this.scoreLbl.Text = "label1";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(24, 752);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(176, 121);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Save Score!";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(912, 752);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(176, 121);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Main Menu";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // endScreenDB
            // 
            this.endScreenDB.DataMember = "Player";
            this.endScreenDB.DataSource = this.leaderboardDBDataSet1;
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
            // Endscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 896);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.scoreNameLbl);
            this.Controls.Add(this.commentTxtBx);
            this.Controls.Add(this.commentLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.gameOverTxtLbl);
            this.Controls.Add(this.gameOverLbl);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Endscreen";
            this.Text = "Endscreen";
            this.Load += new System.EventHandler(this.Endscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.endScreenDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.Label gameOverTxtLbl;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label commentLbl;
        private System.Windows.Forms.RichTextBox commentTxtBx;
        private System.Windows.Forms.Label scoreNameLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.BindingSource endScreenDB;
        private LeaderboardDBDataSet1 leaderboardDBDataSet1;
        private LeaderboardDBDataSet1TableAdapters.PlayerTableAdapter playerTableAdapter;
    }
}