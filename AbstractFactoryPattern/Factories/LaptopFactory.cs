using AbstractFactoryPattern.ConcreteImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    class LaptopFactory : IDeviceFactory
    {
        public IDeviceCost GetDeviceCost()
        {
            return new LaptopDeviceCost();
        }

        public ISpecifications GetSpecifications()
        {
            return new LaptopSpecifications();
        }
    }
}
