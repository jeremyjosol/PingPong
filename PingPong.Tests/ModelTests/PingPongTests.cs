using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongCs.Models;

namespace PingPongCs.Tests
{
  [TestClass]
  public class PingPongTests
  {
  
    [TestMethod]
    public void PingPongConstructor_CreatesInstanceOfPingPong_PingPong()
    {

      PingPong instanceOfPingPong = new PingPong();
  
      Assert.IsNotNull(instanceOfPingPong);
    }

    [TestMethod]
    public void CheckDivisibility_IfDivisibleBy3_ReturnTrue()
    {
      int divisibleBy3 = 12;
      bool result = PingPong.CheckDivisibility(divisibleBy3);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void CheckDivisibility_IfDivisibleBy5_ReturnTrue()
    {
      int divisibleBy5 = 25;
      bool result = PingPong.CheckDivisibility(divisibleBy5);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void PingPongGenerator_InitializesEmptyArray_EmptyArray()
    {
      int inputNumber = 0;
      string[] result = PingPong.PingPongGenerator(inputNumber);
      Assert.AreEqual(0, result.Length);
    }

    [TestMethod]
    public void PingPongGenerator_TakesUserInput_String()
    {
      int inputNumber = 15;
      string[] result = PingPong.PingPongGenerator(inputNumber);
      Assert.AreEqual("pingpong", result[14]);
    }
  }
}