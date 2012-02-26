using System.Collections.Generic;

namespace Flags
{
    public class CountrySelector : ICountrySelector
    {
        public void GetCountriesByParams(ICollection<Country> list, int color, int shape, int add)
        {
            throw new System.NotImplementedException();
        }

        public void GetAllCountries(ICollection<Country> list)
        {
            throw new System.NotImplementedException();
        }

        public Country GetCountryByTag(string tag)
        {
            throw new System.NotImplementedException();
        }
    }
}