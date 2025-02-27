using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study13
{
    internal class Program
    {
        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            return total;

        }
        //재귀함수(자기자신을 호출)
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;   //출력겸 탈출

            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            //Factorial(5) = 5 * 4 * 3 * 2 * 1 = 120
            Console.WriteLine(Factorial(5));


        }
    }
}
