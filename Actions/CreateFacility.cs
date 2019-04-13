using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static IFacility CollectInput () {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");
            Console.WriteLine ("3. Natural field");
            Console.WriteLine ("4. Chicken house");
            Console.WriteLine ("5. Duck house");

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();

            switch (Int32.Parse(input))
            {
                case 1:
                    return new GrazingField();
                    break;
                default:
                    break;
            }
        }
    }
}