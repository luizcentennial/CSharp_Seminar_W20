using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02.Domain {
	public class Customer {
		// FIELDS
		private static int ID = 0;
		private List<Order> orders;

		// PROPERTIES
		public int CustomerID { get; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public Address Address { get; set; }
		//public List<Order> Orders { get; set; }

		// CONSTRUCTOR
		public Customer(Address address) {
			CustomerID = ID;
			Address = address;
			orders = new List<Order>();

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

		public void AddOrder(Order order) {
			orders.Add(order);
		}

		public List<Order> GetOrders() {
			return orders;
		}
	}
}
