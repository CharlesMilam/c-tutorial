using System;

namespace BasicMath
{
	class MainClass
	{
		public static void Main (string[] args)
		{
      int number1, number2;

			Console.WriteLine ("Please enter a number:");
      number1 = int.Parse (Console.ReadLine ());

      Console.WriteLine ("Thanks. May I have one more:");
      number2 = int.Parse (Console.ReadLine ());

      Console.WriteLine ("Adding the numbers equals: " + (number1 + number2));
		}
	}
}
