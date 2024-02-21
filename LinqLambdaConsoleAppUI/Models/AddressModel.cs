using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLambdaConsoleAppUI.Models
{
	internal class AddressModel
	{
		internal int Id { get; set; }
		internal string StreetAddress { get; set; }
		internal string City { get; set; }
		internal string State { get; set; }
		internal string ZipCode { get; set; }
	}
}
