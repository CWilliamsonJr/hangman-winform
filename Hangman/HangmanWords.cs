using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman
    {
        private int WordId { get; set; } // used for the index of words array
        private int Chances { get; set; } = 6;
        private string GuessDisplay { get; set; }
        private string CorrectLettersGuessed { get; set; }
        private string WrongLettersGuessed { get; set; }

        private string[] Words { get; set; } 

        private string[] Phrases { get; set; }

        private void MakePuzzle(IReadOnlyList<string> puzzels)
        {
            Random rand = new Random();
            WordId = rand.Next(0, puzzels.Count);

            foreach (var character in puzzels[WordId])
            {
                if (char.IsLetter(character.ToString(), 0)) // test if characer is a letter 
                {
                    GuessDisplay += "__ "; // if character is a letter add a dash
                }
                else
                {
                    if (char.IsWhiteSpace(character.ToString(), 0)) // if it's white space add a new line
                    {
                        GuessDisplay += "\r";
                    }
                    else
                    {
                        GuessDisplay += character.ToString(); // if neither just add to display
                    }
                }
            }
            lblGuessDisplay.Text = GuessDisplay;
        }

        private void EvaluateGuess(IReadOnlyList<string> puzzels, string txtGuessText)
        {
            char[] seperators = {' ', '\r'}; // list of delimitor to seperate display string into array
            var guessDisplayTemp = GuessDisplay.Trim().Split(seperators);
            var chosenWordTemp = puzzels[WordId].ToLower().ToCharArray(); // an array of character of the chosen string
            StringBuilder builder = new StringBuilder(); // used to turn string array back into string.

            if (lblGuessDisplay.Text.Contains("_")) // checks to see if there are any empty spaces left.
            {
                if (puzzels[WordId].ToLower().Contains(txtGuessText.ToLower()) && Chances > 0)
                    // checks to see if guess is in the string
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

                    if (lblGuessDisplay.Text.Contains("_")) return; // checks to see if any guesses are left
                    if (Chances >= 1)
                    {
                        GameStatus(@"You Win!");
                    }
                }
                else
                {
                    //TODO: All letter to the Graveyard.

                    if (string.IsNullOrWhiteSpace(WrongLettersGuessed) || !WrongLettersGuessed.Contains(txtGuessText))
                        // checks to see if anything has been guessed.
                    {
                        WrongLettersGuessed += txtGuessText; // adds to list
                        lblGraveyard.Text += txtGuessText + '\n'; //adds to display
                    }

                    if (Chances >= 1) //checks to see if any chances are left
                    {
                        Chances--;
                        lblChancesNum.Text = Chances.ToString();
                    }
                    else
                    {
                        Chances--;
                        lblChancesNum.Text = Chances.ToString();
                        GameStatus(@"You Lose!");
                    }
                }
            }
            else
            {
                //TODO: Check to see if complete picture is showing.
                if (Chances >= 1)
                {
                    GameStatus(@"You Win!");
                }
            }
        }

        private void GameStatus(string status)
        {
            lblChancesText.Text = status;
            txtGuess.Enabled = false;
        }

        private void ResetGame()
        {
            GuessDisplay = lblGraveyard.Text = CorrectLettersGuessed = WrongLettersGuessed = string.Empty;
                // resets everything
            lblChancesNum.Text = @"6";
            txtGuess.Enabled = true;
            lblChancesText.Text = "Chances:";
            Chances = 6;
        }

        private void FileLoader()
        {
            try
            {
                Words = File.ReadAllLines(@"./Text Files/words.txt");
                Phrases = File.ReadAllLines(@"./Text Files/phrases.txt");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw new Exception();
            }
        }
    }
}