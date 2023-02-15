using System;
namespace Inheritance
{
	public class Reptile : Animal//Derived Class : Animal//Base Class
	{
		public Reptile()
		{
			IsAlive = true;
			Habitat = "semi-desert";
			LandSeaFlying = "Land";
			ExpectedAge = 12;
		}

		public bool Exosceleton { get; set; }
		public double FeedingPerDay { get; set; }
		public bool Nocternal { get; set; }
		public bool Shed { get; set; }

		//^^^Automatic Properties^^^^with read and wroite capabilities

		//YOu can create a METHOD "public void printParrotDetails" within this class
		//that prints out a console writeline connecting PROPERTIES TO IT NOTE YOU
		//CAN USE ALL PROPERTIES IN THE OTHER CLASSES.
		//THEN  in the PROGRAM you must make instructer(make new animal) using curly brackets to
		//list additional properties "name = scott" then run method
		//"(new methos name).printParrotDetails()"
	}
}

