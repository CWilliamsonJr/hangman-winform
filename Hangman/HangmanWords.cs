using System;
using System.Linq;
using System.Text;

namespace Hangman
{
    public partial class Hangman
    {
        private int _wordId = 0; // used for the index of words array
        private string _guessDisplay;
        private readonly string[] _words = // list of words/phrases for hangman
        {
            "Programming is fun!"
        };
        private string _correctLettersGuessed; // list of correct letters
        private string _wrongLettersGuessed; // list of wrong letters

        private void MakePuzzle()
        {
            foreach (var character in _words[_wordId])
            {
                if (char.IsLetter(character.ToString(), 0)) // test if characer is a letter 
                {
                    _guessDisplay += "__ "; // if character is a letter add a dash
                }
                else
                {
                    if (char.IsWhiteSpace(character.ToString(), 0)) // if it's white space add a new line
                    {
                        _guessDisplay += "\r";
                    }
                    else
                    {
                        _guessDisplay += character.ToString(); // if neither just add to display
                    }
                }
            }
            lblGuessDisplay.Text = _guessDisplay;
        }

        private void EvaluateGuess(string txtGuessText)
        {
            char[] seperators = {' ', '\r'}; // list of delimitor to seperate display string into array
            var guessDisplayTemp = _guessDisplay.Trim().Split(seperators);
            var chosenWordTemp = _words[_wordId].ToLower().ToCharArray(); // an array of character of the chosen string
            StringBuilder builder = new StringBuilder(); // used to turn array back into string.

            if (_words[_wordId].ToLower().Contains(txtGuessText.ToLower())) // checks to see if guess is in the string
            {
                //TODO: Do print characters to the screen
                _correctLettersGuessed += txtGuess.Text; // adds correct guess to string.

                for(var i = 0; i < chosenWordTemp.Length; i++) // loops the each letter in the string araray
                {
                    foreach (var letter in _correctLettersGuessed) // loops through the correct letters
                    {
                        // test if letter from chosen word matches letter from correct letters and there is a blank space in guess display
                        if (chosenWordTemp[i] == letter && Char.IsLetter(guessDisplayTemp[i],0) == false ) 
                        {
                            guessDisplayTemp[i] = letter.ToString(); // replace dash with letter
                        }
                    }
                }

                foreach (var character in guessDisplayTemp) // makes string array back to string.
                {
                    builder.Append(character).Append(" "); //addes space between each dash
                    if (character == "") builder.Append('\r'); // addes new line at the correct spot.
                }
                lblGuessDisplay.Text = builder.ToString(); // prints back to screen
            }
            else
            {
                //TODO: All letter to the Graveyard.
                label2.Text = @"WRONG!!!";
                _wrongLettersGuessed += txtGuess.Text;
            }
        }

        private void ResetGame()
        {
            _guessDisplay = _correctLettersGuessed = _wrongLettersGuessed = string.Empty; // resets everything
        }
    }
}