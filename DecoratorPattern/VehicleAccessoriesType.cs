﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class VehicleAccessoriesType : IVehicle
    {
        internal IVehicle vehicleBase;
        public abstract double GetPrice();
    }
}
