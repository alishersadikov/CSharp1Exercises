using System;
using System.Collections.Generic;

namespace CSharp1Exercises.Lists
{
    public class UniqueNumbers
    {
        // Write a program and ask the user to continuously enter a number or
        // type "Quit" to exit. The list of numbers may include duplicates.
        // Display the unique numbers that the user has entered.

        public UniqueNumbers()
        {
            
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or 'quit':");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                var number = Convert.ToInt32(input);
                if (numbers.Contains(number))
                    continue;

                numbers.Add(number);
            }

            foreach (var num in numbers)
                Console.WriteLine(num);
        }
    }
}
