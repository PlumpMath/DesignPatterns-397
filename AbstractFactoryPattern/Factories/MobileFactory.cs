using AbstractFactoryPattern.ConcreteImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    class MobileFactory : IDeviceFactory
    {
        public IDeviceCost GetDeviceCost()
        {
            return new MobileDeviceCost();
        }

        public ISpecifications GetSpecifications()
        {
            return new MobileSpecifications();
        }
    }
}
