using System;
namespace oop_practice
{
// "implementing" an interface on a class looks much like "inheriting" from another
    class Car : Vehicle, IRideable
    {
        // all previous code for Car ...
    public string Make;
    public string Model;
    public string Color;
    // but when we define a constructor for Car, we need to satisfy any constructor requirements
    // for at least ONE constructor on the parent Vehicle class
    public Car(string color, string make, string model)
    {
        Make = make;
        Model = model;
    }
        // we can use DistanceTraveled to be a wrapper for "Odometer"
        public double DistanceTraveled
        {
            get { return Odometer; }
            set { Odometer = value; }
        }
        public void Ride(double distance)
        {
            // here we can choose implement this method however we wish
            // as long as we meet the requirements of the method
            Console.WriteLine("... driving ...");
            DistanceTraveled += distance;
        }
    }

}