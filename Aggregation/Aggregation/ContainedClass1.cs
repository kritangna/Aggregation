using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class ContainedClass1 : IContainedClass1
    {
        public ContainedClass1()
        {
            Console.WriteLine("I am inside ContainedClass1");
            //Console.ReadKey();
        }
        public string MyContainerClass1Name()
        {
            return "ContainedClass1";
        }
        public int ReturnNumber()
        {
            return 23;
        }
    }
}
