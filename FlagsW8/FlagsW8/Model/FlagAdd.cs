using System;
using System.ComponentModel;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace FlagsW8.Model
{
    public class FlagAdd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NamePL { get; set; }

        public FlagAdd(int id, string name, string namePL)
        {
            Id = id;
            Name = name;
            NamePL = namePL;
        }

        private ImageSource _image;
        public ImageSource Image
        {
            get { return _image ?? (_image = new BitmapImage(new Uri("ms-appx:///Media/Adds/add" + Id + ".png"))); }
        }
    }
}
