using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteImplementations
{
    class LaptopDeviceCost : IDeviceCost
    {
        public double GetAccessoriesCost()
        {
            return 2500;
        }

        public double GetBaseCost()
        {
            return 100000;
        }
    }
}
