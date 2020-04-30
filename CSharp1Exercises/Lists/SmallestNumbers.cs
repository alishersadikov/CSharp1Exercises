using System;
namespace CSharp1Exercises.Lists
{
    public class SmallestNumbers
    {
        // Write a program and ask the user to supply a list of comma separated
        // numbers(e.g 5, 1, 9, 2, 10). If the list is empty or includes less
        // than 5 numbers, display "Invalid List" and ask the user to re-try;
        // otherwise, display the 3 smallest numbers in the list.

        public SmallestNumbers()
        {
            while(true)
            {
                Console.WriteLine("Enter comma-separated numbers:");
                var input = Console.ReadLine();
                var numbers = input.Split(',');

                if (numbers.Length < 5)
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }

                Array.Sort(numbers);
                var sliced = numbers[0..3];

                Console.WriteLine("The smallest 3 numbers:");

                foreach (var num in sliced)
                    Console.WriteLine(num);

                break;
            }
        }
    }
}
