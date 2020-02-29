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
		private List<OrderItem> items;
		private double total;

		// PROPERTIES
		public int OrderID { get; } // read only
		public Customer Customer { get; set; }
		public double Total { // read only
			get {
				return total;
			}
		}
		public List<OrderItem> Items { // read only
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
			items = new List<OrderItem>();
			total = 0;
			DatePlaced = DateTime.Now; // Always use UTC, though.

			ID++;
		}

		public void AddItem(Pizza pizza, int quantity = 1) {
			if (quantity > 0) {
				items.Add(new OrderItem() { Pizza = pizza, Quantity = quantity });
				CalculateTotal();
			}
		}

		public void RemoveItem(Pizza pizza) {
			Items.Where(i => i.Pizza != pizza);
			CalculateTotal();
		}

		public void CalculateTotal() {
			double total = 0;

			foreach (var item in Items) {
				total += item.ItemTotal;
			}

			this.total = total;
		}

		public void Deliver() {
			DateDelivered = DateTime.Now;
		}

		public void DisplayOrderInfo() {
			string delivered = IsDelivered ? $"Delivered at {DateDelivered}" : "Order not delivered yet.";

			Console.WriteLine(Customer);
			Console.WriteLine($"Order ID: {OrderID} \n" +
								$"Customer ID: {Customer.CustomerID} \n" +
								$"Order Total: {Total:C} \n" +
								$"Date Placed: {DatePlaced} \n" +
								$"Date Delivered: {delivered} \n");

			// Headers
			Console.WriteLine($"{"Pizza ID",-10} {"Size",-10} {"Toppings",-30} {"Unit Price",-10} {"Quantity", -10} {"SubTotal", -10}");

			// Lines
			foreach (var item in items) {
				string toppings = string.Join(", ", item.Pizza.Toppings);

				Console.WriteLine($"{item.Pizza.PizzaID,-10} {item.Pizza.Size,-10} {toppings,-30} {item.Pizza.Price,-10:C} {item.Quantity,-10} {item.ItemTotal,-10:C}");
			}
		}
	}

	public enum Type {
		Phone,
		Online
	}
}
