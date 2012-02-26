using System.Collections.Generic;

namespace Flags
{
    public class CountrySelectorDebug : ICountrySelector
    {
        public void GetCountriesListByParams(ICollection<Country> list, int color, int shape, int add)
        {
            list.Clear();
            if (color % 2 == 0) list.Add(new Country { Tag = "POL", Name = "Poland", Continent = "Europe", Capital = "Warsaw" });
            if (color % 2 != 0) list.Add(new Country { Tag = "USA", Name = "United States", Continent = "North America", Capital = "Washington" });
            if (shape % 3 == 0) list.Add(new Country { Tag = "AUT", Name = "Austria", Continent = "Europe", Capital = "Vien" });
            if (shape % 4 == 0) list.Add(new Country { Tag = "JAP", Name = "Japan", Continent = "Asia", Capital = "Tokyo" });
            if (add % 2 != 0) list.Add(new Country { Tag = "NOR", Name = "Norway", Continent = "Europe", Capital = "Oslo" });
            if (add % 3 != 0) list.Add(new Country { Tag = "ARG", Name = "Argentina", Continent = "South America", Capital = "Buenos Aires" });
        }
    }
}