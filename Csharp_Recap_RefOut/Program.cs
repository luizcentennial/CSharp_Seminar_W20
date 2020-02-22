using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Recap_RefOut {
	class Program {
		static void Main(string[] args) {
			// Ref requires you to initialize the variable
			int myNumber = 1;
			ChangeRefValue(ref myNumber);
			Console.WriteLine(myNumber);

			// Out does not require you to initialize the variable
			int myOtherNumber;
			ChangeOutValue(out myOtherNumber);
			Console.WriteLine(myOtherNumber);
		}

		public static void ChangeRefValue(ref int number) {
			number++;
		}

		public static void ChangeOutValue(out int number) {
			number = 5;
		}
	}
}
