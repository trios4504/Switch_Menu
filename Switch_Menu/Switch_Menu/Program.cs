using System;

namespace Switch_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your favorite Nightmare Before Christmas song:");
            Console.WriteLine("1. This is Halloween");
            Console.WriteLine("2. What's this?");
            Console.WriteLine("3. Kidnap the Sandy Claws");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            switch(userNumber)
                {
                case 1:
                    Console.WriteLine("That is a good song and great theme song.");
                break;
                case 2:
                    Console.WriteLine("That is the most popular song.");
                break;
                case 3:
                    Console.WriteLine("That is a good song and the cover from Korn is also good.");
                break;
                default:
                    Console.WriteLine("Selection not recognized.");
                break;
                }
        }
    }
}
