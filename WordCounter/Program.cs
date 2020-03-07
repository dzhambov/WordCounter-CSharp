using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
     Console.Clear();
     Console.ForegroundColor = ConsoleColor.DarkYellow;
     TypeLine("Hello Word Contre");
     TypeLine("To start playing first enter a word");
     string word = Console.ReadLine();
     Console.ForegroundColor = ConsoleColor.DarkGreen;
     TypeLine("Now enter a sentence");
     string sentence = Console.ReadLine();
    }
    public static void TypeLine(string input)
      {
      for (int i = 0; i < input.Length; i++)
      {
          Console.Write(input[i]);
          System.Threading.Thread.Sleep(35);
      }
      Console.Write(Environment.NewLine);
      Console.Write(Environment.NewLine);
      }
  }

}