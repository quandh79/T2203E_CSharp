using T2203E_CSharp.session1;
using T2203E_CSharp.session2;
using T2203E_CSharp.bt;

public class Program
{
    static void Main()
    {
        /*   Human h = new Human();
           h.run();
           h.Age = 19;
           h.Email = "abc@gmail.com";// properties
           Console.WriteLine(h.Email);
           Console.WriteLine(h.Age);

           Student s = new Student();
           List<string> list = new List<string>();
           list.Add("hello");
           list.Add("world");
           list.Add("morning");
           for(int i = 0; i< list.Count; i++)
           {
               Console.WriteLine(list[i]);
           }
        */

        Phanso p1 = new Phanso();
        p1.tuso = 1;
        p1.mauso = 3;
        Phanso p2 = new Phanso();
        p2.tuso = 3;
        p2.mauso = 5;

        Phanso f3 = Phanso.Add(p1, p2);
        f3.Print();
    }
}