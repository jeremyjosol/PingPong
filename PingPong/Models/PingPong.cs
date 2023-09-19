using System;

namespace PingPongCs.Models
{
  public class PingPong
  {
    public PingPong()
    {

    }
    public static bool CheckDivisibility(int divisibleBy3, int divisibleBy5)
    {
      if (divisibleBy3 % 3 == 0 || divisibleBy5 % 5 == 0)
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