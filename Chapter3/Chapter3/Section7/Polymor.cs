using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Section7
{
    class SuperClass
    {
        public virtual void Disp()
        {
            Console.WriteLine("製品名は登録されていません。");
        }
    }

    class SubClass : SuperClass
    {
        public override void Disp()
        {
            Console.WriteLine("製品名はPRODUCTです");
        }
    }
}