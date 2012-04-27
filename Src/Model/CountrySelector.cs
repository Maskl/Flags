using System;
using System.Collections.Generic;
using System.Linq;

namespace Flags
{
    public class CountrySelector : ICountrySelector
    {
        private readonly FlagDataContext _flagsDB;

        public CountrySelector()
        {
#if WINDOWS_PHONE
            const string dbConnectionString = "Data Source='appdata:/Media/flags.sdf';" +
                                  "Mode='read only'";
#else
            const string dbConnectionString = "Data Source='Media/flags.sdf';" +
                                              "Mode='read only';" +
                                              "Temp File Directory='Media/'";
#endif
            _flagsDB = new FlagDataContext(dbConnectionString);
        }

        public void GetCountriesByParams(ICollection<Country> list, int color, int shape, int add)
        {
            list.Clear();

            var colTab = new int[7];
            for (var i = 0; i < colTab.Length; ++i)
            {
                colTab[i] = (color & (1 << i)) == 0 ? 1 : -1;
            }

            var maxShapePenalty = (shape & (1 << 6)) == 0 ? -1 : 0;
            var shaTab = new int[6];
            for (var i = 0; i < shaTab.Length; ++i)
            {
                shaTab[i] = (shape & (1 << i)) == 0 ? 1 : maxShapePenalty;
            }

            var addTab = new int[8];
            for (var i = 0; i < addTab.Length; ++i)
            {
                addTab[i] = (add & (1 << i)) == 0 ? 1 : -1;
            }

            // \ + / = X
            if (addTab[6] < 0 && addTab[7] < 0)
            {
                addTab[6] = addTab[7] = 1;
                addTab[5] = -1;
            }

            var usedColors = (colTab[0] < 0 || colTab[1] < 0 || colTab[2] < 0 || colTab[3] < 0 || colTab[4] < 0 || colTab[5] < 0 || colTab[6] < 0);
            var usedShapes = (shaTab[0] < 0 || shaTab[1] < 0 || shaTab[2] < 0 || shaTab[3] < 0 || shaTab[4] < 0 || shaTab[5] < 0);
            var usedAdds = (addTab[0] < 0 || addTab[1] < 0 || addTab[2] < 0 || addTab[3] < 0 || addTab[4] < 0 || addTab[5] < 0 || addTab[6] < 0 || addTab[7] < 0);

            if (!usedColors)
                colTab[0] = colTab[1] = colTab[2] = colTab[3] = colTab[4] = colTab[5] = colTab[6] = 1;

            if (!usedShapes)
                shaTab[0] = shaTab[1] = shaTab[2] = shaTab[3] = shaTab[4] = shaTab[5] = 1;

            if (!usedAdds)
                addTab[0] = addTab[1] = addTab[2] = addTab[3] = addTab[4] = addTab[5] = addTab[6] = addTab[7] = 1;

            var flags = (from f in _flagsDB.Flags orderby (
                f.Col1 * colTab[0] +
                f.Col2 * colTab[1] +
                f.Col3 * colTab[2] +
                f.Col4 * colTab[3] +
                f.Col5 * colTab[4] +
                f.Col6 * colTab[5] +
                f.Col7 * colTab[6] +

                f.Sha1 * shaTab[0] +
                f.Sha2 * shaTab[1] +
                f.Sha3 * shaTab[2] +
                f.Sha4 * shaTab[3] +
                f.Sha5 * shaTab[4] +
                f.Sha6 * shaTab[5] +

                f.Add1 * addTab[0] +
                f.Add2 * addTab[1] +
                f.Add3 * addTab[2] +
                f.Add4 * addTab[3] +
                f.Add5 * addTab[4] +
                f.Add6 * addTab[5] +
                f.Add7 * addTab[6] +
                f.Add8 * addTab[7]
            ) select f).Take(16);


            //var flags = _flagsDB.Flags.OrderBy(f => 
            //    f.Col1 * colTab[0] + 
            //    f.Col2 * colTab[1] + 
            //    f.Col3 * colTab[2] + 
            //    f.Col4 * colTab[3] + 
            //    f.Col5 * colTab[4] + 
            //    f.Col6 * colTab[5] + 
            //    f.Col7 * colTab[6] + 

            //    f.Sha1 * shaTab[0] + 
            //    f.Sha2 * shaTab[1] + 
            //    f.Sha3 * shaTab[2] + 
            //    f.Sha4 * shaTab[3] + 
            //    f.Sha5 * shaTab[4] + 
            //    f.Sha6 * shaTab[5] + 

            //    f.Add1 * addTab[0] + 
            //    f.Add2 * addTab[1] + 
            //    f.Add3 * addTab[2] + 
            //    f.Add4 * addTab[3] + 
            //    f.Add5 * addTab[4] + 
            //    f.Add6 * addTab[5] + 
            //    f.Add7 * addTab[6] + 
            //    f.Add8 * addTab[7]
            //);

            /*
             *                 +


                ((f.Col1 == 0) ? -colTab[0] : 0) +
                ((f.Col2 == 0) ? -colTab[1] : 0) +
                ((f.Col3 == 0) ? -colTab[2] : 0) +
                ((f.Col4 == 0) ? -colTab[3] : 0) +
                ((f.Col5 == 0) ? -colTab[4] : 0) +
                ((f.Col6 == 0) ? -colTab[5] : 0) +
                ((f.Col7 == 0) ? -colTab[6] : 0) +

                ((f.Sha1 == 0) ? -shaTab[0] : 0) +
                ((f.Sha2 == 0) ? -shaTab[1] : 0) +
                ((f.Sha3 == 0) ? -shaTab[2] : 0) +
                ((f.Sha4 == 0) ? -shaTab[3] : 0) +
                ((f.Sha5 == 0) ? -shaTab[4] : 0) +
                ((f.Sha6 == 0) ? -shaTab[5] : 0) +

                ((f.Add1 == 0) ? -addTab[0] : 0) +
                ((f.Add2 == 0) ? -addTab[1] : 0) +
                ((f.Add3 == 0) ? -addTab[2] : 0) +
                ((f.Add4 == 0) ? -addTab[3] : 0) +
                ((f.Add5 == 0) ? -addTab[4] : 0) +
                ((f.Add6 == 0) ? -addTab[5] : 0) +
                ((f.Add7 == 0) ? -addTab[6] : 0) +
                ((f.Add8 == 0) ? -addTab[7] : 0)*/

            foreach (var flag in flags)
            {
                //var f = flag;
                //int val = f.Col1*colTab[0] +
                //          f.Col2*colTab[1] +
                //          f.Col3*colTab[2] +
                //          f.Col4*colTab[3] +
                //          f.Col5*colTab[4] +
                //          f.Col6*colTab[5] +
                //          f.Col7*colTab[6] +

                //          f.Sha1*shaTab[0] +
                //          f.Sha2*shaTab[1] +
                //          f.Sha3*shaTab[2] +
                //          f.Sha4*shaTab[3] +
                //          f.Sha5*shaTab[4] +
                //          f.Sha6*shaTab[5] +

                //          f.Add1*addTab[0] +
                //          f.Add2*addTab[1] +
                //          f.Add3*addTab[2] +
                //          f.Add4*addTab[3] +
                //          f.Add5*addTab[4] +
                //          f.Add6*addTab[5] +
                //          f.Add7*addTab[6] +
                //          f.Add8*addTab[7];
                list.Add(new Country { Capital = flag.Capital, Continent = flag.Continent, Name = flag.Country, Tag = flag.Iso.ToLower(), FirstLetter = flag.Country[0]});
            }
        }

        public void GetAllCountries(ICollection<Country> list)
        {
            list.Clear();
            var flags = _flagsDB.Flags.OrderBy(f => (f.Country));
            foreach (var flag in flags)
            {
                list.Add(new Country { Capital = flag.Capital, Continent = flag.Continent, Name = flag.Country, Tag = flag.Iso.ToLower(), FirstLetter = flag.Country[0] });
            }
        }

        public Country GetCountryByTag(string uri)
        {
            var tag = uri.Contains("?") ? uri.Substring(uri.IndexOf("?", StringComparison.Ordinal) + 1) : uri;
            if (tag.Length != 2)
                return null;

            var flag = _flagsDB.Flags.Single(f => f.Iso == tag);
            return new Country { Capital = flag.Capital, Continent = flag.Continent, Name = flag.Country, Tag = flag.Iso.ToLower(), FirstLetter = flag.Country[0] };
        }
    }
}