using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseSeedField {
        public static void CollectInput (Farm farm, ISeedProducing plant) {
            Console.Clear();

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Plowed Field");
            }

            Console.WriteLine ();
            Console.WriteLine ($"Place the {plant.Type} where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());

            // farm.GrazingFields[choice].AddResource(animal);  TODO: Have this bug for boilerplate
            farm.PlowedFields[choice-1].AddResource(plant);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
                    https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/introduction-to-generics
             */
            // farm.PurchaseResource<IGrazing>(animal, choice-1);

        }
    }
}