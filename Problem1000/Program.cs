﻿/*문제 
두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)

첫째 줄에 A+B를 출력한다.

*/
using System;

public class Problem1000
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] ss = s.Split();
        int a = int.Parse(ss[0]);
        int b = int.Parse(ss[1]);
        Console.WriteLine(a + b);
    }
}