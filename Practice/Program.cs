using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_01.Domain;

namespace Practice_Exercise_01 {
	class Program {
		static void Main(string[] args) {
			/*
			 You are writing a program for a bank.
			 The bank would like to keep track of customers and their accounts.
			 Create a program that allows for the creation of customer accounts,
			 and also keep track of account owner information (customer first name,
			 last name, date of birth) and account information (account number, 
			 balance, owner).

			 For security reasons, the Balance property has to be private set.

			 Create methods that allow for withdrawals and deposits. Make sure that
			 the balance is never negative.
			*/

			Address address = new Address() { 
				AddressLine1 = "1 Test Street",
				AddressLine2 = "Apt 123",
				City = "Toronto",
				Province = "ON",
				ZipCode = "A1B2C3",
				Country = "Canada"
			};

			Customer luiz = new Customer(address) {
				FirstName = "Luiz",
				LastName = "Parente",
				DateOfBirth = new DateTime(1985, 7, 15)
			};

			// Because my Balance property is private set, the code below errors
			//Account account = new Account(luiz) { 
			//	Balance = 1000.01
			//};

			Account account = new Account(luiz, true);

			// Making a deposit of $100.00, the wrong way.
			//account.Balance += 100; // account.Balance = account.Balance + 100;

			// Making a deposit of $100.00, the right way.
			bool depositSuccessful = account.Deposit(100.00);

			if (depositSuccessful) // Same as if (depositSuccessful == true)
				Console.WriteLine($"Deposit successful! Your new balance is {account.Balance:C}.");
			else
				Console.WriteLine($"Deposit not successful. Your balance is {account.Balance:C}.");

			// Make a withdrawal of $20.00.
			bool withdrawalSuccessful = account.Withdraw(20.00);

			if (withdrawalSuccessful)
				Console.WriteLine($"Withdrawal successful! Your new balance is {account.Balance:C}.");
			else
				Console.WriteLine($"Withdrawal not successful. Your balance is {account.Balance:C}.");

			Console.WriteLine("\n" + account.ToString());
		}
	}
}
