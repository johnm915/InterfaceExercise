using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }

        public double EngineSize { get; set; } = 3.2;
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Civic";
        public string Year { get; set; } = "2021";
        public string CompanyName { get; set; } = "Honda Mortor Company";
        public string Motto { get; set; } = "The Power of Dreams";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is moving forward.....");
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
