using System;

namespace FunctionParams
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      int number = 20;

      AddFive (ref number);

      Console.WriteLine (number);

      GreetPersons (0);
      GreetPersons (3, "Charles", "Grace", "Alli");
    }

    // add five to param, by ref example
    public static void AddFive (ref int number)
    {
      number += 5;
    }

    // params example
    public static void GreetPersons (int unusedParam, params string[] names)
    {
      foreach(string name in names)
      {
        Console.WriteLine ("Howdy, " + name + "!");
      }
    }
  }
}
