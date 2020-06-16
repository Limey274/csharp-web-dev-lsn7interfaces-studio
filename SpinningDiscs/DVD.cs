using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisk
    {
        public DVD(string name, string type, int storage) : base(name, type, storage)
        {

        }



       
        // TODO: Implement your custom interface.
        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570- 1600 rpm.");
        }

        public void GetRead()
        {
            Console.WriteLine("Coming soon to Theaters");
        }

        public void PlayDisc()
        {
            Console.WriteLine($"The first rule of fight club is you do not talk about Fight Club...\nThe second rule of fight club is YOU DO NOT TALK ABOUT FIHGT CLUB\n");
        }

        public void Unreadable()
        {
            Console.WriteLine("Cannot read disc...No movie for you!");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
