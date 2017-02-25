using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the type of Device Mobile/Laptop/Tablet :");
            string deviceType = Console.ReadLine();

            ServiceFactory factory = new ServiceFactory();
            IDeviceFactory device = factory.GetFactory(deviceType);

            Console.WriteLine("Base Cost :" + device.GetDeviceCost().GetBaseCost());
            Console.WriteLine("Accessories Cost :" + device.GetDeviceCost().GetAccessoriesCost());
            Console.WriteLine("Hardware Specifications : " + string.Join(",", device.GetSpecifications().GetHardwareSpecifications()));
            Console.WriteLine("Software Specifications :" + string.Join(",", device.GetSpecifications().GetSoftwareSpecifications()));

            Console.ReadLine();
        }
    }
}
