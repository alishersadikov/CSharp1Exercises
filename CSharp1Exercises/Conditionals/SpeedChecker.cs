using System;
namespace CSharp1Exercises.Conditionals
{
    public class SpeedChecker
    {
        public SpeedChecker()
        {
            Console.WriteLine("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car: ");
            var actualSpeed = Convert.ToInt32(Console.ReadLine());

            if (actualSpeed <= speedLimit)
            {
                Console.WriteLine("You are OK.");
                return;
            }

            var points = (actualSpeed - speedLimit) / 5;

            if (points <= 12)
            {
                Console.WriteLine("Points: {0}", points);
                return;
            }

            Console.WriteLine("License suspended");
        }
    }
}
