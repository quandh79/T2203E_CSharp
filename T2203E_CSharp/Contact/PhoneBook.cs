using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.Contact
{
    internal class PhoneBook : AbstractPhone
    {
       public List<PhoneNumber> PhoneList { get; }
        public PhoneBook()
        {
            PhoneList = new List<PhoneNumber>();
        }
        public override void insertPhone(string name, string phone)
        {
          
            foreach(var p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                   
                    if(!p.Phone.Contains(phone))
                    {
                        return;
                    }
                    p.Phone.Add(phone);
                    return;
                }
            }
           PhoneNumber pn = new PhoneNumber(name, phone);
            PhoneList.Add(pn);  
        }

        public override void RemovePhone(string name)
        {
            foreach(PhoneNumber pn in PhoneList) { 
            if(pn.Name.Equals(name))
                {
                    PhoneList.Remove(pn);
                    return;
                }
            }
        }

        public override PhoneNumber SearchPhone(string name)
        {
            foreach(var p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }
            }
            return null;
        }

        public override void Sort()
        {
            PhoneList.Sort((o1, o2) =>
            {
                return o1.Name.CompareTo(o2.Name);
            });
        }

        public override void UpdatePhone(string name, string oldphone, string newphone)
        {
            foreach (PhoneNumber pn in PhoneList)
            {
                if (pn.Name.Equals(name) && pn.Phone.Contains(oldphone)){
                    pn.Phone.Remove(oldphone);
                    pn.Phone.Add(newphone);
                    return;
                }





            }

        }

    }
}

