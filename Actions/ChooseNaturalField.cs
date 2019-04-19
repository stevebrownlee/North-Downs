using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseNaturalField {
        public static void CollectInput (Farm farm, ICompostable plant) {
            Console.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Natural Field");
            }

            Console.WriteLine ();
            Console.WriteLine ($"Place the {plant.Type} where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());

            // farm.GrazingFields[choice].AddResource(animal);  TODO: Have this bug for boilerplate
            farm.NaturalFields[choice-1].AddResource(plant);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
                    https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/introduction-to-generics
             */
            // farm.PurchaseResource<IGrazing>(animal, choice-1);

        }
    }
}