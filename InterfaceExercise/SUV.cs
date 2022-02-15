using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
       public SUV()
        {
        }

        public double EngineSize { get; set; } = 2.4;
        public string Make { get; set; } = "Kia";
        public string Model { get; set; } = "Sorento";
        public string Year { get; set; } = "2022";
        public string CompanyName { get; set; } = "Kia";
        public string Motto { get; set; } = "Movement That Inspires";
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
