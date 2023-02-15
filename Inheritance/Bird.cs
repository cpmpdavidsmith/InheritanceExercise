using System;
namespace Inheritance
{
	public class Bird : Animal//Derived class : Animal//Base class
	{
		public Bird()
		{
			IsAlive = true;
			Habitat = "forest";
			LandSeaFlying = "flying";
			ExpectedAge = 80;
		}
		//^^^^^^^working with CONSTRUCTORand it does have SCOPE^^^^^^^^
		//^^^^^^^^^^this is "setup work"^^^^^^^
		public bool Flying{ get; set; }
		public string FeatherColors { get; set; }
		public double BeakLength { get; set; }
	}
}

