using System;

namespace PingPongCs.Models
{
  public class PingPong
  {
    public static string[] PingPongGenerator(int inputNumber)
    {
      string[] initializeGenerator = new string[inputNumber]; 
      for (int i = 1; i <= inputNumber; i++ )
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          initializeGenerator[i - 1] = "pingpong";
        }
        else if (i % 3 == 0)
        {
          initializeGenerator[i - 1] = "ping";
        }
        else if (i % 5 == 0)
        {
          initializeGenerator[i - 1] = "pong";
        }
        else
        {
          initializeGenerator[i - 1] = i.ToString();
        }
      }
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