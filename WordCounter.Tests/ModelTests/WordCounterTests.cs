using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  //change name of test class.
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void RepeatCounter_UserWordCounter_Word()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }

  }
}