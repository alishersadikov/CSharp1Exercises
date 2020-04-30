using System;
using System.Collections.Generic;

namespace CSharp1Exercises.Strings
{
    public class ConsecutiveList
    {
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        
        public ConsecutiveList()
        {
            Console.WriteLine("Enter hyphenated numbers (e.g. 1-2-3-4):");
            var input = Console.ReadLine();

            var numbers = new List<int>();

            foreach (var num in input.Split('-'))
                numbers.Add(Convert.ToInt32(num));

            var unsortedNumbers = new int[numbers.Count];

            numbers.CopyTo(unsortedNumbers, 0);
            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != unsortedNumbers[i])
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }
    }
}
