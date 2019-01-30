using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
	class CountryViewer
	{
		public void ContView()
		{
			Console.WriteLine("What continent would you like to learn about? \n" +
							  "1. North America \n" +
								"2. Asia \n");
		}
		public void LoopFalse()
		{
			Console.WriteLine("Wrong input, try again.\n");
		}
	}
}
