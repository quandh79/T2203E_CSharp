using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.session1
{
    internal class Human
    {
        private int id;
        public String name;
        public int age;
        public static int xyz; // biến của class truy cập trực tiếp k tạo đối tượng
        public Human()
        {

        }
        public int Id
        {
            get
            {
                return this.id;  
            }
            set { this.id = value; }
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }// giống getter setter

        public string Email { get; set; }//chua có ô nhớ, gán gt có ô nhớ
        public void run()
        {
            Console.WriteLine("Running...");
            this.name = "AAAA";
        }public void run(string s)
        {

        }
        public static void ScreenShot()
        {

        }
        public virtual void Eat()
        {

        }
    }
}
