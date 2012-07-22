using System;
using System.ComponentModel;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace FlagsW8.Model
{
    public class Country
    {
        static public int BoxSize { get; set; }
        static public int MaxImageSizeX { get; set; }
        static public int MaxImageSizeY { get; set; }

        public string Iso { get; set; }
        public char FirstLetter { get; set; }

        public string Name { get; set; }
        public string Continent { get; set; }
        public string Capital { get; set; }

        public string NamePL { get; set; }
        public string ContinentPL { get; set; }
        public string CapitalPL { get; set; }
        
        public short[] Col { get; set; }
        public short[] Sha { get; set; }
        public short[] Add { get; set; }

        public Country()
        {
            Iso = "pl";
            FirstLetter = 'P';

            Name = "Poland";
            NamePL = "Polska";

            Capital = "Warsaw";
            CapitalPL = "Warszawa";

            Continent = "Europe";
            ContinentPL = "Europa";

            Col = new short[8];
            Sha = new short[7];
            Add = new short[9];
        }

        public Country(string iso, string name, string continent, string capital, short c0, short c1, short c2, short c3, short c4, short c5, short c6, short s0, short s1, short s2, short s3, short s4, short s5, short a0, short a1, short a2, short a3, short a4, short a5, short a6, short a7, string namePL, string continentPL, string capitalPL)
        {
            Iso = iso;
            FirstLetter = iso[0];

            Name = name;
            NamePL = namePL;

            Capital = capital;
            CapitalPL = capitalPL;

            Continent = continent;
            ContinentPL = continentPL;

            Col = new[] { c0, c1, c2, c3, c4, c5, c6     };
            Sha = new[] { s0, s1, s2, s3, s4, s5         };
            Add = new[] { a0, a1, a2, a3, a4, a5, a6, a7 };
        }


        public string ShortDescription
        {
            get { return Continent + "\n" + Name + "\n" + Capital; }
        }

        public override string ToString()
        {
            return "(" + Iso + ") " + Name + " - " + Continent + " - " + Capital;
        }

        private ImageSource _bigImage;
        public ImageSource BigImage
        {
            get { return _bigImage ?? (_bigImage = new BitmapImage(new Uri("ms-appx:///Media/Flags/300/" + Iso.ToLower() + ".png"))); }
        }

        private ImageSource _smallImage;
        public ImageSource SmallImage
        {
            get { return _smallImage ?? (_smallImage = new BitmapImage(new Uri("ms-appx:///Media/Flags/300x200/" + Iso.ToLower() + ".png"))); }
        }
    }
}
