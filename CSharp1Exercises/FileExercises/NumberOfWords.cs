using System;
using System.IO;

namespace CSharp1Exercises.FileExercises
{
  internal class NumberOfWords
  {
    // Write a program that reads a text file and displays the number of words
    public NumberOfWords()
    {
      var path = @"../CSharp1Exercises/example.csv";
      File.WriteAllText(path, "I,am,csv,text");

      var text = File.ReadAllText(path);
      var numberOfWords = text.Split(',').Length;

      Console.WriteLine("Total number of words: {0}", numberOfWords);

      File.Delete(path);
    }
  }
}