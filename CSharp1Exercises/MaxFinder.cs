using System;

namespace CSharp1Exercises.ControlFlow
{
    internal class MaxFinder
    {
        public MaxFinder()
        {
            Console.Write("Enter the first number: ");            var input_1 = Console.ReadLine();            var number_1 = Convert.ToInt32(input_1);            Console.Write("Enter the second number: ");            var input_2 = Console.ReadLine();            var number_2 = Convert.ToInt32(input_2);            var max = Math.Max(number_1, number_2);            Console.WriteLine("The bigger integer is: {0}", max);
        }
    }
}