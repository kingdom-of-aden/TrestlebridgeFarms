using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseChickenHouse  {
        public static void CollectInput (Farm farm, IFeed animal) {
            Console.Clear();


            for (int i = 0; i < farm.ChickenCoops.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Chicken Coop ");
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the animal where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());

            //choice must be subtracted by 1 in order to select the proper index in the array.
            farm.ChickenCoops[choice - 1].AddResource(animal);

            Console.WriteLine();
            Console.WriteLine("Press return key to go back to main menu.");
            Console.WriteLine("\n\n\n");
            Console.ReadLine();

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}