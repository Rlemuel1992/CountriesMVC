using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
	//The controller for the entire project minus the PlayAgain class.
	class CountryController
	{
		public void CountryDetails(Country c)
		{
			CountryDetails cd = new CountryDetails(c);
			cd.Display();
		}

		public void CountryMenu()
		{
			CountryViewer q = new CountryViewer();
			q.ContView();
			bool contRun = true;
			while (contRun == true)
			{
				string input = Console.ReadLine();
				List<Country> countries;
				if (input == "1")
				{
					bool AmericaLoop = true;
					while (AmericaLoop == true)
					{
						NorthAmericanDB nadb = new NorthAmericanDB();
						countries = nadb.Countries;
						int num = 1;
						foreach (Country c in countries)
						{
							Console.WriteLine(num + ". " + c.Name);
							num++;
						}

						q.PickAmerica();
						int.TryParse(Console.ReadLine(), out int index);
						if (index > 0 && index <= 5)
						{
							Country c = countries[index - 1];
							CountryDetails(c);
							contRun = false;
							AmericaLoop = false;
						}
						else
						{
							q.LoopFalse();
							AmericaLoop = true;
						}
					}

				}
				else if (input == "2")
				{
					bool AsiaLoop = true;
					while (AsiaLoop == true)
					{
						AsiaDB aDB = new AsiaDB();
						countries = aDB.Countries;
						int num = 1;
						foreach (Country c in countries)
						{
							Console.WriteLine(num + ". " + c.Name);
							num++;
						}
						q.PickAsia();
						int.TryParse(Console.ReadLine(), out int index);
						if (index > 0 && index <= 5)
						{
							Country c = countries[index - 1];
							CountryDetails(c);
							contRun = false;
							AsiaLoop = false;
						}
						else
						{
							q.LoopFalse();
							AsiaLoop = true;
							
						}
					}
				}

				else
				{
					q.LoopFalse();
					contRun = true;
				}
			}
			PlayAgain another = new PlayAgain();
			PlayAgain.Again();
		}	
	}
}
