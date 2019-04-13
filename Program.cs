using System;
using System.Linq;

namespace Trestlebridge
{
    class Program
    {
        static void DisplayBanner ()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
 |T||r||e||s||t||l||e||b||r||i||d||g||e|
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
           |F||a||r||m||s|
           +-++-++-++-++-+");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayBanner();
                Console.WriteLine("1. Create Facility");
                Console.WriteLine("2. Purchase Animals");
                Console.WriteLine("3. Purchase Seeds");
                Console.WriteLine("4. Exit.");
                Console.WriteLine();

                Console.WriteLine("Choose a FARMS option");
                Console.Write("> ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    DisplayBanner();
                    Console.WriteLine("1. Grazing field");
                    Console.WriteLine("2. Plowed field");
                    Console.WriteLine("3. Natural field");
                    Console.WriteLine("4. Chicken house");
                    Console.WriteLine("5. Duck house");

                    Console.WriteLine();
                    Console.WriteLine("Choose what you want to create");

                    Console.Write("> ");
                    string input = Console.ReadLine();
                }
                else if (option == "2")
                {
                    Console.Write("What should I reverse? ");
                    string input = Console.ReadLine();
                    Console.WriteLine(new string(input.Reverse().ToArray()));
                }
                else if (option == "4")
                {
                    Console.WriteLine("Today is a great day for farming");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid option: {option}");
                }
            }
        }
    }
}
