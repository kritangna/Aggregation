using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class ContainedClass2 : IContainedClass2
    {
        public ContainedClass2()
        {
            Console.WriteLine("I am inside ContainedClass2");
           // Console.ReadKey();
        }
        public string MyContainerClass2Name()
        {
            return "ContainedClass2";
        }
    }
}
