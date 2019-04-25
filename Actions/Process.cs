using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Actions {
    public class Process {
        public static void CollectInput (Farm farm) {
            Console.Clear();

            Console.WriteLine ("1. Composter");
            Console.WriteLine ("2. Egg Gatherer");
            Console.WriteLine ("3. Feather Harvester");
            Console.WriteLine ("4. Meat Processor");
            Console.WriteLine ("5. Seed Harvester");

            Console.WriteLine ();
            Console.WriteLine ("Which equipment do you want to use?");

            Console.Write ("> ");
            string input = Console.ReadLine ();

            switch (Int32.Parse(input))
            {
                case 1:
                    Process.ChooseCompostableResource(farm);
                    break;
                case 2:
                    Process.ChooseEggResource(farm);
                    break;
                case 3:
                    Process.ChooseFeatherResource(farm);
                    break;
                case 4:
                    Process.ChooseMeatResource(farm);
                    break;
                case 5:
                    Process.ChooseSeedResource(farm);
                    break;
                default:
                    break;
            }

        }

        private static void ChooseSeedResource(Farm farm)
        {
            // List appropriate resource facilities
            int i = 1;
            farm.PlowedFields.ForEach(f => {
                Console.WriteLine($"{i}. {f.GetType().Name}");
                i++;
            });
            Console.WriteLine ($"{i}. Complete Processing");

            Console.WriteLine ();
            Console.WriteLine ("Which facility has the resources to use?");

            Console.Write ("> ");
            int fieldIndex = Int32.Parse(Console.ReadLine ()) - 1;

            // If user chose to complete processing
            if (fieldIndex + 1 == i) {
                farm.SeedHarvester.ProcessResources();
                Console.ReadLine();
            } else {
                var chosenField = farm.PlowedFields[fieldIndex];

                // List resources in chosen facility
                i = 1;
                chosenField.Resources.ForEach(r => {
                    if (!r.InProcess) {
                        Console.WriteLine($"{i}. {r.Type}");
                    }
                    i++;
                });

                Console.WriteLine ();
                Console.WriteLine ("Which resource?");

                Console.Write ("> ");
                int resourceIndex = Int32.Parse(Console.ReadLine ()) - 1;
                var chosenResource = chosenField.Resources[resourceIndex];

                chosenResource.InProcess = true;
                farm.SeedHarvester.Resources.Add(chosenResource);

                Process.ChooseSeedResource(farm);
            }
        }

        private static void ChooseMeatResource(Farm farm)
        {
            throw new NotImplementedException();
        }

        private static void ChooseFeatherResource(Farm farm)
        {
            throw new NotImplementedException();
        }

        private static void ChooseEggResource(Farm farm)
        {
            throw new NotImplementedException();
        }

        private static void ChooseCompostableResource(Farm farm)
        {
            throw new NotImplementedException();
        }
    }
}