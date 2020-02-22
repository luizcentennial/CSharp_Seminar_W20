using Exercise_02.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02.Domain {
	public class Order {
		// FIELDS
		private static int ID = 0;
		private List<Pizza> items;
		private double total;

		// PROPERTIES
		public int OrderID { get; } // read only
		public Customer Customer { get; set; }
		public double Total { // read only
			get {
				return total;
			}
		}
		public List<Pizza> Items { // read only
			get {
				return items;
			}
		}
		public DateTime DatePlaced { get; private set; }
		public DateTime? DateDelivered { get; private set; }
		public bool IsDelivered { 
			get {
				return DateDelivered != null;
			} 
		}
		public Type OrderType { get; set; }

		// CONSTRUCTORS
		public Order(Customer customer) {
			OrderID = ID;
			Customer = customer;
			items = new List<Pizza>();
			total = 0;
			DatePlaced = DateTime.Now; // Always use UTC, though.

			ID++;
		}

		public void AddItem(Pizza pizza) {
			items.Add(pizza);
			CalculateTotal();
		}

		public void RemoveItem(Pizza pizza) {
			if (items.Contains(pizza)) {
				items.Remove(pizza);
			}

			CalculateTotal();
		}

		public void CalculateTotal() {
			double total = 0;

			foreach (var item in items) {
				total += item.Price;
			}

			this.total = total;
		}

		public void Deliver() {
			DateDelivered = DateTime.Now;
		}

		public void DisplayOrderInfo() {
			string delivered = IsDelivered ? $"Delivered at {DateDelivered}" : "Order not delivered yet.";

			Console.WriteLine(Customer);
			Console.WriteLine(	$"Order ID: {OrderID} \n" +
								$"Customer ID: {Customer.CustomerID} \n" +
								$"Order Total: {Total:C} \n" +
								$"Date Placed: {DatePlaced} \n" +
								$"Date Delivered: {delivered} \n");
								
			// Headers
			Console.WriteLine($"{"Pizza ID", -20} {"Size", -20} {"Toppings", -50} {"Price", -20}");

			// Lines
			foreach (var item in items) {
				string toppings = string.Join(", ", item.Toppings);
				
				Console.WriteLine($"{item.PizzaID, -20} {item.Size, -20} {toppings, -50} {item.Price, -20:C}");
			}
		}
	}

	public enum Type {
		Phone,
		Online
	}
}
