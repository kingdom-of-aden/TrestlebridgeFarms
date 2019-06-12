using System;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");
            Console.WriteLine ("3. Duck House"); 
            Console.WriteLine("4. Chicken Coop");

            // Add in other facilities

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();


            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("You created a grazing field! Good Job!");
                    Thread.Sleep(1000);
                    break;
                case 3:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("You created a Duck House! Good Job!");
                    Thread.Sleep(1000);
                    break;
                case 4:
                    farm.AddChickenCoop(new ChickenCoop());
                    Console.WriteLine("You built a chicken coop! You're so strong! WOW WOW WOW");
                    Thread.Sleep(1000);
                    break;
                default:
                    break;
            }
        }
    }
}