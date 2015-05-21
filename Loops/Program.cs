using System;

namespace Loops
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      int number = 0;

      // while loop
      Console.WriteLine ("while loop");
      while(number < 5)
      {
        Console.WriteLine (number);
        number += 1;
      }

      // reset number variable
      number = 0;

      // do loop
      Console.WriteLine("do loop");
      do {
        Console.WriteLine (number);
        number += 1;
      } while(number < 5);

      // for loop
      Console.WriteLine ("for loop");
      for (int i = 0; i < number; i++)
      {
        Console.WriteLine (i);
      }
        

    }
  }
}
