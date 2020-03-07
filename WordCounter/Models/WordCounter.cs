using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string UserWord { get; set; }
    public string UserSentence { get; set; }

    public void UserWordCounter(string word, string sentence)
    {
      UserWord = word;
      UserSentence = sentence;
      int countWord = 0;
      // foreach(string sent in sentence)
      // {
      //   countWord++;
      // }
      // return countWord;
    }

    public string SampleWord(string word)
    {
      string inputWord = word;
      return inputWord;
    }

    public string SampleSentence( string sentence)
    {
      string inputSentence = sentence;
      return inputSentence;
    }

    public static string[] SplitSentence(string sentence)
    {
      return sentence.Split(" ");
    }
    
    

  }
}