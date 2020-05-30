using System;

namespace ProblemStar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("별 출력 숫자를 입력해주세요 : ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
                {
                for (int j = 0; j < n-i; j++)
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
첫째 줄에는 별 N개, 둘째 줄에는 별 N-1개, ..., N번째 줄에는 별 1개를 찍는 문제

입력
첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.

출력
첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다.

index 0 -> ***** Enter  i = 0 j =5  j = 5 -i
index 1 -> **** Enter   i = 1 j =4  j = 4 -i 
index 2 -> *** Enter    i = 2 j =3  j = 3- i
index 3 -> ** Enter     i = 3 j= 2  j = 2- i
index 4 -> * Enter      i = 4 j= 1  j = 1- i
*/
