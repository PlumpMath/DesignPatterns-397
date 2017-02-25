using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Exteriors : VehicleAccessoriesType
    {
        double ExteriorsPrice = 3000;
        public Exteriors(IVehicle vehicleBase)
        {
            this.vehicleBase = vehicleBase;
        }
        public override double GetPrice()
        {
            return this.vehicleBase.GetPrice() + ExteriorsPrice; 
        }
    }
}
