using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Equipment;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions {
    public class ChooseSeedResource {

        static List<Discard> discards = new List<Discard>();

        public static void CollectInput (Farm farm) {

            Console.Clear();

            // List appropriate resource facilities
            int i = 1;
            farm.PlowedFields.ForEach(f => {
                Console.WriteLine($"{i}. {f.GetType().Name}");
                i++;
            });
            Console.WriteLine ($"{i}. Complete Processing");

            int fieldIndex = Prompt.Query("Which facility has the resources to use?") - 1;

            // If user chose to complete processing
            if (fieldIndex + 1 == i) {

                // Output the result of processing the resources
                farm.SeedHarvester.ProcessResources();

                // Remove items from source list
                ChooseSeedResource.discards.ForEach(d => farm.PlowedFields[d.ListIndex].DiscardResource(d.ItemIndex));
                ChooseSeedResource.discards.Clear();
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
                int resourceIndex = Prompt.Query("Which resource?") - 1;
                var chosenResource = chosenField.Resources[resourceIndex];

                chosenResource.InProcess = true;
                farm.SeedHarvester.Resources.Add(chosenResource);

                ChooseSeedResource.discards.Add(new Discard {
                    ItemIndex = resourceIndex,
                    ListIndex = fieldIndex
                });

                ChooseSeedResource.CollectInput(farm);
            }
        }
    }
}