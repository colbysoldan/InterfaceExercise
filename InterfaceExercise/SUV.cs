using System;
namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        //SUV members
        public string cargoSpace;
        public bool rowThreeRemovable;

        //ICompany members
        public string Logo { get; set; }
        public string Slogan { get; set; }

        //IVehicle members
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string Color { get; set; }
        public bool IsElectric { get; set; }
    }
}

