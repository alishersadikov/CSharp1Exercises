using System;
using System.IO;

namespace CSharp1Exercises.FileExercises
{
  internal class LongestWord
  {
    // Write a program that reads a text file and displays the longest word in the file
    public LongestWord()
    {
      var path = @"../CSharp1Exercises/example.csv";
      File.WriteAllText(path, "I,am,csv,text");

      var text = File.ReadAllText(path);
      var words = text.Split(',');

      var longest = words[0]; // assume for now

      foreach (var word in words)
      {
        if (word.Length > longest.Length)
          longest = word;
      }

      Console.WriteLine("The longest word: {0}", longest);

      File.Delete(path);
    }
  }
}