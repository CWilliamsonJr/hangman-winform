using System;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {
        private EditPuzzle _editPuzzle = new EditPuzzle();
        private bool IsShowing { get; set; }

        public Hangman()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            PuzzleChoice = SelectedPuzzle();
            MakePuzzle(PuzzleChoice);
            pnlGuess.Visible = true;
            txtGuess.Focus();
            btnStart.Visible = false;
            btnNewGame.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ResetGame(); // restores everything to default
            btnStart_Click(sender, e);
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return) return;
            if (string.IsNullOrWhiteSpace(txtGuess.Text)) return; // stops empty text from being sent.

            e.SuppressKeyPress = true; // stop key sound from being fired

            if (AllowMultiLine) // determines if multi letter support is enabled.
            {
                txtGuess.Enabled = false;
                var strTempArray = txtGuess.Text.ToCharArray(); // turns entered string into characters
                foreach (var character in strTempArray)
                {
                    if (Chances <= 0) break; // stops execution if no chances are left.
                    if (string.IsNullOrWhiteSpace(character.ToString()) || char.IsPunctuation(character))
                        continue; // skips spaces and punctuation.

                    txtGuess.Text = character.ToString();
                    EvaluateGuess(PuzzleChoice);
                }
                if (Chances >= 1)
                {
                    txtGuess.Enabled = true;
                    txtGuess.Focus();
                }

            }
            else
            {
                EvaluateGuess(PuzzleChoice);
            }

            txtGuess.Clear(); // clears input box
        }

        private void Hangman_Load(object sender, EventArgs e)
        {
            btnStart.Focus();
            lblChancesNum.Text = Chances.ToString();
            lblGraveyard.Text = string.Empty;
            FileLoader(); // loads text file 
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            if (IsShowing) // hides edit form if its showing, show it if its not.
            {
                _editPuzzle.Hide();
                _editPuzzle.EditStatus = string.Empty;
                IsShowing = false;
            }
            else
            {
                _editPuzzle.Show();
                IsShowing = true;
            }
        }

        private void cbMultiLetter_CheckedChanged(object sender, EventArgs e)
        {
            AllowMultiLine = cbMultiLetter.Checked;

            if (AllowMultiLine) // changes input box size
            {
                txtGuess.Width = 100;
                txtGuess.MaxLength = 50;
            }
            else
            {
                txtGuess.Width = 33;
                txtGuess.MaxLength = 1;
                txtGuess.Clear();
            }
        }
    }
}
