using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			 */

			Customer luiz = new Customer() {
				FirstName = "Luiz",
				LastName = "Parente",
				DateOfBirth = new DateTime(1985, 7, 15)
			};

			Account account = new Account(luiz) { 
				Balance = 1000.01
			};

			Console.WriteLine(account.ToString());
		}
	}
}
