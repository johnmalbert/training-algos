namespace oop_practice
{
    interface IRideable
    {
        // any class that implements "IRideable", must have the following methods/properties
        
        // in interfaces, "method signatures" are used.
        // this means that there is no body to this method,
        // only its return type, name, and parameters
        void Ride(double distance);
        
        // properties can also be used in interfaces (fields can not)
        double DistanceTraveled {get;set;}
    }
}