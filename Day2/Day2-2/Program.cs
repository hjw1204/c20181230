﻿using System;
namespace Test
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Minus(1, 2)); //i=1, j=2
            Console.WriteLine(Minus(1)); //i=1, j=0
            Console.WriteLine(Minus(i: 8, j: 9)); //i=8, j=9
            Console.WriteLine(Minus(j: 8, i: 9)); //i=9, j=8
            Console.WriteLine(Minus()); //i=0, j=0
        }
        static int Minus(int i = 0, int j = 0) // i, j 매개변수없이호출되면 0이 대입됨
        {
            return i - j;
        }
    }
}