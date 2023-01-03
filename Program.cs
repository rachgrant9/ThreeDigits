using System;
using System.Numerics;

namespace ThreeDigits
{
  class Program
  {
    static void Main(string[] args)
    {
      string line = Console.ReadLine();
      int inputNumber = Convert.ToInt32(line);
      BigInteger bigNum = new BigInteger(inputNumber);
      BigInteger factorial = CalculateFactorial(bigNum);

      string factorialSequence = factorial.ToString();
      var numberDigits = factorialSequence.Length;

      var finalSeq = TrimZeros(factorialSequence, numberDigits);
      var lengthTrimmedSeq = finalSeq.Length;
      if (lengthTrimmedSeq < 3)
      {
        Console.WriteLine(finalSeq);
      }
      else
      {
        var thirdLastIndex = lengthTrimmedSeq - 3;
        var lastThree = finalSeq.Substring(thirdLastIndex, 3);
        Console.WriteLine(lastThree);
      } 
    }

    /// <summary>
    /// Check if sequence ends in a 0. If so, trim the 0s from the end.
    /// </summary>
    private static string TrimZeros(string factorialSequence, int numberDigits)
    {
      var lastZero = factorialSequence.LastIndexOf("0");
      if (lastZero == numberDigits - 1)
      {
        factorialSequence = factorialSequence.TrimEnd('0');
      }
      return factorialSequence;
    }

    /// <summary>
    /// Calculate the factorial of a number.
    /// e.g. 5*4*3*2*1
    /// </summary>
    public static BigInteger CalculateFactorial(BigInteger number)
    {
      BigInteger big = new BigInteger(1);
      for (int i = 1; i <= number; i++)
      {
        big *= i;
      }

      return big;
    }
  }
}
