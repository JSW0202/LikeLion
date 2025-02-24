using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 5, b = 3;

            int sum = 0;


            sum = a + b; //산술 연산자 사용
            Console.WriteLine($"합 : {sum}");  //출력 : 8

            sum = a - b; //산술 연산자 사용
            Console.WriteLine($"합 : {sum}");
            sum = a * b; //산술 연산자 사용
            Console.WriteLine($"합 : {sum}");

            sum = a / b; //산술 연산자 사용
            Console.WriteLine($"합 : {sum}");

            int c = 0, d = 0;

            c = 10;
            d = 3;
            sum = c % d;  //나머지구하는 연산자
            Console.WriteLine($"합 : {sum}");



            int number = 7;


            int sum = 0;


            sum = number % 2;  // 0나오면 짝수   1 홀수

            Console.WriteLine("짝수 홀수 판별 : " + sum);*/

            bool isEqual = false;

            int a = 5, b = 5;

            isEqual = (a == b);

            Console.WriteLine($"같은가? {isEqual}");
        }
    }
}
