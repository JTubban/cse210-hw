using System;

class Program
{
    static void Main(string[] args)
    {
        GalaForTheArts galaForTheArts = new GalaForTheArts("Gala for the Arts", "Join us for an enchanting evening celebrating the arts in our community. The Gala for the Arts is\nan event dedicated to showcasing local talent, supporting the arts, and fostering creativity.", "Saturday, December 15, 2023", "6:00 PM - 10:00 PM");
        Address galaForArtsAddress = new Address("Grand Arts at Elegant Plaza", "456 Celebration Avenue", "Texas City", "Texas", "USA");
        galaForTheArts.AddAddress(galaForArtsAddress);
        Console.WriteLine(galaForTheArts.StandardDetails());

        Console.WriteLine("---------------------------------------------------------------");
    
        NetworkingExtravaganza networkingExtravaganza = new NetworkingExtravaganza("Networking Extravaganza 2023", "Join us for an evening of networking and socializing at the Networking Extravaganza 2023! This\nevent is a fantastic opportunity to connect with professionals from various industries and expand\nyour professional network.", "December 17, 2023", "6:00PM - 9:00PM", "December 10, 2023", "networkingextravaganza.com/NetworkingExtravaganza2023", "networkingextravaganza@gmail.com", "In the case of inclement weather, the Networking Extravaganza will be moved to Luxe\nConference Center's indoor facilities. Attendees will be notified via email in case\nof any changes.");
        Address networkingExtravaganzaAddress = new Address("Grand Hall at Luxe Conference Center", "123 Networking Avenue", "Cityville, CA 12345", "California", "USA");
        networkingExtravaganza.AddAddress(networkingExtravaganzaAddress);
        Console.WriteLine(networkingExtravaganza.FullDetails());

        Console.WriteLine("---------------------------------------------------------------");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Nature Fest 2023", "Join us for NatureFest 2023, a celebration of the great outdoors! This event is an open invitation to\nnature enthusiasts, families, and anyone looking to bask in the beauty of the natural world. There's\nno limit on attendees, so bring your friends and family for a day filled with fun, games, and\nappreciation for the environment.", "Saturday, December 16, 2023", "Outdoor Gathering", "As this event is held outdoors, please keep an eye on the weather forecast for any updates or changes.", "Green Meadows Park");
        Console.WriteLine(outdoorGathering.ShortDescription());

        Console.WriteLine("---------------------------------------------------------------");
    }
}