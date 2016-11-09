using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Hangman
{
    public partial class EditPuzzle : Form
    {
        public string EditStatus
        {
            get
            {
                return this.lblStatus.Text;
            }

            set
            {
                this.lblStatus.Text = value;
            }
        }

        public EditPuzzle()
        {
            InitializeComponent();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"../../Text Files/words.txt",txtWordList.Lines);
            File.WriteAllLines(@"../../Text Files/phrases.txt", txtPhraseList.Lines);
            lblStatus.Text = @"Files were saved";

        }

        private void EditPuzzle_Load(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
            txtWordList.Lines = File.ReadAllLines(@"../../Text Files/words.txt");
            txtPhraseList.Lines = File.ReadAllLines(@"../../Text Files/phrases.txt");
        }
      
    }
}
