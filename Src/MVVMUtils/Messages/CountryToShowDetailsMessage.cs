namespace Flags
{
    class CountryToShowDetailsMessage
    {
        public CountryToShowDetailsMessage(string v)
        {
            Country = v;
        }

        public string Country { get; private set; }
    }
}
