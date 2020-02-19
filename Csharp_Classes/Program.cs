using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Part_01 {
	class Program {
		static void Main(string[] args) {
			// I can use my class here.
			// Creating an object of type Person - or INSTANTIATING class Person.
			Person luiz = new Person();

			// I can give this person a name
			luiz.Name = "Luiz";
			luiz.DateOfBirth = new DateTime(1985, 7, 15);
			luiz.Age = 34;

			// I cannot give this person an ID, because PersonID is private set
			//luiz.PersonID = 2;

			Console.WriteLine(luiz.ToString());

			// Instantiating another Person object
			Person venu = new Person() { 
				Name = "Venu",
				DateOfBirth = new DateTime(1998, 2, 27),
				Age = 21,
				Gender = 'M'
			};

			Console.WriteLine(venu.ToString());

			Person mary = new Person("Mary", new DateTime(2000, 1, 1));

			Console.WriteLine(mary.ToString());

			mary.Greet(luiz.Name);
		}
	}
}
