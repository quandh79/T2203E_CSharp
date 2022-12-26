using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.bt
{
    internal class PhoneBook : AbstractPhone
    {
        List<Phone> PhoneList;
        public PhoneBook()
        {
            PhoneList = new List<Phone>();
        }
        public override void insertPhone(string name, string phone)
        {
           bool found = false;
            foreach(var p in PhoneList)
            {
                if (p.Name == name)
                {
                    found = true;
                    if(!p.PhoneNumbers.Contains(phone))
                    {
                        p.PhoneNumbers.Add(phone);
                    }
                    break;
                }
            }
            if (!found)
            {
                PhoneList.Add(new Phone { Name= name,PhoneNumbers = new List<string> { phone} });
            }
        }

        public override void RemovePhone(string name)
        {
            PhoneList.RemoveAll(p => p.Name == name);
        }

        public override void SearchPhone(string name)
        {
            foreach(var p in PhoneList)
            {
                if (p.Name == name)
                {
                    Console.WriteLine(name + p.PhoneNumbers);
                }
            }
        }

        public override void Sort()
        {
            PhoneList.Sort((entry1, entry2) => string.Compare(entry1.Name, entry2.Name, StringComparison.Ordinal));
        }

        public override void UpdatePhone(string name, string newphone)
        {
            foreach(var p in PhoneList)
            {
                if (p.Name == name)
                {
                    p.PhoneNumbers.Clear();
                    p.PhoneNumbers.Add(newphone);
                    break;
                }
            }
        }
    }
}
