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

      if (number > 10)
        Console.WriteLine ("Hey! The number should be 10 or less.");
      else if (number < 0)
        Console.WriteLine ("Hey! The number should 0 or greater.");
        else
          Console.WriteLine("Nice work.");
		}
	}
}
