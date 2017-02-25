using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    interface ISpecifications
    {
        List<string> GetHardwareSpecifications();

        List<string> GetSoftwareSpecifications();
    }
}
