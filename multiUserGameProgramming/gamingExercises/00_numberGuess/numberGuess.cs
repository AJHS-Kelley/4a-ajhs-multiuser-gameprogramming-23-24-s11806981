// Ashley Wright, Program Template, v0.04
/*
Generate secret number from a defined range of numbers.(ex. 0-10)
Print game instructions including range and num. of guesses allowed.
    MATCH == first player to score 3 points.
    ROUND == guessing a specific number, until correct or no more attempts
Ask the player what difficulty they want to play on.
Ask the player what their guess is.
Determine if guess is correct or not. (if statement)
    If guess is correct {
        Tell them they have guessed correctly.
        Player recieves a point.
    } else {
        Tell them they're wrong.
        Tell player if guess is too high or too low.
        Check to see if they have guesses remaining {
            if guess remain: {
                allow player to guess again.
            } else {
                CPU wins the round.
            }    
        }
    }
}

*/
using System;

namespace UPDATEFOREACHPROGRAM
{
    class UPDATEFOREACHPROGRAM
    {
        static void Main(string[] args)
        {
            int hiddenNumber = -1;
            int numGuesses = 0; // Number of guesses player is ALLOWED.
            int numAttempts = 0; // Number of guesses TAKEN.
            int playerGuess = 0;
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            int rangeMax = -1;

            Console.WriteLine("Welcome to the Number Guess Game!\n You will select a difficulty next.\n")
            Console.WriteLine("Easy Mode: Range is 0 - 10 with 4 guesses.\n Normal Mode: Range is 0 - 25 with 4 guesses.\n Hard Mode: Range is 0 - 50 with 2 guesses.")

            // Difficulty Selection
            Console.WriteLine("Please type Easy, Normal, or Hard and press enter.\n")
            difficulty = Console.ReadLine();
            // Console.ReadLine() will save to STRING by default.
            Console.WriteLine("You have selected: " + difficulty);
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 10;
                numGuesses = 4;
            } else if (difficulty == "Normal") {
                rangeMin = 0;
                rangeMax = 25;
                numGuesses = 4;
            } else if (difficulty == "Hard") {
                rangeMin = 0;
                rangeMax = 50;
                numGuesses = 2;
            } else {
                Console.WriteLine("No difficulty selected, defaulting  to Normal.\n")
                rangeMin = 0;
                rangeMax = 25;
                numGuesses = 4;
            }
            Console.WriteLine("Minimum: " + rangeMin);
            Console.WriteLine("Maximum: " + rangeMax);
            Console.WriteLine("Num. Guesses: " + numGuesses);

            // START THE MATCH!
            while (playerScore != 3 && cpuScore != 3) {
                // Any code that you want to run BEFORE each rouond goes here.
                // GENERATE SECRET NUMBER
                Random rndNum = new Random();
                secretNumber = rndNum.Next(rangeMin, rangeMax);
                Console.WriteLine("Player Score: " + playerScore + \n);
                


                // START EACH ROUND
                for (int i = 0; i < numGuesses ; i++) {
                    // Code to guess number goes here.
                }
            }
        }
    }
}