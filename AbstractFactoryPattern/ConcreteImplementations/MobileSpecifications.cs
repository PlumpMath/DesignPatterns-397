using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteImplementations
{
    class MobileSpecifications : ISpecifications
    {
        public List<string> GetHardwareSpecifications()
        {
            List<string> specifications = new List<string>();
            specifications.Add("2GB RAM");
            specifications.Add("AMD processor");
            specifications.Add("128 GB SSD");
            return specifications;
        }

        public List<string> GetSoftwareSpecifications()
        {
            List<string> specifications = new List<string>();
            specifications.Add("Android OS");
            specifications.Add("Microsoft Enterprise applications");
            specifications.Add("Office 365 online pack");
            return specifications;
        }
    }
}
