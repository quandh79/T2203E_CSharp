using T2203E_CSharp.session1;
using T2203E_CSharp.session2;

public class Program
{
    static void Main()
    {
        Human h = new Human();
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
    }
}