using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    interface IDeviceCost
    {
        double GetBaseCost();

        double GetAccessoriesCost();
    }
}
