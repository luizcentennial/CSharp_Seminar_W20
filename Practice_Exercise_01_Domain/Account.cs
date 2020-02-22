using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.Domain {
	public class Account {
		// FIELDS
		private static int ID = 1;
		private double balance;

		// PROPERTIES
		public int AccountNumber { get; } // read only
		public Customer Owner { get; }
		public bool Active { get; set; }
		public double Balance { 
			get {
				return balance;
			}
			private set {
				if (value > 0) {
					balance = value;
				}
			}
		}

		// CONSTRUCTOR
		public Account(Customer customer, bool active) {
			AccountNumber = ID;
			Owner = customer;
			Active = active;

			ID++;
		}

		public bool Deposit(double amount) {
			if (Active) { // Same as Active == true
				Balance += amount;
				return true;
			}

			return false;
		}

		public bool Withdraw(double amount) {
			if (Active && Balance >= amount) {
				Balance -= amount;

				return true; // If my operation is successful, return true.
			}

			return false; // If not, return false.
		}

		public override string ToString() {
			return	$"Account Number: {AccountNumber} \n" +
					$"Balance: {Balance:C} \n" +
					$"Owner: {Owner} \n";
		}
	}
}
