using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
	class CountryDetails
	{
		// My write line that pulls from my constructor, Country class.
		Country Country;
		public CountryDetails(Country Country)
		{
			this.Country = Country;
		}
		
		public void Display()
		{
			Console.WriteLine("********************");
			Console.WriteLine("Country: " + Country.Name);
			Console.WriteLine("Language: " + Country.Lang);
			Console.WriteLine("Greetings: " + Country.Hello);
			Console.WriteLine("*******Colors*******");
			foreach (string color in Country.Colors)
			{
				Console.WriteLine(color);
			}
			Console.WriteLine("********************");
		}
	}
}
	

