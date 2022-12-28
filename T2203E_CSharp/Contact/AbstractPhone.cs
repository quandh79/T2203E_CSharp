using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.Contact
{
    internal abstract class AbstractPhone
    {
        public abstract void insertPhone(String name, String phone);
        public abstract void RemovePhone(String name);
        public abstract void UpdatePhone(String name,string oldphone, String newphone);
        public abstract PhoneNumber SearchPhone(String name);
        public abstract void Sort();
    }
}
