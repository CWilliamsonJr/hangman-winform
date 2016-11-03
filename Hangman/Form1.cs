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
            lblGraveyard.Text = string.Empty;
        }
       

        private void btnStart_Click(object sender, EventArgs e)
        {
            MakePuzzle(Words);
            pnlGuess.Visible = true;
            txtGuess.Focus();
        }

        private void txtGuess_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (string.IsNullOrWhiteSpace(txtGuess.Text))
                    return;

                EvaluateGuess(Words,txtGuess.Text);
                txtGuess.Clear();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
            btnStart.PerformClick();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
