using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.Domain {
	public class Customer {
		// FIELDS
		private static int ID = 1;

		// PROPERTIES
		public int CustomerID { get; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public Address Address { get; set; }

		// CONSTRUCTOR
		public Customer(Address address) {
			CustomerID = ID;
			Address = address;

			ID++;
		}

		// METHODS
		public override string ToString() {
			return	$"Customer ID: {CustomerID} \n" +
					$"First Name: {FirstName} \n" +
					$"Last Name: {LastName} \n" +
					$"Date Of Birth: {DateOfBirth} \n" +
					$"Address: {Address} \n";
		}
	}
}
