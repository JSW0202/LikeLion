using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest25._02._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("1번 문제 ");
            // 문제: 크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.

            int[] Q1Int = new int[5] {10,20,30,40,50};
            for (int i = 0; i < Q1Int.Length; i++) { 
                Console.Write(Q1Int[i]+" ");
            }
            Console.WriteLine();*/

            //Console.WriteLine("2번 문제 ");
            // 문제: 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.

            /*Console.Write("숫자 입력: ");
            string[] Q2String = Console.ReadLine().Split(' ');
            int Q2Sum = 0;
            for(int i = 0;i < Q2String.Length; i++)
            {
                Q2Sum += int.Parse(Q2String[i]);
            }
            Console.WriteLine("총 합: "+Q2Sum);*/

            //Console.WriteLine("3번 문제 ");
            //// 문제: 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.

            //int[] Q3Int = new int[] { 3, 8, 15, 6, 2 };
            //Console.WriteLine("최대값: " + Q3Int.Max());

            //Console.WriteLine("4번 문제 ");
            //// 문제: for문을 사용하여 1부터 10까지 출력하세요.

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("5번 문제 ");
            //// 문제: while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.

            //int Q5Int = 1;
            //while (Q5Int <= 10)
            //{
            //    if (Q5Int % 2 == 0) Console.Write(Q5Int + " ");
            //    Q5Int++;
            //}
            //Console.WriteLine();

            //Console.WriteLine("6번 문제 ");
            //// 문제: foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의 요소를 출력하세요.

            //int[] Q6Int = new int[] { 1, 2, 3, 4, 5 };
            //foreach (int i in Q6Int) Console.Write(i + " ");
            //Console.WriteLine();

            //Console.WriteLine("7번 문제 ");
            //// 문제: 두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.

            //Console.Write("숫자 입력: ");
            //string[] Q7String = Console.ReadLine().Split(' ');
            //Console.WriteLine($"{Q7String[0]}과 {Q7String[1]}의 합: {int.Parse(Q7String[0]) + int.Parse(Q7String[1])}");

            //Console.WriteLine("8번 문제 ");
            //// 문제: 문자열을 입력받아 길이를 반환하는 함수를 작성하세요.

            //Console.Write("문자열 입력: ");
            //string Q8String = Console.ReadLine();
            //Console.WriteLine("문자열 길이: " + Q8String.Length);

            Console.WriteLine("9번 문제 ");
            // 문제: 세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.

            Console.Write("숫자 입력: ");
            string[] Q9String = Console.ReadLine().Split(' ');
            int[] Q9Int = new int[Q9String.Length];
            for (int i = 0; i < Q9String.Length; i++)
            {
                Q9Int[i] = int.Parse(Q9String[i]);
            }
            Console.WriteLine("가장 큰 수: " + Q9Int.Max());

        }
    }
}
