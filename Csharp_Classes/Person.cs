using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Part_01 {
	public class Person {
		// FIELDS
		// This exists on its own. It is its own thing, independent of objects.
		private static int COUNTER_ID = 0;

		// PROPERTIES
		// Properties are usually public 
		// The properties below exist within each object
		public int PersonID { get; private set; }
		public string Name { get; set; } // get means retrieve, and set means define.
		public DateTime DateOfBirth { get; set; }
		public int Age { get; set; }
		public char Gender { get; set; }
		public DateTime CreatedDate { get; } // By removing the "set", I make this property read-only


		// CONSTRUCTORS
		// Constructors are methods that construct an object.

		// Default constructors are implicitly defined by C# IN CASE no constructors are explicitly implemented.

		// I can also explicitly define a default constructor.
		// When constructors are defined explicitly, C# WILL NOT automatically create a default constructor for me.

		// This is my new default constructor
		public Person() {
			PersonID = COUNTER_ID;
			CreatedDate = DateTime.UtcNow;

			COUNTER_ID++;
		}

		// Defining overloaded constructors
		public Person(string name, DateTime dateOfBirth) {
			PersonID = COUNTER_ID;
			Name = name;
			DateOfBirth = dateOfBirth;
			CreatedDate = DateTime.UtcNow;

			COUNTER_ID++;
		}


		// METHOD
		public override string ToString() {
			string result = $"Person ID: {PersonID} \nName: {Name} \nDate Of Birth: {DateOfBirth} \nAge: {Age} \nGender: {Gender} \nCreated Date UTC: {CreatedDate} \n";

			return result;
		}

		public void Greet(string name = null) {
			if (name != null)
				Console.WriteLine($"{Name} says hello to {name}!");
			else
				Console.WriteLine($"{Name} says hello!");
		}
	}
}
