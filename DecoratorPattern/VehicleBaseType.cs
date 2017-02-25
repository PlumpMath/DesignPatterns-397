using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    interface IVehicle
    {
        double GetPrice();
    }

    class VehicleBaseType : IVehicle
    {
        private int vehicleBasePrice = 10000;

        public double GetPrice()
        {
            return vehicleBasePrice;
        }

    }
}
