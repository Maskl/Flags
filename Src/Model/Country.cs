namespace Flags
{
    public class Country
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Continent { get; set; }
        public char FirstLetter { get; set; }

        public override string ToString()
        {
            return "(" + Tag + ") " + Name + " - " + Continent + " - " + Capital;
        }
    }
}