using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Equipment;
using Trestlebridge.Models.Plants;

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
                    ChooseMeatResource.CollectInput(farm);
                    break;
                case 5:
                    ChooseSeedResource.CollectInput(farm);
                    break;
                default:
                    break;
            }

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