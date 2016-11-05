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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGraveyard = new System.Windows.Forms.Label();
            this.lblChancesText = new System.Windows.Forms.Label();
            this.lblChancesNum = new System.Windows.Forms.Label();
            this.pnlGuess.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGuessDisplay
            // 
            this.lblGuessDisplay.AutoSize = true;
            this.lblGuessDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessDisplay.Location = new System.Drawing.Point(132, 210);
            this.lblGuessDisplay.Name = "lblGuessDisplay";
            this.lblGuessDisplay.Size = new System.Drawing.Size(283, 26);
            this.lblGuessDisplay.TabIndex = 0;
            this.lblGuessDisplay.Text = "Click start to start the game.";
            this.lblGuessDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 7);
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
            this.txtGuess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGuess_KeyDown);
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
            this.pnlGuess.Location = new System.Drawing.Point(197, 312);
            this.pnlGuess.Name = "pnlGuess";
            this.pnlGuess.Size = new System.Drawing.Size(168, 30);
            this.pnlGuess.TabIndex = 4;
            this.pnlGuess.Visible = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(3, 7);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "Restart Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(84, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit Game";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Location = new System.Drawing.Point(197, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 33);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Guessed Letters";
            // 
            // lblGraveyard
            // 
            this.lblGraveyard.AutoSize = true;
            this.lblGraveyard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraveyard.Location = new System.Drawing.Point(430, 66);
            this.lblGraveyard.Name = "lblGraveyard";
            this.lblGraveyard.Size = new System.Drawing.Size(59, 20);
            this.lblGraveyard.TabIndex = 10;
            this.lblGraveyard.Tag = "Letters";
            this.lblGraveyard.Text = "Letters";
            // 
            // lblChancesText
            // 
            this.lblChancesText.AutoSize = true;
            this.lblChancesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChancesText.Location = new System.Drawing.Point(22, 44);
            this.lblChancesText.Name = "lblChancesText";
            this.lblChancesText.Size = new System.Drawing.Size(103, 25);
            this.lblChancesText.TabIndex = 11;
            this.lblChancesText.Text = "Chances:";
            // 
            // lblChancesNum
            // 
            this.lblChancesNum.AutoSize = true;
            this.lblChancesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChancesNum.Location = new System.Drawing.Point(131, 40);
            this.lblChancesNum.Name = "lblChancesNum";
            this.lblChancesNum.Size = new System.Drawing.Size(30, 31);
            this.lblChancesNum.TabIndex = 12;
            this.lblChancesNum.Text = "∞";
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 409);
            this.Controls.Add(this.lblChancesNum);
            this.Controls.Add(this.lblChancesText);
            this.Controls.Add(this.lblGraveyard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGuess);
            this.Controls.Add(this.lblGuessDisplay);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Hangman_Load);
            this.pnlGuess.ResumeLayout(false);
            this.pnlGuess.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessDisplay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGuess;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGraveyard;
        private System.Windows.Forms.Label lblChancesText;
        private System.Windows.Forms.Label lblChancesNum;
    }
}

