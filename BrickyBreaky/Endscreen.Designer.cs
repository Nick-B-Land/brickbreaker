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
            this.SuspendLayout();
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.AutoSize = true;
            this.gameOverLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLbl.Location = new System.Drawing.Point(161, 9);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(217, 39);
            this.gameOverLbl.TabIndex = 0;
            this.gameOverLbl.Text = "Game Over!";
            // 
            // gameOverTxtLbl
            // 
            this.gameOverTxtLbl.AutoSize = true;
            this.gameOverTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverTxtLbl.Location = new System.Drawing.Point(34, 132);
            this.gameOverTxtLbl.Name = "gameOverTxtLbl";
            this.gameOverTxtLbl.Size = new System.Drawing.Size(473, 24);
            this.gameOverTxtLbl.TabIndex = 1;
            this.gameOverTxtLbl.Text = "If you would like to save your score, fill out the following!";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(205, 203);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(173, 20);
            this.nameTxtBx.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(108, 206);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(75, 13);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Enter a Name:";
            // 
            // commentLbl
            // 
            this.commentLbl.AutoSize = true;
            this.commentLbl.Location = new System.Drawing.Point(92, 279);
            this.commentLbl.Name = "commentLbl";
            this.commentLbl.Size = new System.Drawing.Size(91, 13);
            this.commentLbl.TabIndex = 5;
            this.commentLbl.Text = "Enter a Comment:";
            // 
            // commentTxtBx
            // 
            this.commentTxtBx.Location = new System.Drawing.Point(205, 276);
            this.commentTxtBx.Name = "commentTxtBx";
            this.commentTxtBx.Size = new System.Drawing.Size(173, 97);
            this.commentTxtBx.TabIndex = 6;
            this.commentTxtBx.Text = "";
            // 
            // scoreNameLbl
            // 
            this.scoreNameLbl.AutoSize = true;
            this.scoreNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreNameLbl.Location = new System.Drawing.Point(164, 83);
            this.scoreNameLbl.Name = "scoreNameLbl";
            this.scoreNameLbl.Size = new System.Drawing.Size(111, 24);
            this.scoreNameLbl.TabIndex = 7;
            this.scoreNameLbl.Text = "Final Score:";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(281, 68);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(109, 39);
            this.scoreLbl.TabIndex = 8;
            this.scoreLbl.Text = "label1";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(12, 391);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(88, 63);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Save Score!";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(456, 391);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 63);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Main Menu";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Endscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 466);
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
            this.Name = "Endscreen";
            this.Text = "Endscreen";
            this.Load += new System.EventHandler(this.Endscreen_Load);
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
    }
}