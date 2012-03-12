using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Flags
{
    public class LongListGroup<T> : IEnumerable<T>
    {
        public LongListGroup(string name, IEnumerable<T> items)
        {
            Title = name;
            Items = new List<T>(items);
        }

        public override bool Equals(object obj)
        {
            var that = obj as LongListGroup<T>;
            return that != null && Title.Equals(that.Title);
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }

        public string Title
        {
            get;
            set;
        }

        public IList<T> Items
        {
            get;
            set;
        }

        public bool HasItems
        {
            get
            {
                return Items.Count > 0;
            }
        }

        public Brush GroupBackgroundBrush
        {
            get
            {
                if (HasItems)
                    return (SolidColorBrush)Application.Current.Resources["PhoneAccentBrush"];
                
                return (SolidColorBrush)Application.Current.Resources["PhoneChromeBrush"];
            }
        }

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        #endregion
    }
}
