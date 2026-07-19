using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("853 N 1st St", "Boise", "ID", "83702", "USA");
        Address address2 = new Address("759 Green St", "Melbourne", "VIC", "10001", "Australia");
        Address address3 = new Address("725 Juniper Rd", "Gilbert", "AZ", "81274", "USA");

        Lecture techLecture = new Lecture(
            "How to Program with Classes",
            "A lecture about how to program with classes in C#",
            "July 25, 2026",
            "7:00 pm",
            address1,
            "Dr. Cleveland",
            100
        );

        Reception weddingReception = new Reception(
            "Dustin and Suzie's Wedding",
            "A marriage between two very smart individuals",
            "October 9, 2026",
            "6:00 pm",
            address2,
            "rsvp@neverendingstory.com"
        );

        OutdoorGathering parkConcert = new OutdoorGathering(
            "Family Reunion Band",
            "Come hear some members of the family play Take On Me",
            "July 20, 2026",
            "7:30 pm",
            address3,
            "Cloudy with a chance of epic music"
        );

        List<Event> eventMarketingList = new List<Event> { techLecture, weddingReception, parkConcert };
        
        foreach (Event item in eventMarketingList)
        {
            Console.WriteLine(item.GetShortDescription());

            Console.WriteLine(item.GetStandardDetails());

            Console.WriteLine(item.GetFullDetails());
        }
    }
}
