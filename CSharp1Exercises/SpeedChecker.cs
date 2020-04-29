using System;
namespace CSharp1Exercises
{
    public class SpeedChecker
    {
        public SpeedChecker()
        {
            Console.WriteLine("Enter the speed limit: ");
            var speed_limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car: ");
            var actual_speed = Convert.ToInt32(Console.ReadLine());

            if (actual_speed <= speed_limit)
            {
                Console.WriteLine("You are OK.");
                return;
            }

            var points = (actual_speed - speed_limit) / 5;

            if (points <= 12)
            {
                Console.WriteLine("Points: {0}", points);
                return;
            }

            Console.WriteLine("License suspended");
        }
    }
}
