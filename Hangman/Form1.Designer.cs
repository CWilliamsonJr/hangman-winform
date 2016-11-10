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
            this.pnlGameButtons = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGraveyard = new System.Windows.Forms.Label();
            this.lblChancesText = new System.Windows.Forms.Label();
            this.lblChancesNum = new System.Windows.Forms.Label();
            this.picHangman = new System.Windows.Forms.PictureBox();
            this.btnShowList = new System.Windows.Forms.Button();
            this.grpPuzzleSelect = new System.Windows.Forms.GroupBox();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.rbPhrases = new System.Windows.Forms.RadioButton();
            this.rbWords = new System.Windows.Forms.RadioButton();
            this.pnlChances = new System.Windows.Forms.Panel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.cbMultiLetter = new System.Windows.Forms.CheckBox();
            this.pnlGuess.SuspendLayout();
            this.pnlGameButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            this.grpPuzzleSelect.SuspendLayout();
            this.pnlChances.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGuessDisplay
            // 
            this.lblGuessDisplay.AutoSize = true;
            this.lblGuessDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessDisplay.Location = new System.Drawing.Point(3, 3);
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
            this.pnlGuess.AutoSize = true;
            this.pnlGuess.Controls.Add(this.label1);
            this.pnlGuess.Controls.Add(this.txtGuess);
            this.pnlGuess.Location = new System.Drawing.Point(179, 380);
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
            // pnlGameButtons
            // 
            this.pnlGameButtons.Controls.Add(this.btnStart);
            this.pnlGameButtons.Controls.Add(this.btnClose);
            this.pnlGameButtons.Controls.Add(this.btnNewGame);
            this.pnlGameButtons.Location = new System.Drawing.Point(179, 418);
            this.pnlGameButtons.Name = "pnlGameButtons";
            this.pnlGameButtons.Size = new System.Drawing.Size(169, 33);
            this.pnlGameButtons.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Guessed Letters";
            // 
            // lblGraveyard
            // 
            this.lblGraveyard.AutoSize = true;
            this.lblGraveyard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraveyard.Location = new System.Drawing.Point(175, 287);
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
            this.lblChancesText.Location = new System.Drawing.Point(6, 9);
            this.lblChancesText.Name = "lblChancesText";
            this.lblChancesText.Size = new System.Drawing.Size(103, 25);
            this.lblChancesText.TabIndex = 11;
            this.lblChancesText.Text = "Chances:";
            // 
            // lblChancesNum
            // 
            this.lblChancesNum.AutoSize = true;
            this.lblChancesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChancesNum.Location = new System.Drawing.Point(115, 3);
            this.lblChancesNum.Name = "lblChancesNum";
            this.lblChancesNum.Size = new System.Drawing.Size(30, 31);
            this.lblChancesNum.TabIndex = 12;
            this.lblChancesNum.Text = "∞";
            // 
            // picHangman
            // 
            this.picHangman.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picHangman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHangman.Image = global::Hangman.Properties.Resources.Hangman_0;
            this.picHangman.Location = new System.Drawing.Point(12, 103);
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(152, 149);
            this.picHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHangman.TabIndex = 13;
            this.picHangman.TabStop = false;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(12, 258);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(152, 23);
            this.btnShowList.TabIndex = 14;
            this.btnShowList.Text = "Edit Word/Phrase List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // grpPuzzleSelect
            // 
            this.grpPuzzleSelect.Controls.Add(this.cbMultiLetter);
            this.grpPuzzleSelect.Controls.Add(this.rbBoth);
            this.grpPuzzleSelect.Controls.Add(this.rbPhrases);
            this.grpPuzzleSelect.Controls.Add(this.rbWords);
            this.grpPuzzleSelect.Location = new System.Drawing.Point(12, 287);
            this.grpPuzzleSelect.Name = "grpPuzzleSelect";
            this.grpPuzzleSelect.Size = new System.Drawing.Size(160, 116);
            this.grpPuzzleSelect.TabIndex = 15;
            this.grpPuzzleSelect.TabStop = false;
            this.grpPuzzleSelect.Text = "Puzzle Options";
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Location = new System.Drawing.Point(7, 74);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(118, 17);
            this.rbBoth.TabIndex = 2;
            this.rbBoth.TabStop = true;
            this.rbBoth.Text = "Words and Phrases";
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // rbPhrases
            // 
            this.rbPhrases.AutoSize = true;
            this.rbPhrases.Location = new System.Drawing.Point(7, 51);
            this.rbPhrases.Name = "rbPhrases";
            this.rbPhrases.Size = new System.Drawing.Size(63, 17);
            this.rbPhrases.TabIndex = 1;
            this.rbPhrases.TabStop = true;
            this.rbPhrases.Text = "Phrases";
            this.rbPhrases.UseVisualStyleBackColor = true;
            // 
            // rbWords
            // 
            this.rbWords.AutoSize = true;
            this.rbWords.Checked = true;
            this.rbWords.Location = new System.Drawing.Point(7, 26);
            this.rbWords.Name = "rbWords";
            this.rbWords.Size = new System.Drawing.Size(56, 17);
            this.rbWords.TabIndex = 0;
            this.rbWords.TabStop = true;
            this.rbWords.Text = "Words";
            this.rbWords.UseVisualStyleBackColor = true;
            // 
            // pnlChances
            // 
            this.pnlChances.Controls.Add(this.lblChancesText);
            this.pnlChances.Controls.Add(this.lblChancesNum);
            this.pnlChances.Location = new System.Drawing.Point(12, 410);
            this.pnlChances.Name = "pnlChances";
            this.pnlChances.Size = new System.Drawing.Size(160, 41);
            this.pnlChances.TabIndex = 16;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.AutoScroll = true;
            this.pnlDisplay.AutoSize = true;
            this.pnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDisplay.Controls.Add(this.lblGuessDisplay);
            this.pnlDisplay.Location = new System.Drawing.Point(170, 12);
            this.pnlDisplay.MaximumSize = new System.Drawing.Size(370, 240);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(370, 240);
            this.pnlDisplay.TabIndex = 17;
            // 
            // cbMultiLetter
            // 
            this.cbMultiLetter.AutoSize = true;
            this.cbMultiLetter.Location = new System.Drawing.Point(7, 97);
            this.cbMultiLetter.Name = "cbMultiLetter";
            this.cbMultiLetter.Size = new System.Drawing.Size(125, 17);
            this.cbMultiLetter.TabIndex = 3;
            this.cbMultiLetter.Text = "Enter Multiple Letters";
            this.cbMultiLetter.UseVisualStyleBackColor = true;
            this.cbMultiLetter.CheckedChanged += new System.EventHandler(this.cbMultiLetter_CheckedChanged);
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(572, 463);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlChances);
            this.Controls.Add(this.grpPuzzleSelect);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.picHangman);
            this.Controls.Add(this.lblGraveyard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlGameButtons);
            this.Controls.Add(this.pnlGuess);
            this.Icon = global::Hangman.Properties.Resources.HangmanIcon;
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Hangman_Load);
            this.pnlGuess.ResumeLayout(false);
            this.pnlGuess.PerformLayout();
            this.pnlGameButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            this.grpPuzzleSelect.ResumeLayout(false);
            this.grpPuzzleSelect.PerformLayout();
            this.pnlChances.ResumeLayout(false);
            this.pnlChances.PerformLayout();
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
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
        private System.Windows.Forms.Panel pnlGameButtons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGraveyard;
        private System.Windows.Forms.Label lblChancesText;
        private System.Windows.Forms.Label lblChancesNum;
        private System.Windows.Forms.PictureBox picHangman;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.GroupBox grpPuzzleSelect;
        private System.Windows.Forms.RadioButton rbBoth;
        private System.Windows.Forms.RadioButton rbPhrases;
        private System.Windows.Forms.RadioButton rbWords;
        private System.Windows.Forms.Panel pnlChances;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.CheckBox cbMultiLetter;
    }
}

