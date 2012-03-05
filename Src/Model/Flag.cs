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
            set
            {
                NotifyPropertyChanging("Iso");
                _iso = value;
                NotifyPropertyChanged("Iso");
            }
        }

        private string _country;
        [Column]
        public string Country
        {
            get { return _country; }
            set
            {
                NotifyPropertyChanging("Country");
                _country = value;
                NotifyPropertyChanged("Country");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;
        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }
    }
}
