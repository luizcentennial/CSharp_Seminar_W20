using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Exercise_02.Domain;

namespace Practice_Exercise_02 {
	class Program {
		static void Main(string[] args) {
			/*
			Write a program for a pizza place.
			The program has to process orders made by the phone or online.
			Create the necessary classes, with fields and properties, that allow
			the program to handle all orders.

			Classes needed:
			- Customer (first name, last name, phone number, email and address). Use struct.
			- Pizza (size, toppings, price). Use Enum.
			- Order (order total, customer, one or more pizzas, date placed, date delivered, 
			  delivered, order type). Use array of objects and enum.

			All entities must have their own ID's, which must increment.
			
			Price calculation:
			Small: 10, Medium: 15, Large: 20.
			Each topping: 5.
			*/

			// Creating customer
			Customer customer = new Customer(new Address() { 
				AddressLine1 = "123 Test Drive",
				AddressLine2 = "Suite 1",
				City = "Toronto",
				ZipCode = "A1B2C3",
				Province = "ON",
				Country = "Canada"
			});

			customer.FirstName = "Luiz";
			customer.LastName = "Parente";
			customer.PhoneNumber = "123-123-1234";
			customer.Email = "lparent2@my.centennialcollege.ca";
			customer.DateOfBirth = new DateTime(1985, 7, 15);
			
			// Creating Pizzas
			Pizza pizza1 = new Pizza(Size.Large);
			pizza1.AddTopping(Topping.Vegan);
			pizza1.AddTopping(Topping.Cheese);

			Pizza pizza2 = new Pizza(Size.Medium);
			pizza2.AddTopping(Topping.Beef);
			pizza2.AddTopping(Topping.Ham);
			pizza2.AddTopping(Topping.Cheese);

			pizza2.AddTopping(Topping.Vegan);
			pizza2.RemoveTopping(Topping.Vegan);

			// Creating order
			Order order = new Order(customer);
			order.AddItem(pizza1);
			order.AddItem(pizza2, 3);

			// Delivering the order
			Thread.Sleep(1000);
			order.Deliver();

			// Displaying order
			order.DisplayOrderInfo();
		}
	}
}
