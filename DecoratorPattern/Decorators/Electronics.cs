using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Electronics : VehicleAccessoriesType
    {
        double ExteriorsPrice = 4000;
        public Electronics(IVehicle vehicleBase)
        {
            this.vehicleBase = vehicleBase;
        }
        public override double GetPrice()
        {
            return this.vehicleBase.GetPrice() + ExteriorsPrice;
        }
    }
}
