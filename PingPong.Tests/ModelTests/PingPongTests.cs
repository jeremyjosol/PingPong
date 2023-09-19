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
      bool result = PingPong.CheckDivisibility(divisibleBy3, 20);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void CheckDivisibility_IfDivisibleBy5_ReturnTrue()
    {
      int divisibleBy5 = 25;
      bool result = PingPong.CheckDivisibility(9, divisibleBy5);
      Assert.IsTrue(result);
    }
  }
}