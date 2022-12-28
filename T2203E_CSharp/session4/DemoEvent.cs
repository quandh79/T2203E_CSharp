using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.session4
{
    internal class DemoEvent
    {
        public event StringToVoid Print;
        public event StringToVoid Action;
        public event StringToVoid Touch;
        public DemoEvent()
        {
            Print += Demodelegate.SayHello;
            Print += new Demodelegate().ShowInfo;
        }
        public void Invoke()
        {
            Print("Hello World!");
        }
    }
}
