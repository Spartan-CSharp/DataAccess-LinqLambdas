using System;
using System.Collections.Generic;
using System.Linq;

using LinqLambdaConsoleAppUI.Models;

namespace LinqLambdaConsoleAppUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Query Syntax:");
			RunQueries();
			Console.WriteLine();
			Console.WriteLine("Method Syntax:");
			RunMethods();
			Console.WriteLine();
			Console.WriteLine("Done Processing!");
			_ = Console.ReadLine();
		}

		private static void RunQueries()
		{
			List<PersonModel> people = SampleData.GeneratePersonModels();
			List<EmployerModel> employers = SampleData.GenerateEmployerModels();
			List<AddressModel> addresses = SampleData.GenerateAddressModels();

			IOrderedEnumerable<PersonModel> results = from p in people where p.Addresses.Count() > 1 orderby p.LastName select p;
			foreach ( PersonModel item in results )
			{
				Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()}");
			}
		}

		private static void RunMethods()
		{
			List<PersonModel> people = SampleData.GeneratePersonModels();
			List<EmployerModel> employers = SampleData.GenerateEmployerModels();
			List<AddressModel> addresses = SampleData.GenerateAddressModels();

			IOrderedEnumerable<PersonModel> results = people.Where(x => x.Addresses.Count > 1).OrderBy(x => x.LastName).ThenBy(x => x.FirstName);
			foreach ( PersonModel item in results )
			{
				Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()}");
			}
		}
	}
}
