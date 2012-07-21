using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace FlagsW8.Model
{
    public class FlagParamsManager
    {
        public static readonly ObservableCollection<FlagShape> Shapes;
        public static readonly ObservableCollection<FlagAdd> Adds;
        public static readonly ObservableCollection<FlagColor> Colors;

        static FlagParamsManager()
        {
            Shapes = new ObservableCollection<FlagShape>();
            Shapes.Add(new FlagShape(1, "vertical tricolor", "trzy pionowe"));
            Shapes.Add(new FlagShape(2, "vertical bicolor", "dwa pionowe"));
            Shapes.Add(new FlagShape(3, "horizontal tricolor", "trzy poziome"));
            Shapes.Add(new FlagShape(4, "horizontal bicolor", "dwa poziome"));
            Shapes.Add(new FlagShape(5, "stripes", "paski"));
            Shapes.Add(new FlagShape(6, "plain", "bez pasków"));

            Adds = new ObservableCollection<FlagAdd>();
            Adds.Add(new FlagAdd(1, "something", "coś"));
            Adds.Add(new FlagAdd(2, "canton", "canton"));
            Adds.Add(new FlagAdd(3, "triangle", "trójkąt"));
            Adds.Add(new FlagAdd(4, "stripe", "pasek"));
            Adds.Add(new FlagAdd(5, "cross", "krzyż"));
            Adds.Add(new FlagAdd(6, "saltire", "saltire"));
            Adds.Add(new FlagAdd(7, "slash", "slash"));
            Adds.Add(new FlagAdd(8, "backslash", "backslash"));

            Colors = new ObservableCollection<FlagColor>();
            Colors.Add(new FlagColor(1, "red", "czerwony"));
            Colors.Add(new FlagColor(2, "blue", "niebieski"));
            Colors.Add(new FlagColor(3, "yellow", "żółty"));
            Colors.Add(new FlagColor(4, "green", "zielony"));
            Colors.Add(new FlagColor(5, "white", "biały"));
            Colors.Add(new FlagColor(6, "black", "czarny"));
            Colors.Add(new FlagColor(7, "other", "inny"));
        }
    }
}