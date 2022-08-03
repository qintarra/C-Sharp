using System;
namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            bool repeat = true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play \"Guess the Number\"!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            int guessCount = 0;

            do 
            {
                Console.WriteLine("What's your guess?");
                string theGuess = Console.ReadLine();

                // Keep track of the number of guesses and the current user guess
                // A way to convert the user's input to an integer
                bool result = Int32.TryParse(theGuess, out int guessNumber);

                // If the user entered something other than a number ask them again
                if (!result)
                {
                    Console.WriteLine("It's not a number. Try again.");
                }
                else
                {
                    // If they enter a -1 then they want to exit the game
                    if (guessNumber == -1)
                    {
                        Console.WriteLine($"Ok, I was thinking of {theNumber}.");
                        repeat = false;
                    }
                    else 
                    {
                        guessCount++;

                        // If they got it right, tell them the guess count and exit
                        if (guessNumber == theNumber) 
                        {
                            Console.WriteLine($"You got it in {guessCount} guesses.");
                            repeat = false;
                        }
                        else 
                        {
                            // Tell them to either guess lower or higher than the previous guess
                            Console.WriteLine("Nope, {0} than that.", guessNumber < theNumber ? "higher" : "lower");
                        }
                    }
                }
            } 
            while(repeat);
        }
    }
}
