using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Section8
{
    abstract class superClass
    {
        abstract public void Disp();
    }

    class subClassA : superClass
    {
        public override void Disp()
        {
            Console.WriteLine("商品名はPRODUCTです");
        }
    }

    class subClassB : superClass
    {
        public override void Disp()
        {
            Console.WriteLine("商品名はMAMUFACTUREです");
        }
    }

    class subClassC : superClass
    {
        public override void Disp()
        {
            Console.WriteLine("商品名はGOODSです");
        }
    }
}
