using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;

namespace Trestlebridge.Actions
{
    public class ChooseMeatResource {

        static List<Discard> discards = new List<Discard>();

        public static void CollectInput (Farm farm) {

            Console.Clear();

            List<dynamic> meatProducingFacilities = new List<dynamic>();

            farm.GrazingFields.ForEach(field => {
                    meatProducingFacilities.Add(field);
            });

            farm.ChickenHouses.ForEach(field => {
                    meatProducingFacilities.Add(field);
            });

            // List appropriate resource facilities
            int i = 1;
            meatProducingFacilities.ForEach(f => {
                Console.WriteLine($"{i}. {f.GetType().Name}");
                i++;
            });

            Console.WriteLine ($"{i}. Complete Processing");

            int fieldIndex = Prompt.Query("Which facility has the resources to use?") - 1;

            // If user chose to complete processing
            if (fieldIndex + 1 == i) {

                // Output the result of processing the resources
                farm.MeatProcessor.ProcessResources();

                // Remove items from source list
                ChooseMeatResource.discards.ForEach(d => {
                    var facility = meatProducingFacilities[d.ListIndex];
                    facility.DiscardResource(d.ItemIndex);
                });
                ChooseMeatResource.discards.Clear();
                Console.ReadLine();
            } else {
                var chosenFacility = meatProducingFacilities[fieldIndex];

                // List resources in chosen facility
                i = 1;
                foreach (var resource in chosenFacility.Resources)
                {
                    var animal = (IResource) resource;
                    if (!animal.InProcess) {
                        Console.WriteLine($"{i}. {animal.Type}");
                    }
                    i++;
                }

                int resourceIndex = Prompt.Query("Which resource?") - 1;
                var chosenResource = (IResource)chosenFacility.Resources[resourceIndex];

                chosenResource.InProcess = true;
                farm.MeatProcessor.Resources.Add(chosenResource);

                ChooseMeatResource.discards.Add(new Discard {
                    ItemIndex = resourceIndex,
                    ListIndex = fieldIndex
                });

                ChooseMeatResource.CollectInput(farm);
            }
        }
    }
}
