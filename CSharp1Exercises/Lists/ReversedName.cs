using System;
namespace CSharp1Exercises.Lists
{
    public class ReversedName
    {
        public ReversedName()
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            var reversed_chars = new char[name.Length];

            for (int i = name.Length; i > 0; i--)
            {
                reversed_chars[name.Length - i] = name[i - 1];
            }

            var reversed_name = new string(reversed_chars);

            Console.WriteLine("Your reversed name: {0}", reversed_name);
        }
    }
}
