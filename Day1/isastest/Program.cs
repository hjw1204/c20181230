using System;

namespace isastest
{
    class Emp { }
    class Programmer : Emp { }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            if (p is Emp) Console.WriteLine(":p is Emp");
            else Console.WriteLine("p is not Eml");

            Emp e = p as Emp;
            if (e != null)
                Console.WriteLine("p가 Emp로 형변환 OK");
        }
    }
}
