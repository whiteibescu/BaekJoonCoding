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



            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            
        }
    }
}
