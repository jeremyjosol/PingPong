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
      int divisbleBy3 = 12;
      bool result = PingPong.CheckDivisibility(divisbleBy3);
      Assert.IsTrue(result);
    }
  }
}