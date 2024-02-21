using System;
using System.Collections.Generic;
using System.Text;

using LinqLambdaConsoleAppUI.Models;

namespace LinqLambdaConsoleAppUI
{
	internal static class SampleData
	{
		internal static List<PersonModel> GeneratePersonModels()
		{
			List<PersonModel> output = new List<PersonModel> {
				new PersonModel {
					Id = 1,
					FirstName = "Tim",
					LastName = "Corey",
					Employer = 1,
					Addresses = new List<int> {
						1, 2
					}
				},
				new PersonModel {
					Id = 2,
					FirstName = "Charity",
					LastName = "Corey",
					Employer = null,
					Addresses = new List<int> {
						1
					}
				},
				new PersonModel {
					Id = 3,
					FirstName = "Sue",
					LastName = "Storm",
					Employer = 3,
					Addresses = new List<int> {
						2, 3
					}
				},
				new PersonModel {
					Id = 4,
					FirstName = "Pierre",
					LastName = "Plourde",
					Employer = 2,
					Addresses = new List<int> {
						4
					}
				},
				new PersonModel {
					Id = 5,
					FirstName = "Jennifer",
					LastName = "Plourde",
					Employer = null,
					Addresses = new List<int>()
				}
			};
			return output;
		}

		internal static List<EmployerModel> GenerateEmployerModels()
		{
			List<EmployerModel> output = new List<EmployerModel> {
				new EmployerModel {
					Id = 1,
					CompanyName = "I Am Tim Corey",
					Addresses = new List<int> {
						1, 3
					}
				},
				new EmployerModel {
					Id = 2,
					CompanyName = "Spartan C#",
					Addresses = new List<int> {
						4
					}
				},
				new EmployerModel {
					Id = 3,
					CompanyName = "Anonymous",
					Addresses = new List<int>()
				},
				new EmployerModel {
					Id = 4,
					CompanyName = "The Promomotional Specialists",
					Addresses = new List<int> {
						5
					}
				},
				new EmployerModel {
					Id = 5,
					CompanyName = "Philly Freedom Corp",
					Addresses = new List<int> {
						2
					}
				}
			};
			return output;
		}

		internal static List<AddressModel> GenerateAddressModels()
		{
			List<AddressModel> output = new List<AddressModel> {
				new AddressModel {
					Id = 1,
					StreetAddress = "184 Summer Street",
					City = "Scranton",
					State = "PA",
					ZipCode = "15803"
				},
				new AddressModel {
					Id = 2,
					StreetAddress = "1875 Main Street",
					City = "Philadelphia",
					State = "PA",
					ZipCode = "15534"
				},
				new AddressModel {
					Id = 3,
					StreetAddress = "1400 Barbary Coast Road",
					City = "Houston",
					State = "TX",
					ZipCode = "28405"
				},
				new AddressModel {
					Id = 4,
					StreetAddress = "76 Delwood Drive, Upper Unit",
					City = "Scarborough",
					State = "ON",
					ZipCode = "M1L 2S7"
				},
				new AddressModel {
					Id = 5,
					StreetAddress = "351 Steelcase Road West, Unit 1",
					City = "Markham",
					State = "ON",
					ZipCode = "L3R 4H9"
				}
			};
			return output;
		}
	}
}
