using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Hangman
{
    public partial class EditPuzzle : Form
    {
        public EditPuzzle()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"../../Text Files/words.txt",txtWordList.Lines);
            File.WriteAllLines(@"../../Text Files/phrases.txt", txtPhraseList.Lines);

        }

        private void EditPuzzle_Load(object sender, EventArgs e)
        {
            txtWordList.Lines = File.ReadAllLines(@"../../Text Files/words.txt");
            txtPhraseList.Lines = File.ReadAllLines(@"../../Text Files/phrases.txt");
        }
      
    }
}
