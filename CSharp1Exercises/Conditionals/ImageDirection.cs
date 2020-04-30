using System;
namespace CSharp1Exercises.Conditionals
{
    public class ImageDirection
    {
        public ImageDirection()
        {
            Console.Write("Enter image width: ");
            var widthInput = Console.ReadLine();
            var width = Convert.ToInt32(widthInput);

            Console.Write("Enter image height: ");
            var heightInput = Console.ReadLine();
            var height = Convert.ToInt32(heightInput);

            var style = width > height ? "landscape" : "portrait";

            Console.WriteLine("This image is {0}", style);
        }
    }
}
