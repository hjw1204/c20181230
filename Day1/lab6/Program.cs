﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                i += 1;
                if (i % 2 != 1)
                    Console.WriteLine("{0}", i);
            }
            while (i < 10);
         }
    }
}
