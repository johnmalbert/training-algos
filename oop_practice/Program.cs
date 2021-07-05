using System;

namespace oop_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse wilbur = new Horse("Wilbur", 120);
            Car volvo = new Car("Yellow", "Volvo", "240");
            
            // sally starts out with a horse
            Person sally = new Person("Sally", wilbur);
            // sally can ride her horse
            sally.GoSomewhere(34);
            
            // we can also change her Transport to a Car
            sally.Transport = volvo;
            sally.GoSomewhere(100);
            sally.GetInfo();
        }
    }
}
