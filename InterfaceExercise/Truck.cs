using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {

        //Truck members
        public string bedSize;
        public string towRating;

        //IVehicle members
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string Color { get; set; }
        public bool IsElectric { get; set; }

        //ICompany members
        public string Logo { get; set; }
        public string Slogan { get; set; }

    }
}

