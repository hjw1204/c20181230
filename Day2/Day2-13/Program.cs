using System;
using System.Collections.Generic;
class SumTest<T> //일반화 클래스
{
    public T Sum(T i, T j)
    {
        //dynamic은 컴파일 시점에 형식 검사를 무시되며, 런타임시 확인된다.
        return (dynamic)i + (dynamic)j;
    }
}
class SumMain
{
    public static void Main()
    {
        SumTest<int> s1 = new SumTest<int>();
        Console.WriteLine("정수의 합 : {0} + {1} = {2} ", 1, 2, s1.Sum(1, 2));
        SumTest<double> s2 = new SumTest<double>();
        Console.WriteLine("실수의 합 : {0:f} + {1:f} = {2:f} ", 1.0, 2.0, s2.Sum(1.0, 2.0));
    }
}