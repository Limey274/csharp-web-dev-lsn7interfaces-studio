using System;
using System.Diagnostics.CodeAnalysis;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisk
    {
        // TODO: Implement your custom interface.
        public CD(string name, string type, int storage) : base(name, type, storage)
        {
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }

            public void GetRead()
            {
                Console.WriteLine("Loading....");
            }
            public void PlayDisc()
            {
                Console.WriteLine($"What song would you like to play from '{Name}'? Push 'S' to stop");

                Console.Write("Which song number? pick 1, 2, or 3: ");
                 string SongChoice = Console.ReadLine().ToLower();

            

                if (SongChoice == "1")
                {
                    Console.WriteLine("Playing 'Another Brick In The Wall pt. 1'- Pink Floyd");
                }
                else if (SongChoice == "2")
                {
                    Console.WriteLine("Playing 'Another Brick In The Wall pt. 2");
                }
                else if (SongChoice == "3")
                {
                    Console.WriteLine("Playing 'Comfortably Numb'");
                }
                else if (SongChoice == "s")
                {
                Console.WriteLine("Stopping CD");
                }
                else
                {
                    Console.WriteLine("Error");
                }
                                                            
            }
        public void Unreadable()
        {
            Console.WriteLine("Cannot read disc...No music for you!");
        }

    }
}

