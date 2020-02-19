using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Recap_DataTypes {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens.

			#region INPUT AND OUTPUT
			// OUTPUT
			// Displaying a message
			Console.WriteLine("Please input your name: ");

			// INPUT
			// Grabbing user input
			string name = Console.ReadLine();

			// Printing a nice message:
			Console.WriteLine($"Hello there, {name}!");
			#endregion

			#region DATA TYPES
			// What are the data types you know?
			// Integers
			// Strings
			// Doubles
			// Booleans
			// Characters
			// Longs
			// Decimals
			// Etc...

			// Creating an integer variable:
			int myInteger = 1;

			// Creating a double variable:
			double myDouble = 3.14;

			// Creating a string variable:
			string myString = "Centennial College"; // Must be double quotes.

			// Creating a boolean variable:
			bool myBoolean = true; //false;

			// Creating a character variable:
			char myChar = 'Z'; // Must be single quotes.
			#endregion

			#region CONVERTING DATA TYPES
			// You have a variable type string:
			string input = "4";


			// Using Convert.To... Method

			// You convert it to an integer
			int convertedInt = Convert.ToInt32(input);

			// You can also convert it to a char
			char convertedChar = Convert.ToChar(input);

			// Or you can convert it to a double
			double convertedDouble = Convert.ToDouble(input);


			// Using xxx.Parse()
			int anotherInteger = int.Parse(input);
			double anotherDouble = double.Parse(input);


			// Using explicit casting
			// Used to convert between data types THAT ARE NOT STRINGS
			char inputAsChar = 'a';
			int inputAsInt = (int)inputAsChar;

			// This is explicit casting - It means it is happening, and you can see it.
			// If it were implicit, it would be there, but you would not see it.
			#endregion
		}
	}
}
