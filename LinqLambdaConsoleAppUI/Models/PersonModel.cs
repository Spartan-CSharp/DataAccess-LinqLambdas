using System.Collections.Generic;

namespace LinqLambdaConsoleAppUI.Models
{
	internal class PersonModel
	{
		internal int Id { get; set; }
		internal string FirstName { get; set; }
		internal string LastName { get; set; }
		internal bool IsActive { get; set; }
		internal int? Employer { get; set; }
		internal List<int> Addresses { get; set; }
	}
}
