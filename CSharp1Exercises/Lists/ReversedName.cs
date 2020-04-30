using System;
namespace CSharp1Exercises.Lists
{
    public class ReversedName
    {
        public ReversedName()
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            var reversedChars = new char[name.Length];

            for (int i = name.Length; i > 0; i--)
            {
                reversedChars[name.Length - i] = name[i - 1];
            }

            var reversedName = new string(reversedChars);

            Console.WriteLine("Your reversed name: {0}", reversedName);
        }
    }
}
