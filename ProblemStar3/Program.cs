using System;
using System.Globalization;

namespace ProblemStar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("별 출력 숫자를 입력해주세요 : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
/* 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제

하지만, 오른쪽을 기준으로 정렬한 별(예제 참고)을 출력하시오.
*/
