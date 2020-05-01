using System;
using System.Collections.Generic;

namespace CSharp1Exercises.Strings
{
    internal class CaseConverter
    {
        // Write a program and ask the user to enter a few words separated by
        // a space.Use the words to create a variable name with PascalCase.
        // For example, if the user types: "number of students", display
        // "NumberOfStudents". Make sure that the program is not dependent on
        // the input.So, if the user types "NUMBER OF STUDENTS", the program
        // should still display "NumberOfStudents".

        public CaseConverter()
        {
            Console.WriteLine("Enter a few world separated by space:");
            var input = Console.ReadLine();

            var words = input.Split(' ');

            var pascalCaseWords = "";

            foreach (var word in words)
            {
                var converted = Char.ToUpper(word[0]) + word.ToLower().Substring(1);
                pascalCaseWords += converted;
            }

            Console.WriteLine(pascalCaseWords);
        }
    }
}