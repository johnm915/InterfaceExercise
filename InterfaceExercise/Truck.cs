using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }

        public double EngineSize { get; set; } = 6.2;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F150";
        public string Year { get; set; } = "2018";
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"{GetType().Name} is now in 4-wheel drive");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} driving forward");
            }

        }
                        
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is moving backwards..");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot reverse until we change gears");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} Now in park");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("cant park until we change gears");
            }
        }



        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }









    }
}
