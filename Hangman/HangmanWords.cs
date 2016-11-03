using System;
using System.Text;

namespace Hangman
{
    public partial class Hangman
    {
        private int _wordId = 0; // used for the index of words array
        private string _guessDisplay;

        public string CorrectLettersGuessed { get; private set; }
        public string WrongLettersGuessed { get; private set; }

        public string[] Words { get; } = {
            @"Programmer",
            @"Buzzer",
            @"Jazz",
            @"Chalkboard",
            @"Volkswagon",
            @"Iced tea",
            @"Coffee",
            @"Church"
        };

        public string[] Phrases { get; } = {
            @"Programming is fun!",
            @"Time is money",
            @"A Dime a Dozen",
            @"Beating Around the Bush",
            @"Close But No Cigar",
            @"Suck it up buttercup",
            @"Curiosity Killed The Cat",
            @"You Can't Teach an Old Dog New Tricks"
        };

        private void MakePuzzle(string[] puzzels)
        {
            Random rand = new Random();
            _wordId = rand.Next(0, puzzels.Length);

            foreach (var character in puzzels[_wordId])
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

        private void EvaluateGuess(string[] puzzels, string txtGuessText)
        {
            char[] seperators = { ' ', '\r' }; // list of delimitor to seperate display string into array
            var guessDisplayTemp = _guessDisplay.Trim().Split(seperators);
            var chosenWordTemp = puzzels[_wordId].ToLower().ToCharArray(); // an array of character of the chosen string
            StringBuilder builder = new StringBuilder(); // used to turn array back into string.

            if (puzzels[_wordId].ToLower().Contains(txtGuessText.ToLower())) // checks to see if guess is in the string
            {
                //TODO: Do print characters to the screen
                CorrectLettersGuessed += txtGuess.Text; // adds correct guess to string.

                for (var i = 0; i < chosenWordTemp.Length; i++) // loops the each letter in the string araray
                {
                    foreach (var letter in CorrectLettersGuessed) // loops through the correct letters
                    {
                        // test if letter from chosen word matches letter from correct letters and there is a blank space in guess display
                        if (chosenWordTemp[i] == letter && Char.IsLetter(guessDisplayTemp[i], 0) == false)
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

                if (string.IsNullOrWhiteSpace(WrongLettersGuessed))
                {
                    WrongLettersGuessed = txtGuessText;
                    lblGraveyard.Text = txtGuessText + '\n';
                }

                if (!WrongLettersGuessed.Contains(txtGuessText))
                    lblGraveyard.Text += txtGuessText + '\n';

                WrongLettersGuessed += txtGuessText;
            }
        }

        private void ResetGame()
        {
            _guessDisplay = CorrectLettersGuessed = WrongLettersGuessed = string.Empty; // resets everything
        }
    }
}