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
<<<<<<< HEAD
      
=======
        public string this[int index]//indexer
        {
            get { }
        }
>>>>>>> 6d1b7830fb9b592ed4dd706d4c701a0b18c28a4e
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
