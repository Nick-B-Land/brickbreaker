namespace BrickyBreaky
{
    partial class Form1
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
            this.board = new System.Windows.Forms.Panel();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.lvlNameLbl = new System.Windows.Forms.Label();
            this.lvlLbl = new System.Windows.Forms.Label();
            this.paddle = new System.Windows.Forms.PictureBox();
            this.scoreNameLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.Controls.Add(this.paddle);
            this.board.Location = new System.Drawing.Point(0, 38);
            this.board.Margin = new System.Windows.Forms.Padding(4);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(1067, 645);
            this.board.TabIndex = 0;
            this.board.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Board_PreviewKeyDown);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(975, 9);
            this.scoreLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(79, 29);
            this.scoreLbl.TabIndex = 5;
            this.scoreLbl.Text = "label1";
            // 
            // lvlNameLbl
            // 
            this.lvlNameLbl.AutoSize = true;
            this.lvlNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNameLbl.Location = new System.Drawing.Point(13, 9);
            this.lvlNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlNameLbl.Name = "lvlNameLbl";
            this.lvlNameLbl.Size = new System.Drawing.Size(83, 29);
            this.lvlNameLbl.TabIndex = 2;
            this.lvlNameLbl.Text = "Level: ";
            this.lvlNameLbl.Click += new System.EventHandler(this.LvlNameLbl_Click);
            // 
            // lvlLbl
            // 
            this.lvlLbl.AutoSize = true;
            this.lvlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlLbl.Location = new System.Drawing.Point(104, 9);
            this.lvlLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlLbl.Name = "lvlLbl";
            this.lvlLbl.Size = new System.Drawing.Size(79, 29);
            this.lvlLbl.TabIndex = 4;
            this.lvlLbl.Text = "label1";
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paddle.Location = new System.Drawing.Point(406, 594);
            this.paddle.Margin = new System.Windows.Forms.Padding(4);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(187, 25);
            this.paddle.TabIndex = 0;
            this.paddle.TabStop = false;
            // 
            // scoreNameLbl
            // 
            this.scoreNameLbl.AutoSize = true;
            this.scoreNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreNameLbl.Location = new System.Drawing.Point(878, 9);
            this.scoreNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreNameLbl.Name = "scoreNameLbl";
            this.scoreNameLbl.Size = new System.Drawing.Size(89, 29);
            this.scoreNameLbl.TabIndex = 3;
            this.scoreNameLbl.Text = "Score: ";
            this.scoreNameLbl.Click += new System.EventHandler(this.scoreNameLbl_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 683);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.board);
            this.Controls.Add(this.lvlLbl);
            this.Controls.Add(this.scoreNameLbl);
            this.Controls.Add(this.lvlNameLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bricky Breaky";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.board.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label lvlLbl;
        private System.Windows.Forms.Label scoreNameLbl;
        private System.Windows.Forms.Label lvlNameLbl;
    }
}

