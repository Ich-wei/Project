using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter3.Section7;
using Chapter3.Section8;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7
            //Player player = new Player();

            superClass[] a = { new subClassA(), new subClassB(), new subClassC() };
            Call(a);
        }

        static void Call(params superClass[] args)
        {
            foreach (superClass o in args)
            {
                o.Disp();
            }
        }
    }
}
