using System.Collections.Generic;

namespace Testing {

    public class AddressBook {

        public static List<Contact> FindContactsInCity(string city) {
            return GetContacts().FindAll((contact) => contact.MatchCityIgnoreCase(city));
        }

        public static List<Contact> GetContacts() {
            return new List<Contact>() {
                new Contact() { FirstName = "John", LastName = "Doe", StreetName = "Main St.", City = "London" },
                new Contact() { FirstName = "Billy", LastName = "Bob", StreetName = "Fourth Ave.", Country = "United States" },
                new Contact() { FirstName = "Sam", LastName = "Smith", StreetName = "Baker Blvd.", City = "Sacramento" },
            };
        }

    }

}