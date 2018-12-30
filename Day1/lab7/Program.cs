using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력숫자 : ");
            string str = Console.ReadLine();
            int m = 0;
            bool parsed = Int32.TryParse(str, out m);

            int i = 0;
            int j = 0;
            int sum = 0;
            Console.Write("{0}까지의 숫자 :", m);
            while (i < m)
            {
                i += 1;
                Console.Write("{0}", i);
            }
            Console.WriteLine();
            while (j <= m)
             
            {
                sum += j;
                j++;

            }
            Console.WriteLine("{0}까지의 숫자합은 : {1}", m, sum);
        }
    }
}
