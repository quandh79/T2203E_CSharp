using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.session4
{
    public delegate void StringToVoid(string s);
    internal class Demodelegate
    {
        public Demodelegate() { }   
        public void ShowInfo(string s) { 
        Console.WriteLine("ss"+s);
        }
        public static void SayHello(string str)
        {
            Console.WriteLine("ok "+str);
        }
    }
}
