using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
	class MainClass
	{
		public static void Main (string[] args)
		{
      string firstName = "Charles";
      string lastName = "Milam";

			Console.WriteLine ("Name: " + firstName + " " + lastName);

      Console.WriteLine ("Please enter a new first name.");
      firstName = Console.ReadLine ();

      Console.WriteLine ("New name: " + firstName + " " + lastName);
		}
	}
}
