using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string UserWord { get; set; }
    public string UserSentence { get; set; }

    public  RepeatCounter(string word, string sentence)
    {
      UserWord = word;
      UserSentence = sentence;
      
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

    public static string[] SentenceArr(string sentence)
    {
      string[] userSentenceArr = sentence.Split(" ");
      return userSentenceArr;
    }

    public int RepeatWord()
    {
      string[] userSentenceArr = SentenceArr(UserSentence);
      int countWord = 0;
      foreach(string word in userSentenceArr)
      {
        if(word.Contains(UserWord))
        {
          countWord += 1;
        }
      }
      return countWord;
    }
    
    

  }
}