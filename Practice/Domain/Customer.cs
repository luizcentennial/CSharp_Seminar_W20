using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Domain {
	public class Customer {
		// FIELD
		private static int ID = 1;

		// PROPERTIES
		public int CustomerID { get; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }

		// CONSTRUCTOR
		public Customer() {
			CustomerID = ID;

			ID++;
		}

		// METHODS
		public override string ToString() {
			return $"Customer ID: {CustomerID} \nFirst Name: {FirstName} \nLast Name: {LastName} \nDate Of Birth: {DateOfBirth}";
		}
	}
}
