using System;

namespace PingPongCs.Models
{
  public class PingPong
  {
    public PingPong()
    {

    }
    public static bool CheckDivisibility(int divisibleBy3)
    {
      if (divisibleBy3 % 3 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}