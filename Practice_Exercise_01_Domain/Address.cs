using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.Domain {
	public struct Address {
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
		public string City { get; set; }
		public string Province { get; set; }
		public string Country { get; set; }
		public string ZipCode { get; set; }

		public override string ToString() {
			return	$"Address Line 1: {AddressLine1} \n" +
					$"Address Line 2: {AddressLine2} \n" +
					$"City: {City} \n" +
					$"ZipCode: {ZipCode} \n" +
					$"Country: {Country}";
		}
	}
}
