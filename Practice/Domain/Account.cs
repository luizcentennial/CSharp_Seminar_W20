using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Domain {
	public class Account {
		// FIELDS
		private static int ID = 1;

		// PROPERTIES
		public int AccountNumber { get; } // read only
		public double Balance { get; set; }
		public Customer Owner { get; }

		// CONSTRUCTOR
		public Account(Customer customer) {
			AccountNumber = ID;
			Owner = customer;

			ID++;
		}

		public override string ToString() {
			return $"Account Number: {AccountNumber} \nBalance: {Balance:C} \nOwner: {Owner} \n";
		}
	}
}
