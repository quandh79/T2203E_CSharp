using T2203E_CSharp.session1;
using T2203E_CSharp.session2;

using T2203E_CSharp.Contact;
using T2203E_CSharp.session4;
using T2203E_CSharp.bt;

public class Program
{
    static void Main(string[] args)
    {
        KhachHangVN vn = new KhachHangVN(111, "Do Hong Quan", "28/12/2022", 500, "Sinh hoat");
        Console.WriteLine(vn.Thanhtien());
        
    }
    //static void Main5(string[] args)
    //{
    //    StringToVoid stv = new StringToVoid(ShowMessage);
    //    StringToVoid stv1 = new StringToVoid(Demodelegate.SayHello);
    //    StringToVoid stv2 = new StringToVoid(new Demodelegate().ShowInfo);
    //    stv += Demodelegate.SayHello;
    //    stv += new Demodelegate().ShowInfo;
    //    stv("xin chao");

    //    DemoEvent de = new DemoEvent();
    //    de.Invoke();
    //}
    //static void ShowMessage(string message)
    //{
    //    Console.WriteLine(message);
    //}
    //static void Main4(string[] args)
    //{
    //    PhoneBook pb = new PhoneBook();
    //    pb.insertPhone("quan", "0999999999");
    //    pb.insertPhone("minh", "0999988899");
    //    pb.insertPhone("nam", "0777799999");
    //    pb.insertPhone("nam", "093435435999");
    //    pb.Sort();
    //    foreach(PhoneNumber p in pb.PhoneList)
    //    {
    //        Console.WriteLine(p.ToString());
    //    }

    //}
    //static void Main2()
    //{

    //    /*   Human h = new Human();
    //       h.run();
    //       h.Age = 19;
    //       h.Email = "abc@gmail.com";// properties
    //       Console.WriteLine(h.Email);
    //       Console.WriteLine(h.Age);

    //       Student s = new Student();
    //       List<string> list = new List<string>();
    //       list.Add("hello");
    //       list.Add("world");
    //       list.Add("morning");
    //       for(int i = 0; i< list.Count; i++)
    //       {
    //           Console.WriteLine(list[i]);
    //       }
    //    */

    //    Phanso p1 = new Phanso();
    //    p1.tuso = 1;
    //    p1.mauso = 3;
    //    Phanso p2 = new Phanso();
    //    p2.tuso = 3;
    //    p2.mauso = 5;

    //    Phanso f3 = Phanso.Add(p1, p2);
    //    f3.Print();

    //    Human h = new Human();
    //    h.run();
    //    h.Age = 19;
    //    h.Email = "abc@gmail.com";// properties
    //    Console.WriteLine(h.Email);
    //    Console.WriteLine(h.Age);

    //    Student s = new Student();
    //    List<string> list = new List<string>();
    //    list.Add("hello");
    //    list.Add("world");
    //    list.Add("morning");
    //    for(int i = 0; i< list.Count; i++)
    //    {
    //        Console.WriteLine(list[i]);
    //    }

    //}
}