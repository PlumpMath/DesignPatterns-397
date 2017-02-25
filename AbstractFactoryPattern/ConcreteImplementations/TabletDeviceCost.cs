using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteImplementations
{
    class TabletDeviceCost : IDeviceCost
    {
        public double GetAccessoriesCost()
        {
            return 5000;
        }

        public double GetBaseCost()
        {
            return 25000;
        }
    }
}
