using System;
namespace CSharp1Exercises
{
    public class ValidNumber
    {
        public ValidNumber()
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
