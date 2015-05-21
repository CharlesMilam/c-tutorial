using System;

namespace Loops
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      int number = 0;

      // while loop
      while(number < 5)
      {
        Console.WriteLine (number);
        number = number + 1;
      }

      // reset number variable
      number = 0;

      // do loop
      do {
        Console.WriteLine (number);
        number = number + 1;
      } while(number < 5);

    }
  }
}
