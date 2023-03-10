using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static void GetVehicle() 
        {
            Console.WriteLine("How many tires does the vehicle you want to create have?");
            var tires = Console.ReadLine();


            if (tires == "4")
            {
                Car car = new Car();
                car.Drive();
            }
            else if (tires == "2")
            {
                Motorcycle motorcycle = new Motorcycle();
                motorcycle.Drive();
            }
            else if (tires == "1")
            {
                UniCycle unicycle = new UniCycle();
                unicycle.Drive();
            }
            else if (tires == "18")
            {
                BigRig bigRig = new BigRig();
                bigRig.Drive();
            }
            else
            {
                Console.WriteLine("Sorry don't have a vehicle to create with that many wheels.");
            }





        }

    }
}
