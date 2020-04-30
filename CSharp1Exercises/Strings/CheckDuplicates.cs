using System;
using System.Collections.Generic;

namespace CSharp1Exercises.Strings
{
    public class CheckDuplicates
    {
        /// Write a program and ask the user to enter a few numbers separated by
        /// a hyphen. If the user simply presses Enter, without supplying an
        /// input, exit immediately; otherwise, check to see if there are
        /// duplicates. If so, display "Duplicate" on the console.

        public CheckDuplicates()
        {
            Console.WriteLine("Enter hyphenated numbers (e.g. 1-2-3-4):");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();

            foreach (var num in input.Split('-'))
                numbers.Add(Convert.ToInt32(num));

            var uniques = new List<int>();

            foreach (var num in numbers)
            {
                if (!uniques.Contains(num))
                    uniques.Add(num);
                else
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
            }
        }
    }
}
