using System;
using System.ComponentModel;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace FlagsW8.Model
{
    public class FlagColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NamePL { get; set; }

        public FlagColor(int id, string name, string namePL)
        {
            Id = id;
            Name = name;
            NamePL = namePL;
        }

        private ImageSource _image = null;
        public ImageSource Image
        {
            get { return _image ?? (_image = new BitmapImage(new Uri("ms-appx:///Media/Icons/wp7col" + Id + ".png"))); }
        }
    }
}
