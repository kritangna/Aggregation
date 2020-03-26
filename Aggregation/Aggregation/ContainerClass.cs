using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class ContainerClass
    {
        //private int id;
        //private string name;
        private readonly IContainedClass1 _class1Obj;
        private readonly IContainedClass2 _class2Obj;
        public int ContainerClassId { get; set; }
        public string ContainerClassName { get; set; }
        public ContainerClass(IContainedClass1 class1Obj,IContainedClass2 class2Obj)
        {
            _class1Obj = class1Obj;
            _class2Obj = class2Obj;
            Console.WriteLine("I am inside ContainerClass");
            //Console.ReadKey();
        }
        public void GetContainedClassDetails()
        {
            Console.WriteLine(_class1Obj.MyContainedClass1Name());
            Console.WriteLine(_class2Obj.MyContainedClass2Name());
            //Console.ReadKey();
        }
    }
}
