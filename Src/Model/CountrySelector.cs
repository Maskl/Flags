using System.Collections.Generic;
using System.Linq;

namespace Flags
{
    public class CountrySelector : ICountrySelector
    {
        private readonly FlagDataContext _flagsDB;

        public CountrySelector()
        {
            // WP7? const string dbConnectionString = "datasource='appdata:/flags.sdf'; mode='read only'";
            const string dbConnectionString = "Data Source='Media/flags.sdf';" +
                                              "Mode='read only';" +
                                              "Temp File Directory='Media/'";

            _flagsDB = new FlagDataContext(dbConnectionString);
        }

        public void GetCountriesByParams(ICollection<Country> list, int color, int shape, int add)
        {
            list.Clear();

            foreach (var flag in (from f in _flagsDB.Flags orderby f.Country select f))
            {
                list.Add(new Country { Capital="TEst", Continent = "fdsfas", Name = flag.Country, Tag = "pl"});
            }

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