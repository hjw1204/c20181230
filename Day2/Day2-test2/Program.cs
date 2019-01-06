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
        public string Name  // 일반속성
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Sabun   // 자동구현 속성
        {
            get;
            set;
        }
        public override string ToString()
        {
            return "[사원]" + Name;
        }

    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp(); e.Name = "홍"; e.Sabun = 1004;
            string s = e.Name;
            Console.WriteLine(e.Name);
            Console.WriteLine(e);
        }
    }
}