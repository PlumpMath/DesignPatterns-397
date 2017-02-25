using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteImplementations
{
    class TabletSpecifications : ISpecifications
    {
        public List<string> GetHardwareSpecifications()
        {
            List<string> specifications = new List<string>();
            specifications.Add("1GB RAM");
            specifications.Add("AMD processor");
            specifications.Add("64 GB SSD");
            return specifications;
        }

        public List<string> GetSoftwareSpecifications()
        {
            List<string> specifications = new List<string>();
            specifications.Add("IOS 10");
            specifications.Add("Microsoft Enterprise applications");
            specifications.Add("Office 365 online pack");
            return specifications;
        }
    }
}
