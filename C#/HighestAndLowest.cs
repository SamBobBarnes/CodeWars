using NUnit.Framework;

namespace Code_Wars;

public class HighestAndLowest
{
  private static string HighAndLow(string numbers)
  {
    var numberArray = numbers.Split(' ').Select(Int32.Parse).ToList();
    return numberArray.Max() + " " + numberArray.Min();
  }
  
  [Test]
  public void Test1()
  {
    Assert.AreEqual("42 -9", HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
  }
  [Test]
  public void Test2()
  {
    Assert.AreEqual("3 1", HighAndLow("1 2 3"));
  }
}