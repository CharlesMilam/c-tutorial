using System;

namespace ConditionalStatements
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      Console.WriteLine("If or Switch");
      string input = Console.ReadLine();

      switch (input.ToLower())
      {
      case "if":
        IfStatement.MainIf();
        break;
      case "switch":
        SwitchStatement.MainSwitch();
        break;
      }
    }
  }

	class IfStatement
	{
		public static void MainIf ()
		{
      int number;

			Console.WriteLine ("Please enter a number between 0 and 10:");
      number = int.Parse (Console.ReadLine ());

      if ((number <= 10) && (number >= 0))
        Console.WriteLine ("Strong work!");
      else
        Console.WriteLine("The number should be between 0 and 10, inclusive.");
		}
	}

  class SwitchStatement
  {
    public static void MainSwitch ()
    {
      Console.WriteLine ("So...C#? yes/no/maybe");
      string input = Console.ReadLine();

      switch (input.ToLower())
      {
      case "yes":
      case "maybe":
        Console.WriteLine("We shall see...won't we.");
        break;
      case "no":
        Console.WriteLine("Too bad...but perhaps a wise decision.");
        break;
      default:
        Console.WriteLine ("Huh?");
        break;
      }
    }
  }
}
