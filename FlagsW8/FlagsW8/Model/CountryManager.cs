using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace FlagsW8.Model
{
    public class CountryManager
    {
        public static readonly ObservableCollection<Country> Countries;

        static CountryManager()
        {
            Countries = new ObservableCollection<Country>();
            Countries.Add(new Country("AD", "Andorra", "Europe", "Andorra la Vella", 30, 30, 30, -20, -20, -20, 10, 75, -40, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Andora", "Europa", "Andorra la Vella"));
            Countries.Add(new Country("AE", "United Arab Emirates", "Asia", "Abu Dhabi", 25, -20, -20, 25, 25, 25, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, 60, -70, -70, -50, -50, "Zjednoczone Emiraty Arabskie", "Azja", "Abu Dabi"));
            Countries.Add(new Country("AF", "Afghanistan", "Asia", "Kabul", 28, -20, -20, 28, 14, 28, -20, 75, -40, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Afganistan", "Azja", "Kabul"));
            Countries.Add(new Country("AG", "Antigua and Barbuda", "North America", "St. John's", 30, 20, 30, -20, 10, 10, -20, -40, -40, 50, -40, -40, 30, 30, -70, 40, 20, -70, 40, 80, 80, "Antigua i Barbuda", "Ameryka Północna", "St. John's"));
            Countries.Add(new Country("AL", "Albania", "Europe", "Tirana", 60, -20, -20, -20, -20, 40, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Albania", "Europa", "Tirana"));
            Countries.Add(new Country("AM", "Armenia", "Asia", "Yerevan", 33, 33, 16, -20, -20, -20, 16, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Armenia", "Azja", "Erewan"));
            Countries.Add(new Country("AO", "Angola", "Africa", "Luanda", 40, -20, 20, -20, -20, 40, -20, -40, -40, -40, 90, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Angola", "Afryka", "Luanda"));
            Countries.Add(new Country("AR", "Argentina", "South America", "Buenos Aires", -20, 40, 20, -20, 40, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Argentyna", "Ameryka Południowa", "Buenos Aires"));
            Countries.Add(new Country("AT", "Austria", "Europe", "Vienna", 50, -20, -20, -20, 50, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Austria", "Europa", "Wiedeń"));
            Countries.Add(new Country("AU", "Australia", "Oceania", "Canberra", 16, 50, -20, -20, 33, -20, -20, -40, -40, -40, -40, -40, 45, 20, 45, -50, -40, -70, -70, -50, -50, "Australia", "oceania", "Canberra"));
            Countries.Add(new Country("AZ", "Azerbaijan", "Asia", "Baku", 28, 28, -20, 28, 14, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Azerbejdżan", "Azja", "Baku"));
            Countries.Add(new Country("BA", "Bosnia and Herzegovina", "Europe", "Sarajevo", -20, 40, 40, -20, 20, -20, -20, -40, -40, -40, -40, -40, 45, 20, -70, -50, -40, -70, -70, -50, 120, "Bośnia i Hercegowina", "Europa", "Sarajewo"));
            Countries.Add(new Country("BB", "Barbados", "North America", "Bridgetown", -20, 40, 40, -20, -20, 20, -20, 75, -40, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Barbados", "Ameryka Północna", "Bridgetown"));
            Countries.Add(new Country("BD", "Bangladesh", "Asia", "Dhaka", 50, -20, -20, 50, -20, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Bangladesz", "Azja", "Dhaka"));
            Countries.Add(new Country("BE", "Belgium", "Europe", "Brussels", 33, -20, 33, -20, -20, 33, -20, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Belgia", "Europa", "Bruksela"));
            Countries.Add(new Country("BF", "Burkina Faso", "Africa", "Ouagadougou", 40, -20, 20, 40, -20, -20, -20, -40, -40, -40, 90, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Burkina Faso", "Afryka", "Ouagadougou"));
            Countries.Add(new Country("BG", "Bulgaria", "Europe", "Sofia", 33, -20, -20, 33, 33, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Bułgaria", "Europa", "Sofia"));
            Countries.Add(new Country("BH", "Bahrain", "Asia", "Manama", 40, -20, -20, -20, 40, -20, 20, -40, 90, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Bahrajn", "Azja", "Manama"));
            Countries.Add(new Country("BI", "Burundi", "Africa", "Bujumbura", 28, -20, -20, 28, 28, -20, 14, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, -70, 120, -50, -50, "Burundi", "Afryka", "Bujumbura"));
            Countries.Add(new Country("BJ", "Benin", "Africa", "Porto-Novo", 33, -20, 33, 33, -20, -20, -20, -40, -40, -40, 90, -40, -40, -30, -70, -50, 60, -70, -70, -50, -50, "Benin", "Afryka", "Porto-Novo"));
            Countries.Add(new Country("BN", "Brunei", "Asia", "Bandar Seri Begawan", 14, -20, 28, -20, 28, 28, -20, -40, -40, -40, -40, 35, 45, 30, -70, -50, -40, -70, -70, -50, 120, "Brunei", "Azja", "Bandar Seri Begawan"));
            Countries.Add(new Country("BO", "Bolivia", "South America", "Sucre", 33, -20, 33, 33, -20, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Boliwia", "Ameryka Południowa", "Sucre"));
            Countries.Add(new Country("BR", "Brazil", "South America", "Brasília", -20, 28, 28, 28, 14, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Brazylia", "Ameryka Południowa", "Brasília"));
            Countries.Add(new Country("BS", "Bahamas", "North America", "Nassau", -20, 28, 28, -20, -20, 28, 14, -40, -40, 75, -40, -40, -40, -30, -70, 120, -40, -70, -70, -50, -50, "Bahamy", "Ameryka Północna", "Nassau"));
            Countries.Add(new Country("BT", "Bhutan", "Asia", "Thimphu", 33, -20, 33, -20, 16, -20, 16, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, 120, -50, "Bhutan", "Azja", "Thimphu"));
            Countries.Add(new Country("BW", "Botswana", "Africa", "Gaborone", -20, 40, -20, -20, 20, 40, -20, -40, -40, 75, -40, 105, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Botswana", "Afryka", "Gaborone"));
            Countries.Add(new Country("BY", "Belarus", "Europe", "Minsk", 40, -20, -20, 40, 20, -20, -20, -40, -40, -40, 90, -40, -40, -30, -70, -50, 60, -70, -70, -50, -50, "Białoruś", "Europa", "Mińsk"));
            Countries.Add(new Country("BZ", "Belize", "North America", "Belmopan", 28, 42, -20, -20, 14, -20, 14, -40, -40, 75, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Belize", "Ameryka Północna", "Belmopan"));
            Countries.Add(new Country("CA", "Canada", "North America", "Ottawa", 50, -20, -20, -20, 50, -20, -20, 75, -40, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Kanada", "Ameryka Północna", "Ottawa"));
            Countries.Add(new Country("CD", "Congo DR", "Africa", "Kinshasa", 28, 42, 28, -20, -20, -20, -20, -40, -40, -40, -40, -40, 45, 30, 45, -50, -40, -70, -70, 120, -50, "Demokratyczna Republika Kongo", "Afryka", "Kinszasa"));
            Countries.Add(new Country("CF", "Central African Republic", "Africa", "Bangui", 20, 20, 20, 20, 20, -20, -20, -40, -40, -40, -40, 105, -40, 20, 45, -50, -40, -70, -70, -50, -50, "Republika Środkowoafrykańska", "Afryka", "Bangui"));
            Countries.Add(new Country("CG", "Republic of the Congo", "Africa", "Brazzaville", 33, -20, 33, 33, -20, -20, -20, -40, -40, 50, -40, -40, 45, -30, -70, -50, -40, -70, -70, 120, -50, "Republika Konga", "Afryka", "Brazzaville"));
            Countries.Add(new Country("CH", "Switzerland", "Europe", "Bern", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Szwajcaria", "Europa", "Berno"));
            Countries.Add(new Country("CI", "Cote d'Ivoire", "Africa", "Yamoussoukro", -20, -20, 22, 33, 33, -20, 11, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Wybrzeże Kości Słoniowej", "Afryka", "Jamusukro"));
            Countries.Add(new Country("CL", "Chile", "South America", "Santiago", 37, 25, -20, -20, 37, -20, -20, -40, -40, -40, 90, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Chile", "Ameryka Południowa", "Santiago"));
            Countries.Add(new Country("CM", "Cameroon", "Africa", "Yaoundé", 28, -20, 28, 28, -20, -20, 14, 75, -40, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Kamerun", "Afryka", "Jaunde"));
            Countries.Add(new Country("CN", "China", "Asia", "Beijing", 60, -20, 40, -20, -20, -20, -20, -40, -40, -40, -40, -40, 45, 10, 45, -50, -40, -70, -70, -50, -50, "Chiny", "Azja", "Pekin"));
            Countries.Add(new Country("CO", "Colombia", "South America", "Bogotá", 33, 33, 33, -20, -20, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Kolumbia", "Ameryka Południowa", "Bogotá"));
            Countries.Add(new Country("CR", "Costa Rica", "North America", "San José", 33, 33, -20, -20, 33, -20, -20, -40, -40, -40, -40, 105, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Kostaryka", "Ameryka Północna", "San José"));
            Countries.Add(new Country("CU", "Cuba", "North America", "Havana", 33, 33, -20, -20, 33, -20, -20, -40, -40, -40, -40, 105, -40, 20, -70, 120, -40, -70, -70, -50, -50, "Kuba", "Ameryka Północna", "Hawana"));
            Countries.Add(new Country("CV", "Cape Verde", "Africa", "Praia", 28, 28, 14, -20, 28, -20, -20, -40, -40, -40, -40, 105, 15, 30, -70, -50, -40, -70, -70, -50, -50, "Wyspy Zielonego Przylądka", "Afryka", "Praia"));
            Countries.Add(new Country("CY", "Cyprus", "Asia", "Nicosia", -20, -20, 16, 16, 50, -20, 16, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Cypr", "Azja", "Nikozja"));
            Countries.Add(new Country("CZ", "Czech Republic", "Europe", "Prague", 33, 33, -20, -20, 33, -20, -20, -40, -40, -40, 90, -40, -40, -30, -70, 120, -40, -70, -70, -50, -50, "Czechy", "Europa", "Praga"));
            Countries.Add(new Country("DE", "Germany", "Europe", "Berlin", 28, -20, 28, -20, -20, 28, 14, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Niemcy", "Europa", "Berlin"));
            Countries.Add(new Country("DJ", "Djibouti", "Africa", "Djibouti", 12, 25, -20, 25, 25, -20, 12, -40, -40, -40, 90, -40, -40, 20, -70, 120, -40, -70, -70, -50, -50, "Dżibuti", "Afryka", "Dżibuti"));
            Countries.Add(new Country("DK", "Denmark", "Europe", "Copenhagen", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, 120, -70, -50, -50, "Dania", "Europa", "Kopenhaga"));
            Countries.Add(new Country("DM", "Dominica", "North America", "Roseau", 22, -20, 11, 22, 11, 11, 22, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Dominika", "Ameryka Północna", "Roseau"));
            Countries.Add(new Country("DO", "Dominican Republic", "North America", "Santo Domingo", 28, 28, -20, -20, 28, -20, 14, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, 120, -70, -50, -50, "Dominikana", "Ameryka Północna", "Santo Domingo"));
            Countries.Add(new Country("DZ", "Algeria", "Africa", "Algiers", 20, -20, -20, 40, 40, -20, -20, -40, 90, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Algieria", "Afryka", "Algier"));
            Countries.Add(new Country("EC", "Ecuador", "South America", "Quito", 25, 25, 25, -20, -20, 12, 12, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Ekwador", "Ameryka Południowa", "Quito"));
            Countries.Add(new Country("EE", "Estonia", "Europe", "Tallinn", -20, 33, -20, -20, 33, 33, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Estonia", "Europa", "Tallinn"));
            Countries.Add(new Country("EG", "Egypt", "Africa", "Cairo", 28, -20, 14, -20, 28, 28, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Egipt", "Afryka", "Kair"));
            Countries.Add(new Country("EH", "Western Sahara", "Africa", "Laayoune", 25, -20, -20, 25, 25, 25, -20, -40, -40, 75, -40, -40, -40, 30, -70, 120, -40, -70, -70, -50, -50, "Sahara Zachodnia", "Afryka", "Laayoune"));
            Countries.Add(new Country("ER", "Eritrea", "Africa", "Asmara", 25, 25, 12, 25, -20, -20, 12, -40, -40, -40, 90, -40, -40, 20, -70, 120, -40, -70, -70, -50, -50, "Erytrea", "Afryka", "Asmara"));
            Countries.Add(new Country("ES", "Spain", "Europe", "Madrid", 33, -20, 33, -20, 16, -20, 16, -40, -40, 75, -40, -40, -40, 20, -70, -50, -40, -70, -70, -50, -50, "Hiszpania", "Europa", "Madryt"));
            Countries.Add(new Country("ET", "Ethiopia", "Africa", "Addis Ababa", 28, 14, 28, 28, -20, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Etiopia", "Afryka", "Addis Abeba"));
            Countries.Add(new Country("FI", "Finland", "Europe", "Helsinki", -20, 50, -20, -20, 50, -20, -20, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, 120, -70, -50, -50, "Finlandia", "Europa", "Helsinki"));
            Countries.Add(new Country("FJ", "Fiji", "Oceania", "Suva", 20, 20, 10, 10, 20, -20, 20, -40, -40, -40, -40, -40, 45, 20, 45, -50, -40, -70, -70, -50, -50, "Fidżi", "oceania", "Suva"));
            Countries.Add(new Country("FM", "Micronesia", "Oceania", "Palikir", -20, 40, -20, -20, 40, -20, 20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Micronesia", "oceania", "Palikir"));
            Countries.Add(new Country("FR", "France", "Europe", "Paris", 33, 33, -20, -20, 33, -20, -20, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Francja", "Europa", "Paryż"));
            Countries.Add(new Country("GA", "Gabon", "Africa", "Libreville", -20, 33, 33, 33, -20, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Gabon", "Afryka", "Libreville"));
            Countries.Add(new Country("GB", "United Kingdom", "Europe", "London", 37, 37, -20, -20, 25, -20, -20, -40, -40, -40, -40, -40, 45, 10, -70, -50, -40, 120, 120, -50, -50, "Wielka Brytania", "Europa", "Londyn"));
            Countries.Add(new Country("GD", "Grenada", "North America", "St. George's", 37, -20, 37, 25, -20, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, 120, -50, -50, "Grenada", "Ameryka Północna", "St. George's"));
            Countries.Add(new Country("GE", "Georgia", "Asia", "Tbilisi", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, -40, -40, 45, -30, 15, -50, -40, 120, -70, -50, -50, "Gruzja", "Azja", "Tbilisi"));
            Countries.Add(new Country("GH", "Ghana", "Africa", "Accra", 28, -20, 28, 28, -20, 14, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Ghana", "Afryka", "Akra"));
            Countries.Add(new Country("GM", "Gambia", "Africa", "Banjul", 28, 28, -20, 28, 14, -20, -20, -40, -40, 75, -40, 105, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Gambia", "Afryka", "Bandżul"));
            Countries.Add(new Country("GN", "Guinea", "Africa", "Conakry", 33, -20, 33, 33, -20, -20, -20, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Gwinea", "Afryka", "Konakri"));
            Countries.Add(new Country("GQ", "Equatorial Guinea", "Africa", "Malabo", 20, 20, 10, 20, 20, -20, 10, -40, -40, 75, -40, -40, -40, 30, -70, 120, -40, -70, -70, -50, -50, "Gwinea Równikowa", "Afryka", "Malabo"));
            Countries.Add(new Country("GR", "Greece", "Europe", "Athens", -20, 50, -20, -20, 50, -20, -20, -40, -40, -40, -40, 105, -40, -30, 45, -50, -40, -70, -70, -50, -50, "Grecja", "Europa", "Ateny"));
            Countries.Add(new Country("GT", "Guatemala", "North America", "Guatemala City", -20, 28, -20, 14, 28, -20, 28, 75, -40, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Gwatemala", "Ameryka Północna", "Gwatemala"));
            Countries.Add(new Country("GW", "Guinea-Bissau", "Africa", "Bissau", 28, -20, 28, 28, -20, 14, -20, -40, -40, -40, 90, -40, -40, 30, -70, -50, 60, -70, -70, -50, -50, "Gwinea Bissau", "Afryka", "Bissau"));
            Countries.Add(new Country("GY", "Guyana", "South America", "Georgetown", 30, -20, 20, 30, 10, 10, -20, -40, -40, -40, -40, -40, 45, -30, -70, 120, 20, -70, -70, -50, -50, "Gujana", "Ameryka Południowa", "Georgetown"));
            Countries.Add(new Country("HN", "Honduras", "North America", "Tegucigalpa", -20, 50, -20, -20, 50, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Honduras", "Ameryka Północna", "Tegucigalpa"));
            Countries.Add(new Country("HR", "Croatia", "Europe", "Zagreb", 28, 28, -20, -20, 28, -20, 14, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Chorwacja", "Europa", "Zagrzeb"));
            Countries.Add(new Country("HT", "Haiti", "North America", "Port-au-Prince", 33, 33, -20, -20, 16, -20, 16, -40, -40, -40, 90, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Haiti", "Ameryka Północna", "Port-Au-Prince"));
            Countries.Add(new Country("HU", "Hungary", "Europe", "Budapest", 33, -20, -20, 33, 33, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Węgry", "Europa", "Budapeszt"));
            Countries.Add(new Country("ID", "Indonesia", "Asia", "Jakarta", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, 90, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Indonezja", "Azja", "Dżakarta"));
            Countries.Add(new Country("IE", "Ireland", "Europe", "Dublin", -20, -20, 25, 25, 25, -20, 25, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Irlandia", "Europa", "Dublin"));
            Countries.Add(new Country("IL", "Israel", "Asia", "Jerusalem", -20, 50, -20, -20, 50, -20, -20, -40, -40, 75, -40, 105, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Izrael", "Azja", "Jerozolima"));
            Countries.Add(new Country("IN", "India", "Asia", "New Delhi", -20, 11, 22, 22, 22, -20, 22, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Indie", "Azja", "New Delhi"));
            Countries.Add(new Country("IQ", "Iraq", "Asia", "Baghdad", 28, -20, -20, 14, 28, 28, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Irak", "Azja", "Bagdad"));
            Countries.Add(new Country("IR", "Iran", "Asia", "Tehran", 33, -20, -20, 33, 33, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Iran", "Azja", "Teheran"));
            Countries.Add(new Country("IS", "Iceland", "Europe", "Reykjavík", 42, 42, -20, -20, 14, -20, -20, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, 120, -70, -50, -50, "Islandia", "Europa", "Reykjavík"));
            Countries.Add(new Country("IT", "Italy", "Europe", "Rome", 33, -20, -20, 33, 33, -20, -20, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Włochy", "Europa", "Rzym"));
            Countries.Add(new Country("JM", "Jamaica", "North America", "Kingston", -20, -20, 33, 33, -20, 33, -20, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, -70, 120, -50, -50, "Jamajka", "Ameryka Północna", "Kingston"));
            Countries.Add(new Country("JO", "Jordan", "Asia", "Amman", 25, -20, -20, 25, 25, 25, -20, -40, -40, 75, -40, -40, -40, 30, -70, 120, -40, -70, -70, -50, -50, "Jordania", "Azja", "Amman"));
            Countries.Add(new Country("JP", "Japan", "Asia", "Tokyo", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Japonia", "Azja", "Tokio"));
            Countries.Add(new Country("KE", "Kenya", "Africa", "Nairobi", 28, -20, -20, 28, 14, 28, -20, -40, -40, 75, -40, 105, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Kenia", "Afryka", "Nairobi"));
            Countries.Add(new Country("KG", "Kyrgyzstan", "Asia", "Bishkek", 66, -20, 33, -20, -20, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Kirgistan", "Azja", "Biszkek"));
            Countries.Add(new Country("KH", "Cambodia", "Asia", "Phnom Penh", 40, 40, -20, -20, 20, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Kambodża", "Azja", "Phnom Penh"));
            Countries.Add(new Country("KI", "Kiribati", "Oceania", "South Tarawa", 37, 25, 25, -20, 12, -20, -20, -40, -40, -40, 90, -40, 15, 30, -70, -50, -40, -70, -70, -50, -50, "Kiribati", "oceania", "South Tarawa"));
            Countries.Add(new Country("KM", "Comoros", "Africa", "Moroni", 20, 20, 20, 20, 20, -20, -20, -40, -40, -40, -40, 105, -40, 30, -70, 120, -40, -70, -70, -50, -50, "Komory", "Afryka", "Moroni"));
            Countries.Add(new Country("KN", "Saint Kitts and Nevis", "North America", "Basseterre", 25, -20, 12, 25, 12, 25, -20, -40, -40, 50, -40, -40, 45, 30, -70, -50, -40, -70, -70, 120, -50, "Saint Kitts i Nevis", "Ameryka Północna", "Basseterre"));
            Countries.Add(new Country("KP", "North Korea", "Asia", "Pyongyang", 40, 40, -20, -20, 20, -20, -20, -40, -40, 75, -40, 70, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Korea Północna", "Azja", "Phenian"));
            Countries.Add(new Country("KR", "South Korea", "Asia", "Seoul", 28, 28, -20, -20, 28, 14, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Korea Południowa", "Azja", "Seul"));
            Countries.Add(new Country("KS", "Kosovo", "Europe", "Pristina", -20, 50, 33, -20, 16, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Kosowo", "Europa", "Prisztina"));
            Countries.Add(new Country("KW", "Kuwait", "Asia", "Kuwait City", 25, -20, -20, 25, 25, 25, -20, -40, -40, 75, -40, -40, -40, -30, -70, 120, -40, -70, -70, -50, -50, "Kuwejt", "Azja", "Kuwait City"));
            Countries.Add(new Country("KZ", "Kazakhstan", "Asia", "Astana", -20, 50, 25, -20, -20, -20, 25, -40, -40, -40, -40, -40, 45, 30, -70, -50, 40, -70, -70, -50, -50, "Kazachstan", "Azja", "Astana"));
            Countries.Add(new Country("LA", "Laos", "Asia", "Vientiane", 33, 33, -20, -20, 33, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Laos", "Azja", "Wientian"));
            Countries.Add(new Country("LB", "Lebanon", "Asia", "Beirut", 28, -20, -20, 28, 28, -20, 14, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Liban", "Azja", "Bejrut"));
            Countries.Add(new Country("LC", "Saint Lucia", "North America", "Castries", -20, 37, 37, -20, 12, 12, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Saint Lucia", "Ameryka Północna", "Castries"));
            Countries.Add(new Country("LI", "Liechtenstein", "Europe", "Vaduz", 42, 42, 14, -20, -20, -20, -20, -40, -40, -40, 90, -40, -40, 10, 45, -50, -40, -70, -70, -50, -50, "Liechtenstein", "Europa", "Vaduz"));
            Countries.Add(new Country("LK", "Sri Lanka", "Asia", "Colombo", 12, -20, 37, 25, -20, -20, 25, 75, 60, -40, -40, -40, 15, 30, -70, -50, 20, -70, -70, -50, -50, "Sri Lanka", "Azja", "Colombo"));
            Countries.Add(new Country("LR", "Liberia", "Africa", "Monrovia", 33, 33, -20, -20, 33, -20, -20, -40, -40, -40, -40, 105, -40, -30, 45, -50, -40, -70, -70, -50, -50, "Liberia", "Afryka", "Monrowia"));
            Countries.Add(new Country("LS", "Lesotho", "Africa", "Maseru", -20, 28, -20, 28, 28, 14, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Lesotho", "Afryka", "Maseru"));
            Countries.Add(new Country("LT", "Lithuania", "Europe", "Vilnius", 33, -20, 33, 33, -20, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Litwa", "Europa", "Wilno"));
            Countries.Add(new Country("LU", "Luxembourg", "Europe", "Luxembourg City", 33, 33, -20, -20, 33, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Luksemburg", "Europa", "Luksemburg"));
            Countries.Add(new Country("LV", "Latvia", "Europe", "Riga", 40, -20, -20, -20, 40, -20, 20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Łotwa", "Europa", "Ryga"));
            Countries.Add(new Country("LY", "Libya", "Africa", "Tripoli", -20, -20, -20, 100, -20, -20, -20, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, -70, -70, -50, -50, "Libia", "Afryka", "Trypolis"));
            Countries.Add(new Country("MA", "Morocco", "Africa", "Rabat", 42, -20, -20, 42, -20, 14, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Maroko", "Afryka", "Rabat"));
            Countries.Add(new Country("MC", "Monaco", "Europe", "Monaco", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, 90, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Monako", "Europa", "Monako"));
            Countries.Add(new Country("MD", "Moldova", "Europe", "Chisinau", 30, 30, 30, -20, -20, -20, 10, 75, -40, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Mołdawia", "Europa", "Chisinau"));
            Countries.Add(new Country("ME", "Montenegro", "Europe", "Podgorica", 42, 14, 28, -20, -20, -20, 14, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Czarnogóra", "Europa", "Podgorica"));
            Countries.Add(new Country("MG", "Madagascar", "Africa", "Antananarivo", 33, -20, -20, 33, 33, -20, -20, -40, -40, -40, 90, -40, -40, -30, -70, -50, 60, -70, -70, -50, -50, "Madagaskar", "Afryka", "Antananarywa"));
            Countries.Add(new Country("MH", "Marshall Islands", "Oceania", "Majuro", -20, 42, 14, -20, 28, -20, 14, -40, -40, -40, -40, -40, 45, 30, 45, -50, -40, -70, -70, 120, -50, "Wyspy Marshalla", "oceania", "Majuro"));
            Countries.Add(new Country("MK", "Macedonia", "Europe", "Skopje", 50, -20, 50, -20, -20, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, 120, 120, -50, -50, "Macedonia", "Europa", "Skopje"));
            Countries.Add(new Country("ML", "Mali", "Africa", "Bamako", 33, -20, 33, 33, -20, -20, -20, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Mali", "Afryka", "Bamako"));
            Countries.Add(new Country("MM", "Myanmar", "Asia", "Naypyidaw", 40, 40, -20, -20, 20, -20, -20, -40, -40, -40, -40, -40, 45, -30, 45, -50, -40, -70, -70, -50, -50, "Myanmar", "Azja", "Naypyidaw"));
            Countries.Add(new Country("MN", "Mongolia", "Asia", "Ulaanbaatar", 40, 40, 20, -20, -20, -20, -20, 75, -40, -40, -40, -40, -40, 20, 15, -50, 20, -70, -70, -50, -50, "Mongolia", "Azja", "Ułan Bator"));
            Countries.Add(new Country("MR", "Mauritania", "Africa", "Nouakchott", -20, -20, 50, 50, -20, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Mauretania", "Afryka", "Nawakszut"));
            Countries.Add(new Country("MT", "Malta", "Europe", "Valletta", 42, -20, -20, -20, 42, -20, 14, -40, 90, -40, -40, -40, -40, -30, 30, -50, -40, -70, -70, -50, -50, "Malta", "Europa", "Valletta"));
            Countries.Add(new Country("MU", "Mauritius", "Africa", "Port Louis", 25, 25, 25, 25, -20, -20, -20, -40, -40, -40, -40, 105, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Mauritius", "Afryka", "Port Louis"));
            Countries.Add(new Country("MV", "Maldives", "Asia", "Malé", 40, -20, -20, 40, 20, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Malediwy", "Azja", "Malé"));
            Countries.Add(new Country("MW", "Malawi", "Africa", "Lilongwe", 33, -20, -20, 33, -20, 33, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Malawi", "Afryka", "Lilongwe"));
            Countries.Add(new Country("MX", "Mexico", "North America", "Mexico City", 28, -20, -20, 28, 28, -20, 14, 75, -40, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Meksyk", "Ameryka Północna", "Meksyk"));
            Countries.Add(new Country("MY", "Malaysia", "Asia", "Kuala Lumpur", 28, 28, 14, -20, 28, -20, -20, -40, -40, -40, -40, 105, -40, -30, 45, -50, -40, -70, -70, -50, -50, "Malezja", "Azja", "Kuala Lumpur"));
            Countries.Add(new Country("MZ", "Mozambique", "Africa", "Maputo", 22, -20, 22, 11, 11, 22, 11, -40, -40, 75, -40, 35, -40, 30, -70, 120, -40, -70, -70, -50, -50, "Mozambik", "Afryka", "Maputo"));
            Countries.Add(new Country("NA", "Namibia", "Africa", "Windhoek", 25, 25, 12, 25, 12, -20, -20, -40, -40, -40, -40, -40, 45, 20, 30, -50, -40, -70, -70, 120, -50, "Namibia", "Afryka", "Windhoek"));
            Countries.Add(new Country("NE", "Niger", "Africa", "Niamey", 16, -20, 16, 33, 33, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Niger", "Afryka", "Niamey"));
            Countries.Add(new Country("NG", "Nigeria", "Africa", "Abuja", -20, -20, -20, 50, 50, -20, -20, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Nigeria", "Afryka", "Abudża"));
            Countries.Add(new Country("NI", "Nicaragua", "North America", "Managua", -20, 40, -20, -20, 40, -20, 20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Nikaragua", "Ameryka Północna", "Managua"));
            Countries.Add(new Country("NL", "Netherlands", "Europe", "Amsterdam", 33, 33, -20, -20, 33, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Niderlandy", "Europa", "Amsterdam"));
            Countries.Add(new Country("NO", "Norway", "Europe", "Oslo", 33, 33, -20, -20, 33, -20, -20, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, 120, -70, -50, -50, "Norwegia", "Europa", "Oslo"));
            Countries.Add(new Country("NP", "Nepal", "Asia", "Kathmandu", 33, 33, -20, -20, 33, -20, -20, -40, -40, -40, -40, -40, 45, 30, 15, -50, -40, -70, -70, -50, 40, "Nepal", "Azja", "Kathmandu"));
            Countries.Add(new Country("NR", "Nauru", "Oceania", "Yaren", -20, 50, 25, -20, 25, -20, -20, -40, -40, 75, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Nauru", "oceania", "Yaren"));
            Countries.Add(new Country("NZ", "New Zealand", "Oceania", "Wellington", 33, 50, -20, -20, 16, -20, -20, -40, -40, -40, -40, -40, 45, 20, 45, -50, -40, -70, -70, -50, -50, "Nowa Zelandia", "oceania", "Wellington"));
            Countries.Add(new Country("OM", "Oman", "Asia", "Muscat", 33, -20, -20, 33, 33, -20, -20, -40, -40, 75, -40, -40, -40, -30, 15, -50, 60, -70, -70, -50, -50, "Oman", "Azja", "muszkat"));
            Countries.Add(new Country("PA", "Panama", "North America", "Panama City", 33, 33, -20, -20, 33, -20, -20, -40, -40, -40, -40, -40, 45, 20, 15, -50, -40, 120, -70, -50, -50, "Panama", "Ameryka Północna", "Panama City"));
            Countries.Add(new Country("PE", "Peru", "South America", "Lima", 50, -20, -20, -20, 50, -20, -20, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Peru", "Ameryka Południowa", "Lima"));
            Countries.Add(new Country("PG", "Papua New Guinea", "Oceania", "Port Moresby", 33, -20, 16, -20, 16, 33, -20, -40, -40, -40, 30, -40, 45, 30, -70, -50, -40, -70, -70, -50, 120, "Papua-Nowa Gwinea", "oceania", "Port Moresby"));
            Countries.Add(new Country("PH", "Philippines", "Asia", "Manila", 33, 33, 11, -20, 22, -20, -20, -40, -40, -40, 90, -40, -40, 30, -70, 120, -40, -70, -70, -50, -50, "Filipiny", "Azja", "Manila"));
            Countries.Add(new Country("PK", "Pakistan", "Asia", "Islamabad", -20, -20, -20, 50, 50, -20, -20, -40, 90, -40, -40, -40, 45, 30, -70, -50, 60, -70, -70, -50, -50, "Pakistan", "Azja", "Islamabad"));
            Countries.Add(new Country("PL", "Poland", "Europe", "Warsaw", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, 90, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Polska", "Europa", "Warszawa"));
            Countries.Add(new Country("PT", "Portugal", "Europe", "Lisbon", 33, -20, 16, 33, -20, -20, 16, -40, 90, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Portugalia", "Europa", "Lizbona"));
            Countries.Add(new Country("PW", "Palau", "Oceania", "Melekeok", -20, 50, 50, -20, -20, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Palau", "oceania", "Melekeok"));
            Countries.Add(new Country("PY", "Paraguay", "South America", "Asunción", 33, 33, -20, -20, 33, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Paragwaj", "Ameryka Południowa", "Asunción"));
            Countries.Add(new Country("QA", "Qatar", "Asia", "Doha", -20, -20, -20, -20, 50, -20, 50, -40, 90, -40, -40, -40, 45, -30, -70, -50, -40, -70, -70, -50, -50, "Katar", "Azja", "Doha"));
            Countries.Add(new Country("RO", "Romania", "Europe", "Bucharest", 33, 33, 33, -20, -20, -20, -20, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Rumunia", "Europa", "Bukareszt"));
            Countries.Add(new Country("RS", "Serbia", "Europe", "Belgrade", 27, 27, 9, -20, 27, -20, 9, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Serbia", "Europa", "Belgrad"));
            Countries.Add(new Country("RU", "Russia", "Europe", "Moscow", 33, 33, -20, -20, 33, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Rosja", "Europa", "Moskwa"));
            Countries.Add(new Country("RW", "Rwanda", "Africa", "Kigali", -20, 28, 28, 28, -20, -20, 14, -40, -40, 75, -40, -40, -40, 20, 15, -50, -40, -70, -70, -50, -50, "Rwanda", "Afryka", "Kigali"));
            Countries.Add(new Country("SA", "Saudi Arabia", "Asia", "Riyadh", -20, -20, -20, 75, 25, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Arabia Saudyjska", "Azja", "Rijad"));
            Countries.Add(new Country("SB", "Solomon Islands", "Oceania", "Honiara", -20, 37, 12, 37, 12, -20, -20, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, -70, -70, 120, -50, "Wyspy Salomona", "oceania", "Honiara"));
            Countries.Add(new Country("SC", "Seychelles", "Africa", "Victoria", 20, 20, 20, 20, 20, -20, -20, -40, -40, -40, -40, 105, 45, -30, -70, -50, -40, -70, -70, 120, -50, "Seszele", "Afryka", "Wiktoria"));
            Countries.Add(new Country("SD", "Sudan", "Africa", "Khartoum", 25, -20, -20, 25, 25, 25, -20, -40, -40, 75, -40, -40, -40, -30, -70, 120, -40, -70, -70, -50, -50, "Sudan", "Afryka", "Chartum"));
            Countries.Add(new Country("SE", "Sweden", "Europe", "Stockholm", -20, 50, 50, -20, -20, -20, -20, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, 120, -70, -50, -50, "Szwecja", "Europa", "Sztokholm"));
            Countries.Add(new Country("SG", "Singapore", "Asia", "Singapore", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, 90, -40, -40, -30, 45, -50, -40, -70, -70, -50, -50, "Singapur", "Azja", "Singapur"));
            Countries.Add(new Country("SI", "Slovenia", "Europe", "Ljubljana", 30, 30, 10, -20, 30, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Słowenia", "Europa", "Ljubljana"));
            Countries.Add(new Country("SK", "Slovakia", "Europe", "Bratislava", 33, 33, -20, -20, 33, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Słowacja", "Europa", "Bratysława"));
            Countries.Add(new Country("SL", "Sierra Leone", "Africa", "Freetown", -20, 33, -20, 33, 33, -20, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Sierra Leone", "Afryka", "Freetown"));
            Countries.Add(new Country("SM", "San Marino", "Europe", "San Marino", -20, 33, 11, 11, 33, -20, 11, -40, -40, -40, 90, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "San Marino", "Europa", "San Marino"));
            Countries.Add(new Country("SN", "Senegal", "Africa", "Dakar", 33, -20, 33, 33, -20, -20, -20, 75, -40, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Senegal", "Afryka", "Dakar"));
            Countries.Add(new Country("SO", "Somalia", "Africa", "Mogadishu", -20, 60, -20, -20, 40, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Somalia", "Afryka", "Mogadiszu"));
            Countries.Add(new Country("SR", "Suriname", "South America", "Paramaribo", 33, -20, 16, 33, 16, -20, -20, -40, -40, 50, -40, 105, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Surinam", "Ameryka Południowa", "Paramaribo"));
            Countries.Add(new Country("ST", "Sao Tome and Principe", "Africa", "Sao Tomé", 28, -20, 28, 28, -20, 14, -20, -40, -40, 75, -40, -40, -40, 30, -70, 120, -40, -70, -70, -50, -50, "Sao Tome i Principe", "Afryka", "Sao Tomé"));
            Countries.Add(new Country("SV", "El Salvador", "North America", "San Salvador", -20, 37, 12, -20, 37, -20, 12, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Salwador", "Ameryka Północna", "San Salvador"));
            Countries.Add(new Country("SY", "Syria", "Asia", "Damascus", 28, -20, -20, 14, 28, 28, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Syria", "Azja", "Damaszek"));
            Countries.Add(new Country("SZ", "Swaziland", "Africa", "Mbabane", 30, 30, 20, -20, 10, 10, -20, -40, -40, 50, -40, 105, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Suazi", "Afryka", "Mbabane"));
            Countries.Add(new Country("TD", "Chad", "Africa", "N'Djamena", 33, 33, 33, -20, -20, -20, -20, 75, -40, -40, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Czad", "Afryka", "Ndżamena"));
            Countries.Add(new Country("TG", "Togo", "Africa", "Lomé", 28, -20, 28, 28, 14, -20, -20, -40, -40, -40, -40, 105, -40, -30, 45, -50, -40, -70, -70, -50, -50, "Togo", "Afryka", "Lomé"));
            Countries.Add(new Country("TH", "Thailand", "Asia", "Bangkok", 33, 33, -20, -20, 33, -20, -20, -40, -40, -40, -40, 105, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Tajlandia", "Azja", "Bangkok"));
            Countries.Add(new Country("TJ", "Tajikistan", "Asia", "Dushanbe", 27, -20, 9, 27, 27, -20, 9, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Tadżykistan", "Azja", "Duszanbe"));
            Countries.Add(new Country("TL", "East Timor", "Asia", "Dili", 50, -20, 33, -20, 16, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, 120, -40, -70, -70, -50, -50, "Timor Wschodni", "Azja", "Dili"));
            Countries.Add(new Country("TM", "Turkmenistan", "Asia", "Ashgabat", 16, -20, -20, 50, 16, -20, 16, 25, 30, -40, -40, -40, 45, 30, 15, -50, 60, -70, -70, -50, -50, "Turkmenia", "Azja", "Aszchabad"));
            Countries.Add(new Country("TN", "Tunisia", "Africa", "Tunis", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, -40, -40, 45, 20, -70, -50, -40, -70, -70, -50, -50, "Tunezja", "Afryka", "Tunis"));
            Countries.Add(new Country("TO", "Tonga", "Oceania", "Nuku'alofa", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, -40, -40, 45, -30, 45, -50, -40, -70, -70, -50, -50, "Tonga", "oceania", "Nuku'alofa"));
            Countries.Add(new Country("TR", "Turkey", "Europe", "Ankara", 50, -20, -20, -20, 50, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Turcja", "Europa", "Ankara"));
            Countries.Add(new Country("TT", "Trinidad and Tobago", "South America", "Port of Spain", 50, -20, -20, -20, 16, 33, -20, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, -70, -70, -50, 120, "Trynidad i Tobago", "Ameryka Południowa", "Port of Spain"));
            Countries.Add(new Country("TV", "Tuvalu", "Oceania", "Funafuti", 22, 33, 22, -20, 11, -20, 11, -40, -40, -40, -40, -40, 45, 20, 45, -50, -40, -70, -70, -50, -50, "Tuvalu", "oceania", "Funafuti"));
            Countries.Add(new Country("TW", "Taiwan", "Asia", "Taipei", 42, 42, -20, -20, 14, -20, -20, -40, -40, -40, -40, -40, 45, -30, 45, -50, -40, -70, -70, -50, -50, "Tajwan", "Azja", "Tajpej"));
            Countries.Add(new Country("TZ", "Tanzania", "Africa", "Dodoma", -20, 28, 14, 28, -20, 28, -20, -40, -40, -40, -40, -40, 45, -30, -70, -50, -40, -70, -70, 120, -50, "Tanzania", "Afryka", "Dodoma"));
            Countries.Add(new Country("UA", "Ukraine", "Europe", "Kiev", -20, 50, 50, -20, -20, -20, -20, -40, -40, -40, 90, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Ukraina", "Europa", "Kijów"));
            Countries.Add(new Country("UG", "Uganda", "Africa", "Kampala", 18, -20, 27, -20, 9, 27, 18, -40, -40, -40, -40, 105, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Uganda", "Afryka", "Kampala"));
            Countries.Add(new Country("US", "United States", "North America", "Washington DC", 33, 33, -20, -20, 33, -20, -20, -40, -40, -40, -40, 110, -40, -30, 45, -50, -40, -70, -70, -50, -50, "Stany Zjednoczone", "Ameryka Północna", "Waszyngton DC"));
            Countries.Add(new Country("UY", "Uruguay", "South America", "Montevideo", -20, 42, 14, -20, 42, -20, -20, -40, -40, -40, -40, 105, -40, -30, 45, -50, -40, -70, -70, -50, -50, "Urugwaj", "Ameryka Południowa", "Montevideo"));
            Countries.Add(new Country("UZ", "Uzbekistan", "Asia", "Tashkent", 10, 30, -20, 30, 30, -20, -20, -40, -40, 75, -40, -40, -40, -30, 45, -50, -40, -70, -70, -50, -50, "Uzbekistan", "Azja", "Taszkent"));
            Countries.Add(new Country("VA", "Vatican", "Europe", "Vatican City", 12, -20, 37, -20, 37, -20, 12, -40, 90, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Watykan", "Europa", "Watykan"));
            Countries.Add(new Country("VC", "Saint Vincent and the Grenadines", "North America", "Kingstown", -20, 33, 33, 33, -20, -20, -20, 75, -40, -40, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Saint Vincent i Grenadyny", "Ameryka Północna", "Kingstown"));
            Countries.Add(new Country("VE", "Venezuela", "South America", "Caracas", 30, 30, 30, -20, 10, -20, -20, -40, -40, 75, -40, -40, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Wenezuela", "Ameryka Południowa", "Caracas"));
            Countries.Add(new Country("VN", "Vietnam", "Asia", "Hanoi", 50, -20, 50, -20, -20, -20, -20, -40, -40, -40, -40, -40, 45, 30, -70, -50, -40, -70, -70, -50, -50, "Wietnam", "Azja", "Hanoi"));
            Countries.Add(new Country("VU", "Vanuatu", "Oceania", "Port Vila", 30, -20, 20, 30, -20, 20, -20, -40, -40, -40, 90, -40, -40, 10, -70, 120, -40, -70, -70, -50, -50, "Vanuatu", "oceania", "Port Vila"));
            Countries.Add(new Country("WS", "Samoa", "Oceania", "Apia", 42, 42, -20, -20, 14, -20, -20, -40, -40, -40, -40, -40, 45, -30, 45, -50, -40, -70, -70, -50, -50, "Samoa", "oceania", "Apia"));
            Countries.Add(new Country("YE", "Yemen", "Asia", "Sanaá", 33, -20, -20, -20, 33, 33, -20, -40, -40, 75, -40, -40, -40, -30, -70, -50, -40, -70, -70, -50, -50, "Jemen", "Azja", "Sanaa"));
            Countries.Add(new Country("ZA", "South Africa", "Africa", "Pretoria", 25, 25, 8, 25, -20, 16, -20, -40, -40, 75, 30, 105, 15, -30, -70, 120, 20, -70, -70, -50, -50, "Republika Południowej Afryki", "Afryka", "Pretoria"));
            Countries.Add(new Country("ZM", "Zambia", "Africa", "Lusaka", 20, -20, 20, 30, -20, 20, 10, -40, -40, -40, -40, -40, 45, 30, 15, -50, -40, -70, -70, -50, -50, "Zambia", "Afryka", "Lusaka"));
            Countries.Add(new Country("ZW", "Zimbabwe", "Africa", "Harare", -20, -20, 28, 28, 14, 28, -20, -40, -40, -40, -40, 105, -40, 30, -70, -50, -40, -70, -70, -50, -50, "Zimbabwe", "Afryka", "Harare"));
        }

        public static void GetCountriesByParams(ICollection<Country> list, int color, int shape, int add)
        {
            list.Clear();

            var colTab = new int[7];
            for (var i = 0; i < colTab.Length; ++i)
            {
                colTab[i] = (color & (1 << i)) == 0 ? 1 : -1;
            }

            var maxShapePenalty = (shape & (1 << 6)) == 0 ? -1 : 0;
            var shaTab = new int[6];
            for (var i = 0; i < shaTab.Length; ++i)
            {
                shaTab[i] = (shape & (1 << i)) == 0 ? 1 : maxShapePenalty;
            }

            var addTab = new int[8];
            for (var i = 0; i < addTab.Length; ++i)
            {
                addTab[i] = (add & (1 << i)) == 0 ? 1 : -1;
            }

            // \ + / = X
            if (addTab[6] < 0 && addTab[7] < 0)
            {
                addTab[6] = addTab[7] = 1;
                addTab[5] = -1;
            }

            var usedColors = (colTab[0] < 0 || colTab[1] < 0 || colTab[2] < 0 || colTab[3] < 0 || colTab[4] < 0 || colTab[5] < 0 || colTab[6] < 0);
            var usedShapes = (shaTab[0] < 0 || shaTab[1] < 0 || shaTab[2] < 0 || shaTab[3] < 0 || shaTab[4] < 0 || shaTab[5] < 0);
            var usedAdds = (addTab[0] < 0 || addTab[1] < 0 || addTab[2] < 0 || addTab[3] < 0 || addTab[4] < 0 || addTab[5] < 0 || addTab[6] < 0 || addTab[7] < 0);

            if (!usedColors)
                colTab[0] = colTab[1] = colTab[2] = colTab[3] = colTab[4] = colTab[5] = colTab[6] = 1;

            if (!usedShapes)
                shaTab[0] = shaTab[1] = shaTab[2] = shaTab[3] = shaTab[4] = shaTab[5] = 1;

            if (!usedAdds)
                addTab[0] = addTab[1] = addTab[2] = addTab[3] = addTab[4] = addTab[5] = addTab[6] = addTab[7] = 1;

            var flags = (from f in Countries orderby (
                f.Col[0] * colTab[0] +
                f.Col[1] * colTab[1] +
                f.Col[2] * colTab[2] +
                f.Col[3] * colTab[3] +
                f.Col[4] * colTab[4] +
                f.Col[5] * colTab[5] +
                f.Col[6] * colTab[6] +

                f.Sha[0] * shaTab[0] +
                f.Sha[1] * shaTab[1] +
                f.Sha[2] * shaTab[2] +
                f.Sha[3] * shaTab[3] +
                f.Sha[4] * shaTab[4] +
                f.Sha[5] * shaTab[5] +

                f.Add[0] * addTab[0] +
                f.Add[1] * addTab[1] +
                f.Add[2] * addTab[2] +
                f.Add[3] * addTab[3] +
                f.Add[4] * addTab[4] +
                f.Add[5] * addTab[5] +
                f.Add[6] * addTab[6] +
                f.Add[7] * addTab[7]
            ) select f).Take(8);

            foreach (var country in flags)
            {
                list.Add(country);
            }
        }

        public static Country GetCountryByTag(string tag)
        {
            var country = Countries.Single(f => f.Iso == tag);
            return country;
        }
    }
}