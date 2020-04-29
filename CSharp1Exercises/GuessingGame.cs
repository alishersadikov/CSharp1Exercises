using System;

namespace CSharp1Exercises.ControlFlow
{
    internal class GuessingGame
    {
        public GuessingGame()
        {
            var random = new Random();
            var secret_number = random.Next(1, 10);        
            var attempts = 0;

            while (attempts < 4)
            {
                Console.WriteLine("Guess the number (between 1 and 10):");
                Console.WriteLine("Secret number is {0}: ", secret_number);
                var input = Console.ReadLine();
                var input_number = Convert.ToInt32(input);


                if (secret_number == input_number)
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