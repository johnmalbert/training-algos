using System;
namespace oop_practice
{
    class Person
    {
        public string Name;
        // Any class that implements IRideable can be used!
        public IRideable Transport;
        public double Miles;
        public Person(string name, IRideable trans)
        {
            Name = name;
            Transport = trans;
            Miles = 0;
        }
        // Person can make use of the capabilities of their "transport"
        public void GoSomewhere(double miles)
        {
            Transport.Ride(miles);
            Miles += Transport.DistanceTraveled;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Miles Traveled: {Miles}");
        }
    }

}