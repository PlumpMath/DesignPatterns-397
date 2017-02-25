using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopterPattern
{
    class FrameworkClass
    {
        public void PerformComplexOperation()
        {
            Console.WriteLine("Framework operation is called.");
        }
    }

    class LibraryClass
    {
        public void PerformSimpleOperation()
        {
            Console.WriteLine("Library operation is called.");
        }
    }
}
