using System;
namespace oop_practice
{
    class Horse : IRideable
    {
    // a horse can have its own unique attributes
        public string Name;
        public double Endurance;
        
        // implementing DistanceTraveled a bit differently from a Car,
        // only requirement here, is that it has a property for DistanceTraveled
        public double DistanceTraveled {get;set;}
        
        public Horse(string name, double endurance)
        {
            Name = name;
            Endurance = endurance;
            DistanceTraveled = 0;
        }
        // implementing Ride, again, a bit differently from a Car
        // a Horse can only go so far as its endurance will allow
        public void Ride(double distance)
        {
            if(distance >= Endurance)
                distance = Endurance;
            Console.WriteLine("... riding, heeeyahhh ...");
            DistanceTraveled += distance;
        }
    }
}