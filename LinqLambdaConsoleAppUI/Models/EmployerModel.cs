using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLambdaConsoleAppUI.Models
{
	internal class EmployerModel
	{
		internal int Id { get; set; }
		internal string CompanyName { get; set; }
		internal List<int> Addresses { get; set; }
	}
}
