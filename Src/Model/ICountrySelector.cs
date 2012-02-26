using System.Collections.Generic;

namespace Flags
{
    public interface ICountrySelector
    {
        void GetCountriesByParams(ICollection<Country> list, int color, int shape, int add);
        void GetAllCountries(ICollection<Country> list);
        Country GetCountryByTag(string tag);
    }
}