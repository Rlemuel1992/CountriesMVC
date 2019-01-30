using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
	class NorthAmericanDB
	{
		public List<Country> Countries = new List<Country>();

		public NorthAmericanDB()
		{
			string[] USColor = { "Red", "White", "Blue" };
			string[] CNColor = { "Red", "White", "Maple Leaves" };
			string[] MXColor = { "Red", "White", "Green" };

			Country USA = new Country("USA", "English", "Hello World", USColor);
			Country Can = new Country("Canada", "English", "Hello Eh", CNColor);
			Country Mex = new Country("Mexico", "Spanish", "Hola Mundo", MXColor);
			Country Cuba = new Country("Cuba", "Spanish", "Hola Mundo", USColor);
			Country Dom = new Country("Domincan Republic", "Spanish", "Hola Mundo", USColor);
			Countries.Add(USA); Countries.Add(Mex); Countries.Add(Can); Countries.Add(Cuba); Countries.Add(Dom);
		
		}
	}
}
