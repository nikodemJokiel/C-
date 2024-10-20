using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_12_29_01.classes
{
	class Address
	{
		public string City { get; set; }
		public string Street { get; set; }
		public string HouseNumber { get; set; }
		public string PostalCode { get; set; }

		public string GetAddress()
		{
			return $"{City}, ulica{Street} {HouseNumber}, kod pocztowy {PostalCode}";
		}
	}
}
