using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2203E_CSharp.session1;

namespace T2203E_CSharp.session2
{
    internal class Student: Human

    {
        public string[] telephone = new string[3];
      
        public Student(string name, int age)
        {
            this.name = name;
        }

        public Student()
        {
        }

        public void Study()
        {
            base.run();
            this.run();
        }
        public new void Run()
        {

        }

        public override void Eat()
        {
            base.Eat();
        }
    }
}
