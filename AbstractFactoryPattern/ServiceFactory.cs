using AbstractFactoryPattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ServiceFactory
    {
        public IDeviceFactory GetFactory(string DeviceType)
        {
            switch(DeviceType)
            {
                case "Laptop": return new LaptopFactory();
                case "Mobile": return new MobileFactory();
                case "Tablet": return new TabletFactory();
                default: return null;
            }
        }
    }
}
