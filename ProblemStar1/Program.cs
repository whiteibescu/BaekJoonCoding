using System;
using System.Globalization;

namespace ProblemStar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("별 출력 횟수를 입력해주세요.");
            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <= i ; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            
        }
    }
}
/*
문제
첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제

입력
첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.

출력
첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다.
*/