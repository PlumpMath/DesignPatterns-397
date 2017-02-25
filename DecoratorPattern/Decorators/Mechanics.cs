using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Mechanics : VehicleAccessoriesType
    {
        double ExteriorsPrice = 5000;
        Mechanics(IVehicle vehicleBase)
        {
            this.vehicleBase = vehicleBase;
        }
        public override double GetPrice()
        {
            return this.vehicleBase.GetPrice() + ExteriorsPrice;
        }
    }
}
