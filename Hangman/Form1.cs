using System;
using System.Windows.Forms;


namespace Hangman
{
    public partial class Hangman : Form
    {
        public Hangman()
        {
            InitializeComponent();
            btnStart.Focus();
            lblChancesNum.Text = Chances.ToString();
            lblGraveyard.Text = string.Empty;
            FileLoader();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            MakePuzzle(Words);
            pnlGuess.Visible = true;
            txtGuess.Focus();
            btnStart.Visible = false;
            btnNewGame.Visible = true;
        }

        private void txtGuess_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return) return;
            if (string.IsNullOrWhiteSpace(txtGuess.Text)) return;

            EvaluateGuess(Words, txtGuess.Text);
            txtGuess.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
            btnStart_Click(sender, e);
        }
    }
}
