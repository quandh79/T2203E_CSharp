using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.bt
{
    internal abstract class AbstractPhone
    {
        public abstract void insertPhone(String name, String phone);
        public abstract void RemovePhone(String name);
        public abstract void UpdatePhone(String name, String newphone);
        public abstract void SearchPhone(String name);
        public abstract void Sort();
    }
}
