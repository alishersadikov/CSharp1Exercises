using System;
namespace CSharp1Exercises.Conditionals
{
    public class ImageDirection
    {
        public ImageDirection()
        {
            Console.Write("Enter image width: ");
            var width_input = Console.ReadLine();
            var width = Convert.ToInt32(width_input);

            Console.Write("Enter image height: ");
            var height_input = Console.ReadLine();
            var height = Convert.ToInt32(height_input);

            var style = width > height ? "landscape" : "portrait";

            Console.WriteLine("This image is {0}", style);
        }
    }
}
