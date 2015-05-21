using System;

namespace Arrays
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      string[] names = new string[2];

      names [0] = "Charles";
      names [1] = "Susan";

      // use foreach loop through array
      foreach(string name in names)
      {
        Console.WriteLine (name);
      }

      // use for loop
      for(int i = 0; i < names.Length; i++)
      {
        Console.WriteLine (i + ". " + names [i]);
      }

      // populate a new arrray
      int[] numbers = { 4, 3, 8, 0, 5 };

      // sort the numbers array
      Array.Sort (numbers);

      // print the numbers
      foreach(int num in numbers)
      {
        Console.WriteLine (num);
      }
    }
  }
}
