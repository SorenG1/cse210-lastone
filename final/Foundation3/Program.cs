using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("225 W 6th S", "Rexburg", "ID", "USA");
        Address a2 = new Address("241 Sleepy Blvd", "Houston", "TX", "USA");
        Address a3 = new Address("Boulevard Popocatepetl #23", "Taxco", "Guerrero", "Mexico");

        Lecture lecture = new Lecture(
            "Spaghetti Convention",
            "The best spaghettis in the world will be served and analyzed by critics",
            "Feb 31",
            "18:00",
            a1,
            "Chef Sobretti",
            200
        );

        Reception reception = new Reception(
            "Soren and Anna's Wedding Reception",
            "Please RSVP, as we will need to calculate how many tacos each person will eat",
            "Dec 18",
            "17:00",
            a2,
            "rsvp@protonmail.com"
        );

        OutdoorGathering outdoor = new OutdoorGathering(
            "Volleyball and BBQ",
            "Bring your best summer clothes, and a drink",
            "April 21",
            "12:00",
            a3,
            "Sunny and Warm :)"
        );

        Console.WriteLine("LECTURE: ");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShort());
        Console.WriteLine();
        
        Console.WriteLine("RECEPTION: ");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShort());
        Console.WriteLine();

        Console.WriteLine("OUTDOOR GATHERING: ");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetShort());
    }
}