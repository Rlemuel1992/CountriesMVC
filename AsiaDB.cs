using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
	

	class AsiaDB
	{
		public List<Country> Countries = new List<Country>();

		public AsiaDB()
		{
			string[] JapColors = { "Red", "White" };
			string[] ChinaColors = { "Red", "Gold" };
			string[] IndiaColors = { "Orange", "White", "Green", "Blue" };
			string[] QatarColors = { "Maroon", "White" };
			string[] ThaiColors = { "Maroon", "White" };

			Country JPN = new Country("Japan", "Japanese", "Kon'nichiwa sekai", JapColors);
			Country CHN = new Country("China", "Chinese", "Ni Hao Shijie", ChinaColors);
			Country IND = new Country("India", "Hindi", "Namaste Duniya", IndiaColors);
			Country QTR = new Country("Qatar", "Arabic", "Marhabaan Bialealam", QatarColors );
			Country THAI = new Country("Thailand", "Thai", "Swasdi Chaw Lok", ThaiColors );
			Countries.Add(JPN); Countries.Add(CHN); Countries.Add(IND); Countries.Add(QTR); Countries.Add(THAI);
		}
	}
}
