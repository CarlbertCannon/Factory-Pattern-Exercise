using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Exercise
{
    class VehicleFactory
    {
            public static IVehicle GetVehicle(string newVehicle)
            {

                switch (newVehicle)
                {
                    case "1":
                        return new Car();
                    case "2":
                        return new Motorcycle();
                    default:
                    return new Car(); 

                }


            } 
    }
}
