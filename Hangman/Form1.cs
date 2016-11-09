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
            ResetGame();
            btnStart_Click(sender, e);
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return) return;
            if (string.IsNullOrWhiteSpace(txtGuess.Text)) return;
            e.Handled = true;
            e.SuppressKeyPress = true;
            EvaluateGuess(PuzzleChoice);
            //EvaluateGuess(txtGuessText: txtGuess.Text, puzzles: Words);
            txtGuess.Clear();
        }

        private void Hangman_Load(object sender, EventArgs e)
        {
            btnStart.Focus();
            lblChancesNum.Text = Chances.ToString();
            lblGraveyard.Text = string.Empty;
            FileLoader();
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

        
    }
}
