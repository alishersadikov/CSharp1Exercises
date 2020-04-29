using System;
namespace CSharp1Exercises
{
    public class SumOfNumbers
    {
        public SumOfNumbers()
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number:");
                var input = Console.ReadLine();

                if (input == "ok")
                {
                    Console.WriteLine("Cumulative sum is {0}", sum);
                    break;
                }

                var number  = Convert.ToInt32(input);
                sum += number;
            }
        }
    }
}
