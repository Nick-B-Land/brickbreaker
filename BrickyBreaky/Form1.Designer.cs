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
            this.ball = new System.Windows.Forms.PictureBox();
            this.lvlLbl = new System.Windows.Forms.Label();
            this.paddle = new System.Windows.Forms.PictureBox();
            this.scoreNameLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.Controls.Add(this.scoreLbl);
            this.board.Controls.Add(this.lvlNameLbl);
            this.board.Controls.Add(this.ball);
            this.board.Controls.Add(this.lvlLbl);
            this.board.Controls.Add(this.paddle);
            this.board.Controls.Add(this.scoreNameLbl);
            this.board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.board.Location = new System.Drawing.Point(0, 0);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(800, 504);
            this.board.TabIndex = 0;
            this.board.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Board_PreviewKeyDown);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(737, 9);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(60, 24);
            this.scoreLbl.TabIndex = 5;
            this.scoreLbl.Text = "label1";
            // 
            // lvlNameLbl
            // 
            this.lvlNameLbl.AutoSize = true;
            this.lvlNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNameLbl.Location = new System.Drawing.Point(3, 9);
            this.lvlNameLbl.Name = "lvlNameLbl";
            this.lvlNameLbl.Size = new System.Drawing.Size(65, 24);
            this.lvlNameLbl.TabIndex = 2;
            this.lvlNameLbl.Text = "Level: ";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(222, 282);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // lvlLbl
            // 
            this.lvlLbl.AutoSize = true;
            this.lvlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlLbl.Location = new System.Drawing.Point(74, 9);
            this.lvlLbl.Name = "lvlLbl";
            this.lvlLbl.Size = new System.Drawing.Size(60, 24);
            this.lvlLbl.TabIndex = 4;
            this.lvlLbl.Text = "label1";
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paddle.Location = new System.Drawing.Point(303, 472);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(140, 20);
            this.paddle.TabIndex = 0;
            this.paddle.TabStop = false;
            // 
            // scoreNameLbl
            // 
            this.scoreNameLbl.AutoSize = true;
            this.scoreNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreNameLbl.Location = new System.Drawing.Point(661, 9);
            this.scoreNameLbl.Name = "scoreNameLbl";
            this.scoreNameLbl.Size = new System.Drawing.Size(70, 24);
            this.scoreNameLbl.TabIndex = 3;
            this.scoreNameLbl.Text = "Score: ";
            this.scoreNameLbl.Click += new System.EventHandler(this.scoreNameLbl_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.board);
            this.Name = "Form1";
            this.Text = "Bricky Breaky";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.board.ResumeLayout(false);
            this.board.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label lvlLbl;
        private System.Windows.Forms.Label scoreNameLbl;
        private System.Windows.Forms.Label lvlNameLbl;
    }
}

