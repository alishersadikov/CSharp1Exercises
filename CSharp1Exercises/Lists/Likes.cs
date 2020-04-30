using System;
using System.Collections.Generic;

namespace CSharp1Exercises.Lists
{
    public class Likes
    {
        public Likes()
        {
            var friends = new List<string>();

            while (true)
			{
                Console.WriteLine("Enter a name or press enter:");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                friends.Add(input);

			}

            string text;

			switch (friends.Count)
			{
                case 0:
                    text = "";
                    break;
                case 1:
                    text = "[" + friends[0] + "] likes your post"; 
                    break;
                case 2:
                    text = "[" + friends[0] + "] and [" + friends[1] + "] like your post";
                    break;
                default:
                    var others = friends.Count - 2;
                    text = "[" + friends[0] + "], [" + friends[1] + "] and " + others +" others like your post";
                    break;
			}

            Console.WriteLine(text);
		}
    }
}
