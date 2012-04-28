using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Flags
{
    public class FlagDataContext : DataContext
    {
        public FlagDataContext(string connectionString)
            : base(connectionString)
        {
            
        }

        public Table<Flag> Flags;
    }

    [Table]
    public class Flag : INotifyPropertyChanged, INotifyPropertyChanging
    {
        private string _iso;
        [Column(IsPrimaryKey = true)]
        public string Iso 
        {
            get { return _iso; }
            set { S("Iso"); _iso = value; E("Iso"); }
        }

        private string _country;
        [Column]
        public string Country
        {
            get { return _country; }
            set { S("Country"); _country = value; E("Country"); }
        }

        private string _continent;
        [Column]
        public string Continent
        {
            get { return _continent; }
            set { S("Continent"); _continent = value; E("Continent"); }
        }

        private string _capital;
        [Column]
        public string Capital
        {
            get { return _capital; }
            set { S("Capital"); _capital = value; E("Capital"); }
        }

        private short _col1;
        [Column]
        public short Col1
        {
            get { return _col1; }
            set { S("Col1"); _col1 = value; E("Col1"); }
        }

        private short _col2;
        [Column]
        public short Col2
        {
            get { return _col2; }
            set { S("Col2"); _col2 = value; E("Col2"); }
        }

        private short _col3;
        [Column]
        public short Col3
        {
            get { return _col3; }
            set { S("Col3"); _col3 = value; E("Col3"); }
        }

        private short _col4;
        [Column]
        public short Col4
        {
            get { return _col4; }
            set { S("Col4"); _col4 = value; E("Col4"); }
        }

        private short _col5;
        [Column]
        public short Col5
        {
            get { return _col5; }
            set { S("Col5"); _col5 = value; E("Col5"); }
        }

        private short _col6;
        [Column]
        public short Col6
        {
            get { return _col6; }
            set { S("Col6"); _col6 = value; E("Col6"); }
        }

        private short _col7;
        [Column]
        public short Col7
        {
            get { return _col7; }
            set { S("Col7"); _col7 = value; E("Col7"); }
        }

        private short _sha1;
        [Column]
        public short Sha1
        {
            get { return _sha1; }
            set { S("Sha1"); _sha1 = value; E("Sha1"); }
        }

        private short _sha2;
        [Column]
        public short Sha2
        {
            get { return _sha2; }
            set { S("Sha2"); _sha2 = value; E("Sha2"); }
        }

        private short _sha3;
        [Column]
        public short Sha3
        {
            get { return _sha3; }
            set { S("Sha3"); _sha3 = value; E("Sha3"); }
        }

        private short _sha4;
        [Column]
        public short Sha4
        {
            get { return _sha4; }
            set { S("Sha4"); _sha4 = value; E("Sha4"); }
        }

        private short _sha5;
        [Column]
        public short Sha5
        {
            get { return _sha5; }
            set { S("Sha5"); _sha5 = value; E("Sha5"); }
        }

        private short _sha6;
        [Column]
        public short Sha6
        {
            get { return _sha6; }
            set { S("Sha6"); _sha6 = value; E("Sha6"); }
        }

        private short _add1;
        [Column]
        public short Add1
        {
            get { return _add1; }
            set { S("Add1"); _add1 = value; E("Add1"); }
        }

        private short _add2;
        [Column]
        public short Add2
        {
            get { return _add2; }
            set { S("Add2"); _add2 = value; E("Add2"); }
        }

        private short _add3;
        [Column]
        public short Add3
        {
            get { return _add3; }
            set { S("Add3"); _add3 = value; E("Add3"); }
        }

        private short _add4;
        [Column]
        public short Add4
        {
            get { return _add4; }
            set { S("Add4"); _add4 = value; E("Add4"); }
        }

        private short _add5;
        [Column]
        public short Add5
        {
            get { return _add5; }
            set { S("Add5"); _add5 = value; E("Add5"); }
        }

        private short _add6;
        [Column]
        public short Add6
        {
            get { return _add6; }
            set { S("Add6"); _add6 = value; E("Add6"); }
        }

        private short _add7;
        [Column]
        public short Add7
        {
            get { return _add7; }
            set { S("Add7"); _add7 = value; E("Add7"); }
        }

        private short _add8;
        [Column]
        public short Add8
        {
            get { return _add8; }
            set { S("Add8"); _add8 = value; E("Add8"); }
        }

        private string _countryPL;
        [Column]
        public string CountryPL
        {
            get { return _countryPL; }
            set { S("CountryPL"); _countryPL = value; E("CountryPL"); }
        }

        private string _continentPL;
        [Column]
        public string ContinentPL
        {
            get { return _continentPL; }
            set { S("ContinentPL"); _continentPL = value; E("ContinentPL"); }
        }

        private string _capitalPL;
        [Column]
        public string CapitalPL
        {
            get { return _capitalPL; }
            set { S("CapitalPL"); _capitalPL = value; E("CapitalPL"); }
        }

        #region PropertyChange
        public event PropertyChangedEventHandler PropertyChanged;

        private void S(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangingEventHandler PropertyChanging;
        private void E(string propertyName)
        {
            if (PropertyChanging == null) return;
            PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }
        #endregion
    }
}
