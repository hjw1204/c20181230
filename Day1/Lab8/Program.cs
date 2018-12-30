using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 10 numbers :");
            int i = 0;
            int j = 0;
            int sum = 0;
            while (i < 10)
            {
                 i++;
             
                Console.Write("숫자-{0} : ",i);
                int m = 0;
                string str = Console.ReadLine();
                bool parsed = Int32.TryParse(str, out m);
            }
            while (j <10)
            {
                sum += j;
                j++;
            }
            Console.WriteLine("합 :{0}", sum);
        }
                   
           
            
    }
}
