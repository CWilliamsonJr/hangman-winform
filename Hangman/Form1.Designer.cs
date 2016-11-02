namespace Hangman
{
    partial class Hangman
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
            this.lblGuessDisplay = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGuess = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGuessDisplay
            // 
            this.lblGuessDisplay.AutoSize = true;
            this.lblGuessDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessDisplay.Location = new System.Drawing.Point(102, 202);
            this.lblGuessDisplay.Name = "lblGuessDisplay";
            this.lblGuessDisplay.Size = new System.Drawing.Size(283, 26);
            this.lblGuessDisplay.TabIndex = 0;
            this.lblGuessDisplay.Text = "Click start to start the game.";
            this.lblGuessDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(193, 374);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(122, 7);
            this.txtGuess.MaxLength = 1;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(33, 20);
            this.txtGuess.TabIndex = 2;
            this.txtGuess.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGuess_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter in your guess:";
            // 
            // pnlGuess
            // 
            this.pnlGuess.Controls.Add(this.label1);
            this.pnlGuess.Controls.Add(this.txtGuess);
            this.pnlGuess.Location = new System.Drawing.Point(143, 313);
            this.pnlGuess.Name = "pnlGuess";
            this.pnlGuess.Size = new System.Drawing.Size(168, 30);
            this.pnlGuess.TabIndex = 4;
            this.pnlGuess.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(297, 374);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(402, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit Game";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 409);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlGuess);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGuessDisplay);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.pnlGuess.ResumeLayout(false);
            this.pnlGuess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessDisplay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnClose;
    }
}

