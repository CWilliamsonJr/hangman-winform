using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {
        public Hangman()
        {
            InitializeComponent();
            btnStart.Focus();

        }
        ~Hangman()
        {
            Close();
            Dispose(true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MakePuzzle();
            pnlGuess.Visible = true;
            txtGuess.Focus();
        }

        private void txtGuess_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                EvaluateGuess(txtGuess.Text);
                txtGuess.Clear();
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            
            lblGuessDisplay.Text = string.Empty;
            _guessDisplay = String.Empty;
            btnStart.PerformClick();

            ResetGame();




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose(true);
        }
    }
}
