using System;
namespace oop_practice
{
    class Vehicle
    {
        //All past code for the Vehicle should still be present
        public int NumPassengers;
        public string Color;
        public double Odometer;
        // Say Vechicle has two overloaded constructors
        // We will either need to pass up two values (="keyword from-rainbow">int, string), from Car ...
        public Vehicle(int numPas, string col)
        {   
            NumPassengers = numPas;
            Color = col;
            Odometer = 0;
        }
        // Or just one string value.  
        public Vehicle()
        {
            NumPassengers = 5;
            Color = "Gray";
            Odometer = 0;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Num Passengers: {NumPassengers}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Miles: {Odometer}");
        }
    }
     

}