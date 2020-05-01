using System;

namespace CSharp1Exercises.Strings
{
    internal class TimeValidator
    {
        // Write a program and ask the user to enter a time value in the
        // 24 - hour time format(e.g. 19:00). A valid time should be between
        // 00:00 and 23:59.If the time is valid, display "Ok"; otherwise,
        //display "Invalid Time".If the user doesn't provide any values,
        // consider it as invalid time.

        public TimeValidator()
        {
            Console.WriteLine("Enter time in 24-hour format (e.g. 19:00):");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }


        }
    }
}