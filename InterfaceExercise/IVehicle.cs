using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int Wheels { get; set; }
		public int Doors { get; set; }
		public string Color { get; set; }
		public bool IsElectric { get; set; }
	}
}

