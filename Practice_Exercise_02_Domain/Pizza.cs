using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02.Domain {
	public class Pizza {
		// FIELDS
		private static int ID = 0;
		private double price;
		private List<Topping> toppings;
		private Size size;

		// PROPERTIES
		public int PizzaID { get; } // read only
		public Size Size { // read only
			get {
				return size;
			}
		}
		public List<Topping> Toppings { // read only
			get {
				return toppings;
			}
		}
		public double Price {
			get {
				return price;
			}
			private set {
				if (value >= 0)
					price = value;
			}
		}

		// CONSTRUCTORS
		public Pizza(Size size) {
			PizzaID = ID;
			toppings = new List<Topping>();
			this.size = size;
			//size = Size.Medium; // If working with default values

			ID++;
		}

		// METHODS
		public void AddTopping(Topping topping) {
			toppings.Add(topping);
			CalculatePrice();
		}

		public void RemoveTopping(Topping topping) {
			if (toppings.Contains(topping)) {
				toppings.Remove(topping);

				CalculatePrice();
			}
		}

		public void SetSize(Size size) {
			this.size = size;
			CalculatePrice();
		}

		private void CalculatePrice() {
			// Small: 10, Medium: 15, Large: 20.
			// Each topping: 5.

			double price = 0;

			if (size == Size.Small)
				price = 10;
			else if (size == Size.Medium)
				price = 15;
			else
				price = 20;

			price += toppings.Count * 5;

			this.price = price;
		}
	}

	public enum Size {
		Small,
		Medium,
		Large
	}

	public enum Topping {
		Cheese,
		Pepperoni,
		Beef,
		Ham,
		Pork,
		Vegan
	}
}
