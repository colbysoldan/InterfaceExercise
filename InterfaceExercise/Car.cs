using System;
namespace InterfaceExercise
{
	public class Car : ICompany, IVehicle
	{
        //Car members
        public string trunkSize;
        public bool spoiler;

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

