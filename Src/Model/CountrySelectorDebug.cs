using System;
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

        private static readonly Random Rand = new Random();
        public Country GetCountryByTag(string tag)
        {
            if (tag == null || tag.Length != 3)
                return null;

            var country = new Country();
            country.Tag = tag;
            country.Continent = "Atlantida";
            country.Name = tag[0] + (tag[1].ToString() + tag[2].ToString()).ToLower();
            for (var i = 3; i < 3 + Rand.Next(7); ++i)
            {
                country.Name += (char)('a' + Rand.Next(26));
            }
            country.Capital = tag[0].ToString();
            for (var i = 3; i < 3 + Rand.Next(12); ++i)
            {
                country.Capital += (char)('a' + Rand.Next(26));
            }

            return country;
        }
    }
}