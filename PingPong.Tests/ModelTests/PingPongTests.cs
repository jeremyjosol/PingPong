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
  }
}