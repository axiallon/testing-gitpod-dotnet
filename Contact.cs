namespace Testing {
    public class Contact {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public bool MatchCityIgnoreCase(string cityToMatch)
        {
            return City.ToLower().Equals(cityToMatch.ToLower());
        }
    }
}