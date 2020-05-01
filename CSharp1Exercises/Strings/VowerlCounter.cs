using System;
using System.Collections.Generic;

namespace CSharp1Exercises.Strings
{
    internal class VowerlCounter
    {
        // Write a program and ask the user to enter an English word.Count the
        // number of vowels (a, e, o, u, i) in the word. So, if the user enters
        // "inadequate", the program should display 6 on the console.

        public VowerlCounter()
        {
            Console.WriteLine("Enter a word:");
            var input = Console.ReadLine();

            int count = 0;

            var vowels = new List<char>() { 'a', 'e', 'o', 'u', 'i' };

            foreach (var item in input)
            {
                if (vowels.Contains(item))
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}