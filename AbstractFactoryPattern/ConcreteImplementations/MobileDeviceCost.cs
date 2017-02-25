using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteImplementations
{
    class MobileDeviceCost : IDeviceCost
    {
        public double GetAccessoriesCost()
        {
            return 5000;
        }

        public double GetBaseCost()
        {
            return 50000;
        }
    }
}
