using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02.Domain {
	public class OrderItem {
		private static int ID = 0;

		public int ItemID { get; set; }
		public Pizza Pizza { get; set; }
		public int Quantity { get; set; }
		public double ItemTotal { get => Quantity * Pizza.Price; }

		public OrderItem() {
			ItemID = ID;

			ID++;
		}
	}
}
