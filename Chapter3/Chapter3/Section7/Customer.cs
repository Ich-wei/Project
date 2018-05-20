using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Section7
{
    class Player
    {
        public Player()
        {
            Customer objA = new Country();
            objA.registry("Gerry Lopez");
            Console.WriteLine(objA.name);

            SuperClass objB = new SubClass();
            objB.Disp();

            TV tv = new TV();
            Button bt = new TV();
            bt.Push();
            tv.Push(6);

            DvdPlayer dvd = new DvdPlayer();
            bt = dvd;
            bt.Push();
            dvd.Push(10);
        }
    }

    class Customer
    {
        public string name;
        public void registry(string name)
        {
            this.name = name;
        }
    }

    class Country : Customer
    {
        string country;
        void registry(string name, string country)
        {
            this.name = name;
            this.country = country;
        }
    }
}
