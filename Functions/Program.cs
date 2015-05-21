using System;

namespace Functions
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      DoStuff();
      Console.WriteLine(AddNumbers (3, 12));
    }

    // basic function
    public static void DoStuff ()
    {
      Console.WriteLine ("I'm doing something...");
    }

    // basic addition function
    public static int AddNumbers (int num1, int num2)
    {
      int result = num1 + num2;

      if (result > 10)
      {
        return result;
      }

      return 0;
    }
  }
}
