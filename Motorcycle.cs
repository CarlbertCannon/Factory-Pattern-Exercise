using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Exercise
{
    class Motorcycle : IVehicle
    {
        public void drive()
        {
            Console.WriteLine("I'm currently driving");
        }
        public int amountOfTires()
            {

                var tires = 2;

                if (tires == 2)
                {
                    Console.WriteLine("Here is your motorcycle!");
                }
                else
                {
                    return 2;
                }
                return tires;
            }
        }
}
