using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Asynchronous
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();
            obj2.DelDisp = new Del(obj1.ShowMsg);
            IAsyncResult during = obj2.DelegateCall();
            while(!during.IsCompleted)
            {
                Thread.Sleep(500);
                Console.Write(">");
            }
            Console.WriteLine("処理が終了しました。");
        }
    }

    delegate void Del(string msg);

    class Class1
    {
        internal void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
            Thread.Sleep(5000);
        }
    }

    class Class2
    {
        internal Del DelDisp;

        internal IAsyncResult DelegateCall()
        {
            IAsyncResult procRresult = DelDisp.BeginInvoke("デリゲート実行中", new AsyncCallback(CallMethod), DelDisp);
            return procRresult;
        }

        internal void CallMethod(IAsyncResult par)
        {
            Del DelegateRun = (Del)par.AsyncState;
            DelegateRun.EndInvoke(par);
        }
    }
}
