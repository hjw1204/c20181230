﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraytest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = { 1, 2, 3, 4, 5};
            int sum = 0;
            for (int i = 0; i < 5; i++) sum += iArr[i];
            Console.WriteLine("배열의 합은{0}", sum);

            sum = 0;
            foreach (int a in iArr) sum += a;
            Console.WriteLine("배열의 합은{0}", sum);
        }
    }
}
