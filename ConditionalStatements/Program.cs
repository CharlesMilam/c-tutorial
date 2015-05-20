using System;

namespace ConditionalStatements
{
	class IfStatement
	{
		public static void Main (string[] args)
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
}
