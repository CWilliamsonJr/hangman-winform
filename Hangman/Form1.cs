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
            }
        }
    }
}
