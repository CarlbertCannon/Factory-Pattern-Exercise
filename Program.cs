using System;

namespace Factory_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"What type of vehicle do you want to create?");
            string userInput = Console.ReadLine();

            Console.WriteLine($"How many tires do you want to use? 2 or 4");
            var userVehicle = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(userVehicle);
            vehicle.amountOfTires();

            IVehicle myVehicle = VehicleFactory.GetVehicle(userInput);
            myVehicle.drive();


        }
    }
}
