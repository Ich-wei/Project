using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Section7
{
    class Button
    {
        public virtual void Push()
        {
            Console.WriteLine("電源スイッチが押されました。");
        }
    }

    class TV : Button
    {
        public override void Push()
        {
            base.Push();
            Console.WriteLine("テレビの電源がオンです。");
        }

        public void Push(int a)
        {
            Console.WriteLine(a + "チャンネルのボタンが押されました。");
            Console.WriteLine(a + "チャンネルを表示します。");
        }
    }

    class DvdPlayer : Button
    {
        public override void Push()
        {
            base.Push();
            Console.WriteLine("スタンバイしています。");
        }

        public void Push(int a)
        {
            Console.WriteLine(a + "ボタンが押されました。");
            Console.WriteLine("チャプター" + a + "を再生します。");
        }
    }
}
