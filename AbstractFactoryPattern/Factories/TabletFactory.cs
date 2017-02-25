using AbstractFactoryPattern.ConcreteImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    class TabletFactory : IDeviceFactory
    {
        public IDeviceCost GetDeviceCost()
        {
            return new TabletDeviceCost();
        }

        public ISpecifications GetSpecifications()
        {
            return new TabletSpecifications();
        }
    }
}
