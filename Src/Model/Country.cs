namespace Flags
{
    public class Country
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Continent { get; set; }
        public char FirstLetter { get; set; }

        public string ShortDescription
        {
            get { return Continent + "\n" + Name + "\n" + Capital; }
            private set { throw new System.NotImplementedException(); }
        }

        public override string ToString()
        {
            return "(" + Tag + ") " + Name + " - " + Continent + " - " + Capital;
        }
    }
}