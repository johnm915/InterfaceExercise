using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var truck = new Truck();
            var suv = new SUV();
            var car = new Car();

            var vehicles = new List<IVehicle>() { car, truck, suv };

            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.ChangedGears(false);
                vehicle.Reverse();
            }

           

           

        }
    }
}
