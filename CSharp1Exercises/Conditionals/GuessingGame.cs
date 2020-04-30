using System;

namespace CSharp1Exercises.Conditionals
{
    internal class GuessingGame
    {
        public GuessingGame()
        {
            var random = new Random();
            var secretNumber = random.Next(1, 10);
            var attempts = 0;

            while (attempts < 4)
            {
                Console.WriteLine("Guess the number (between 1 and 10):");
                Console.WriteLine("Secret number is {0}: ", secretNumber);
                var input = Console.ReadLine();
                var inputNumber = Convert.ToInt32(input);


                if (secretNumber == inputNumber)
                {
                    Console.WriteLine("Your guess is correct");
                    return;
                }

                attempts++;             
            }

            Console.WriteLine("You have exhausted all 4 attempts");
        }
    }
}