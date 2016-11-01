using System;

namespace Hangman
{
    public partial class Hangman
    {
        private int _wordId = 0;
        private string _guessDisplay;
        private string[] _words = { "Programming is fun!" };
        private string test = "test string";


        private void MakePuzzle()
        {
            foreach (var letter in _words[_wordId])
            {
                if (char.IsLetter(letter.ToString(), 0))
                {
                    _guessDisplay += "__ ";
                }
                else
                {
                    if (char.IsWhiteSpace(letter.ToString(), 0))
                    {
                        _guessDisplay += "\r";
                    }
                    else
                    {
                        _guessDisplay += letter.ToString();
                    }

                }
            }
            lblGuess.Text = _guessDisplay;
        }

        private void EvaluateGuess(string txtGuessText)
        {
            _guessDisplay = String.Empty;
            ;
            if (_words[_wordId].ToLower().Contains(txtGuessText.ToLower()))
            {
                //TODO: Do print characters to the screen
                foreach (var letter in _words[_wordId])
                {
                    if (char.IsLetter(letter.ToString(), 0))
                    {
                        if (letter.ToString().ToLower() == txtGuessText.ToLower())
                        {
                            label2.Text = "Here";
                            _guessDisplay += letter;
                        }
                        else
                        {
                            _guessDisplay += "__ ";
                        }
                    }
                    else
                    {
                        if (char.IsWhiteSpace(letter.ToString(), 0))
                        {
                            _guessDisplay += "\r";
                        }
                        else
                        {
                            _guessDisplay += letter.ToString();
                        }

                    }
                }
                lblGuess.Text = _guessDisplay;
            }
            else
            {
                //TODO: All letter to the Graveyard.
                label2.Text = "WRONG!!!";
            }
        }
    }
}