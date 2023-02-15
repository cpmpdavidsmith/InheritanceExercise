
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            //Bird davesBird = new Bird()
            //{

            //};
            //^^^^^object Initializer Syntax^^^^^
            var Parrot = new Bird();
            Parrot.Flying = true;
            Parrot.FeatherColors = "Blue, Yellow & Red";
            Parrot.BeakLength = 1.5;
            //^^^^Dot Notation^^^^^^^^^^
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var BeardedDragon = new Reptile()
            {
                Exosceleton = true,
                FeedingPerDay = 2,
                Nocternal = false,
                Shed = true
            };
            //we can console write line this out or list with array or List
            var allAnimals = new Animal[] { Parrot, BeardedDragon };
            //^^^^^^set up list to then access the instance^^^^^^
            foreach (var indevidualAnimal in allAnimals)
            {
                Console.WriteLine($"Alive: {indevidualAnimal.IsAlive}");
                Console.WriteLine($"This Animal natrally lives in a {indevidualAnimal.Habitat} habitat.");
                Console.WriteLine($"This is a {indevidualAnimal.LandSeaFlying} animal.");
                Console.WriteLine($"This animal can live up to {indevidualAnimal.ExpectedAge} years of age.");
                Console.WriteLine($"");//divider in text--------------------------

            }
        }
    }
}
