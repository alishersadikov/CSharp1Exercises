using System;

namespace CSharp1Exercises.Conditionals
{
    public class MaxFinder
    {
        public MaxFinder()
        {
            Console.Write("Enter the first number: ");            var input1 = Console.ReadLine();            var number1 = Convert.ToInt32(input1);            Console.Write("Enter the second number: ");            var input2 = Console.ReadLine();            var number2 = Convert.ToInt32(input2);            var max = Math.Max(number1, number2);            Console.WriteLine("The bigger integer is: {0}", max);
        }
    }
}