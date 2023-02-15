using System;

class Program
{
    static void Main(string[] args)
    {
        // creates at least one event of each type and sets all of their values. Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.
        Console.WriteLine("\n\tEvent #1");
        EventAddress address1 = new EventAddress("631 E 2nd S", "Grace", "ID", "83241");
        Lecture event1 = new Lecture("How to write code", "A wonderful lecture on how to code a program in c-sharp", "March 4, 2023", "4:00", "Brother Wright", 40);
        event1.setAddress(address1);
        Console.WriteLine($"\n{event1.StandardDetails()}");
        Console.WriteLine($"\n{event1.FullDetails()}");
        Console.WriteLine($"\n{event1.ShortDescription()}\n");

        Console.WriteLine("«««««««««««««««««««««««««");

        Console.WriteLine("\n\tEvent #2");
        EventAddress address2 = new EventAddress("BYUI Center Square", "Rexburg", "ID", "83440");
        Reception event2 = new Reception("Mr. and Mrs. Wedding Reception", "Come celebrate the wedding of George Anderson and Sally Long", "February 28, 2023", "6-9 p.m", "the_andersons@gmail.com");
        event2.setAddress(address2);
        Console.WriteLine($"\n{event2.StandardDetails()}");
        Console.WriteLine($"\n{event2.FullDetails()}");
        Console.WriteLine($"\n{event2.ShortDescription()}\n");

        Console.WriteLine("«««««««««««««««««««««««««");

        Console.WriteLine("\n\tEvent #3");
        EventAddress address3 = new EventAddress("Coconut Island", "Hilo", "HI", "96720");
        Outdoor event3 = new Outdoor("Summer Vacation Celebration", "Come celebrate the beggining of summer with us at cocos for swimming and fishing", "June 3, 2023", "12-3 p.m", "82 degrees and Sunny");
        event3.setAddress(address3);
        Console.WriteLine($"\n{event3.StandardDetails()}");
        Console.WriteLine($"\n{event3.FullDetails()}");
        Console.WriteLine($"\n{event3.ShortDescription()}\n");
    }
}