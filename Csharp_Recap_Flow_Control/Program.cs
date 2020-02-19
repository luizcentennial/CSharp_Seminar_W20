using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Recap_Conditionals {
	class Program {
		static void Main(string[] args) {
			// Flow control is a technique to define different paths
			// for your program.
			// This includes conditional statements and loops

			#region IF STATEMENTS
			// If statements define a code block that only runs
			// IF a condition is satisfied.

			// Conditions are written by using
			// - Comparison operators (==, !=, >, >=, <, <=)
			// - Logical operators (&&, ||, !)

			// Let's declare two variables
			int a = 1; // Initializing a variable
			int b = 5;

			if (a > b) { // If 10 is greater than 5
				// Then do something
				Console.WriteLine($"{a} is greater than {b}.");

				// This block will ONLY run if, and ONLY IF, a > b.
			}
			else {
				// This block will run if, and ONLY IF, a <= b.
				Console.WriteLine($"{a} is not greater than {b}.");
			}

			string name = "luiz";

			if (name == "Luiz" || name == "luiz") { // Using the || operator
				Console.WriteLine("Your name is Luiz.");
			}
			else if (name.ToUpper() == "REDDY") { // or name.ToLower() == "reddy"
				Console.WriteLine("Your name is Reddy.");
			}
			else {
				Console.WriteLine("Your name is NOT Luiz.");
			}

			#endregion

			#region SWITCH STATEMENTS
			// Switch statements work like if statements.
			// But the syntax is a little different.

			// Suppose a variable number:
			int number = 10;
			int numberSquared;

			switch (number) { // I define the variable I am switching on.
				case 1: // In case my variable equals 1:
					numberSquared = 1;
					break;
				case 2: // In case my variable equals 2:
					numberSquared = 4;
					break;
				default: // For every other case:
					numberSquared = number * number;
					break;
			}
			#endregion
		}
	}
}
