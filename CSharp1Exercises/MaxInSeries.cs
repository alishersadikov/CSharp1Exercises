using System;

namespace CSharp1Exercises.ControlFlow
{
    internal class MaxInSeries
    {
        public MaxInSeries()
        {
            Console.WriteLine("Enter comma-separated numbers:");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (string num in numbers)
            {
                var number = Convert.ToInt32(num);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max number is: {0}", max);
        }
    }
}