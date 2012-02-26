using System.Collections.Generic;

namespace Flags
{
    public interface ICountrySelector
    {
        void GetCountriesListByParams(ICollection<Country> list, int color, int shape, int add);
        Country GetCountryByTag(string tag);
    }
}