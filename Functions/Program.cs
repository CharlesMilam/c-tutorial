using System;

namespace Functions
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      DoStuff();
      Console.WriteLine(AddNumbers (3, 6));
    }

    // basic function
    public static void DoStuff ()
    {
      Console.WriteLine ("I'm doing something...");
    }

    // basic addition function
    public static int AddNumbers (int num1, int num2)
    {
      return num1 + num2;
    }
  }
}
