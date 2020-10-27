using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 7;

            Console.WriteLine("Guess the favorite number. Hint: below 10");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("too low! try again");
            }
            else if (userGuess > favoriteNumber)
            {
                Console.WriteLine("sorry, too high! try again");
            }
            else if (userGuess == favoriteNumber)
            {
                Console.WriteLine("yay thats it!");
            }
            
        }
    }
}
