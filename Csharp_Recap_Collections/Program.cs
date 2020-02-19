using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Recap_Collections {
	class Program {
		static void Main(string[] args) {
			// Collections are "variables" that are able to hold
			// multiple values at the same time

			// There are many different types of collection:
			// - Arrays
			// - Lists
			// - ArrayLists
			// - Dictionaties
			// - Queue - FIFO
			// - Stack - FILO

			#region ARRAYS
			// This holds a single value
			int number = 2;

			// This holds multiple values
			int[] array = new int[5]; // This creates an array of size 5.

			// Another way to declare an array:
			string[] names = { "Luiz", "Centennial", "", null }; // Any possible value a string can have.

			#endregion

			#region LISTS
			// Lists are similar to arrays, but smarter.
			// That is because they increase size automatically.
			// When you create a new list you do not have to define its size.

			// Declaring and initializing a list
			List<int> list = new List<int>();

			// Add values to a list
			list.Add(1);
			list.Add(5);
			list.Add(10);

			// If I want to visualize my list I have to iterate over the list
			
			foreach (int i in list) {
				Console.WriteLine(i);
			}
			#endregion
		}
	}
}
