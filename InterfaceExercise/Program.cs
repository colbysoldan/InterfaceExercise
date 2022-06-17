using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common. - DONE
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company - DONE
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes 

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size - DONE
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. - DONE
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            List<IVehicle> vehicles = new List<IVehicle>();

            var ferrari = new Car
            {
                Wheels = 4,
                Color = "Red",
                Doors = 2,
                IsElectric = false,
                Logo = "Black horse on yellow shield",
                Slogan = "Only those who dare, truly live.",
                trunkSize = "10.3 cubic feet",
                spoiler = false
            };

            var ram = new Truck
            {
                bedSize = "61.5 cubic feet",
                towRating = "12,750 lbs",
                Wheels = 4,
                Doors = 4,
                Color = "HydroBlue",
                IsElectric = false,
                Logo = "Ram head in shield",
                Slogan = "Guts. Glory. Ram"
            };

            var escalade = new SUV
            {
                cargoSpace = "25.5 cubic feet with seats, 109.1 without",
                rowThreeRemovable = true,
                Logo = "wreath and crest",
                Slogan = "Standard of the World.",
                 Wheels = 4,
                Doors = 4,
                Color = "White",
                IsElectric = false
            };


            vehicles.Add(ram);
            vehicles.Add(ferrari);
            vehicles.Add(escalade);

            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle Stats:\n" +
                $"Wheels: {vehicle.Wheels}\n" +
                $"Doors: {vehicle.Doors}\n" +
                $"Color: {vehicle.Color}\n" +
                $"Electric? {vehicle.IsElectric}\n");
            }

            Console.ReadLine();
            
        }
    }
}
