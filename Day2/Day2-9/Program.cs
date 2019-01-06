using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_9
{
    class Baseclass
    {
        public void func1() { Console.WriteLine("baseclass func1.."); }
        public void func2() { Console.WriteLine("baseclass func2.."); }
        public void func3() { Console.WriteLine("baseclass func3.."); }
    }
    class A : Baseclass
    {
        public override void func2() { Console.WriteLine("Afunc2..."); }
    }
    class Derivedclass :A
    {
        public void func1() { Console.WriteLine("derivedclass func1."); }
        public void func3() { Console.WriteLine("derivedclass func3."); }
    }
    class Programe
    {
        static void Main(string[] args)
        {
            Baseclass b = new Derivedclass[];
                b.func1();
            b.func2();
            b.func3();
        }
    }
 }
  