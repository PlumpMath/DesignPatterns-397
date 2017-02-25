using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new VehicleBaseType();
            IVehicle vehicleWithExteriors = new Exteriors(vehicle);
            IVehicle vehicleWithExteriorsAndElectronics = new Electronics(vehicleWithExteriors);

            Console.WriteLine("Price of vehicle base type : " + vehicle.GetPrice());
            Console.WriteLine("Price of vehicle base type with exteriors : " + vehicleWithExteriors.GetPrice());
            Console.WriteLine("Price of vehicle base type with exteriors and electronics : " + vehicleWithExteriorsAndElectronics.GetPrice());

            Console.ReadLine();
        }
    }
}
