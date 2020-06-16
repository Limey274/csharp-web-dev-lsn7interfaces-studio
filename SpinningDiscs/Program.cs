using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            DVD dvd = new DVD("FIght Club", "DVD", 1000);
            CD cd = new CD("The Wall", "Music", 500);
            // TODO: Call each CD and DVD method to verify that they work as expected.

            dvd.SpinDisc();
            cd.SpinDisc();

            Console.WriteLine();
            
            dvd.GetRead();
            cd.GetRead();
            Console.WriteLine();

            dvd.PlayDisc();
            Console.WriteLine();
            cd.PlayDisc();

            Console.WriteLine();
            cd.Unreadable();
            dvd.Unreadable();


        }
    }
}
