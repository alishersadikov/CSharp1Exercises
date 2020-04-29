using System;

namespace CSharp1Exercises.ControlFlow
{
    public class DivisibleBy3
    {
        public DivisibleBy3()
        {
            var counter = 0;

            for (var i = 1; i <= 100; i++)
            {

                if (i % 3 == 0)
                    counter++;

            }

            Console.Write("Between 1 and 100, {0} are divisible by 3", counter);
        }
    }
}