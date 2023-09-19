using System;

namespace PingPongCs.Models
{
  public class PingPong
  {
    public static string[] PingPongGenerator(int inputNumber)
    {
      string[] initializeGenerator = new string[inputNumber]; 
      return initializeGenerator;
    }
    public static bool CheckDivisibility(int divisibleBy)
    {
      if (divisibleBy % 3 == 0 || divisibleBy % 5 == 0)
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