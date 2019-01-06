using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_test1
{
    class Emp
    {
        private string name;
        public void setName(string name) {  this.name = name; }  //원하는 형태대로 값을 받기 위하여 set, get 사용(캡슐화)
        public string GetName() { return this.name; }
    }
    class EmpTest
    { 
        static void Main(string[] args)
        {
            Emp e = new Emp(); e.setName("zick");
            Console.WriteLine(e.GetName());
            Console.WriteLine(e);
        }
    }
}
