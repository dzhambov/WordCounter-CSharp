using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void RepeatCounter_VerifyUserInputIsWord_Word()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      string inputWord = newRepeatCounter.SampleWord("car");
      Assert.AreEqual("car", inputWord);
    }

    [TestMethod]
    public void RepeatCounter_SampleSentence_Sentence()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      string inputSentence = newRepeatCounter.SampleSentence("This is my car.");
      Assert.AreEqual("This is my car.", inputSentence);
    }

    [TestMethod]
    public void RepeatCounter_TestForMultipleWords_MultipleWords()
    {
      string userWord = "car";
      string userSentence = "This car is my car";
      RepeatCounter newRepeatCounter = new RepeatCounter(userWord, userSentence);
      int countWord = newRepeatCounter.RepeatWord();
      Assert.AreEqual(2, countWord);
    }
    [TestMethod]
    public void RepeatCounter_TestForPartialRegister_Word()
    {
      string userWord = "car";
      string userSentence = "Be carful what you wish for";
      RepeatCounter newRepeatCounter = new RepeatCounter(userWord, userSentence);
      int countWord = newRepeatCounter.RepeatWord();
      Assert.AreEqual(0, countWord);
    }
  }
}