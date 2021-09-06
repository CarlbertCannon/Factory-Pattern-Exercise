using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Exercise
{
        public class Car : IVehicle
        {

            public void drive()
            {
            Console.WriteLine("I'm currently driving");
            }
            public int amountOfTires()
            {
                int tires = 4;


                if (tires == 4)
                {
                    Console.WriteLine("Here is your car!");
                }
                else
                {
                    return 4;
                }
                return tires;
            }
        }
}