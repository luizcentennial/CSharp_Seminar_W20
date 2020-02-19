using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Recap_Loops {
	class Program {
		static void Main(string[] args) {
			// There are two kinds of loops:
			// - Pre-processed: Check the condition, and then run if required.
			// - Post-processed: Run first, and check the condition after.

			// Usually WHILE LOOPS are used when you do not know the number of times
			// that piece of code has to run.
			// And FOR LOOPS are used when you want to run that piece of code
			// for a specific number of times.

			#region DO-WHILE LOOPS
			// Suppose a variable counter
			int counter = 0;

			// This is the syntax for a do while loop:
			do {
				// Do this...
				counter++; // Same as counter = counter + 1;
				Console.WriteLine($"The counter is {counter}.");

				// This will ALWAYS run at least once.
			}
			while (counter < 10); // While this condition is true
			#endregion

			Console.WriteLine();

			#region WHILE LOOPS
			// Suppose another counter
			int anotherCounter = 0;

			// The syntax for the while loop is almost the same as the do while.
			while (anotherCounter < 10) { // If this condition is true...
				// Do something.
				Console.WriteLine($"Another counter is {anotherCounter}.");
				anotherCounter++;

				// This will only run if, and ONLY IF, the condition is true.
			}
			#endregion

			Console.WriteLine();

			#region FOR LOOPS
			// The syntax for for loops are different.
			// The counter is usually declared within the loop header.

			for (int i = 0; i < 10; i++) {
				Console.WriteLine($"Counter i is {i}.");
			}
			#endregion
		}
	}
}
