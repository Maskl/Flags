using System.Collections.Generic;

namespace Flags
{
    public class CountrySelector : ICountrySelector
    {
        public void GetCountriesByParams(ICollection<Country> list, int color, int shape, int add)
        {
            list.Clear();
        }

        public void GetAllCountries(ICollection<Country> list)
        {
            list.Clear();
        }

        public Country GetCountryByTag(string tag)
        {
            return null;
        }
    }
}