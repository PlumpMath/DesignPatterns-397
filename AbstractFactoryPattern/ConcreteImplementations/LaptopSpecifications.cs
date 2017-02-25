using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteImplementations
{
    class LaptopSpecifications : ISpecifications
    {
        public List<string> GetHardwareSpecifications()
        {
            List<string> specifications = new List<string>();
            specifications.Add("8GB RAM");
            specifications.Add("I7 processor");
            specifications.Add("1 TB SSD");
            return specifications ;
        }

        public List<string> GetSoftwareSpecifications()
        {
            List<string> specifications = new List<string>();
            specifications.Add("Windows 10");
            specifications.Add("Visual Studio Enterprise");
            specifications.Add("SQL Server 2014");
            return specifications;
        }
    }
}
