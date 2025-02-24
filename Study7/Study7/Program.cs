using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int number = 5;
            bool flag = true;

            Console.WriteLine(+number);
            Console.WriteLine(-number);

            Console.WriteLine(!flag);*/

            /*int num = 10;
            int result = ~num;

            Console.WriteLine($"원래 값 : {num}");
            Console.WriteLine($"~ 연산자 적용 후 : {result}");*/

            /*double pi = 3.14;
            int integerPi = (int)pi;

            Console.WriteLine(integerPi);*/

            /*int iKor = 90, iEng = 75, iMath = 58;
            int sum = 0;
            float average = 0;

            sum = iKor + iEng + iMath;

            average = (float)sum / 3;  //평균

            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + average);*/

            /*int a = 10, b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            string firstName = "Alice";
            string lastName = "Smith";

            Console.WriteLine(firstName + " " + lastName); //출력*/

            /*int a = 10;
            a += 5;  // a  = a + 5;

            Console.WriteLine(a);*/

            /*int a = 10;
            a += 5;  // a  = a + 5;
            Console.WriteLine(a);
            a -= 5;  // a  = a - 5;
            Console.WriteLine(a);
            a *= 5;  // a  = a * 5;
            Console.WriteLine(a);
            a /= 5;  // a  = a / 5;
            Console.WriteLine(a);
            a %= 5;  // a  = a % 5;
            Console.WriteLine(a);*/

            /*int math, eng, kor, sum, num, result;
            double avg;
            string read;
            Console.WriteLine("수학점수를 입력해주세요");
            read = Console.ReadLine();
            math = int.Parse(read);
            Console.WriteLine("영어점수를 입력해주세요");
            read = Console.ReadLine();
            eng = int.Parse(read);
            Console.WriteLine("국어점수를 입력해주세요");
            read = Console.ReadLine();
            kor = int.Parse(read);
            sum = math + eng + kor;
            avg = sum / 3.0f;
            avg = Math.Round(avg, 2);
            Console.WriteLine($"총점은 {sum}이고 평균은 {avg} 입니다.");

            Console.WriteLine("정수를 입력해주세요");
            read = Console.ReadLine();
            num = int.Parse(read);
            result = ~num;

            Console.WriteLine($"원래 값 : {num}");
            Console.WriteLine($"~ 연산자 적용 후 : {result}");*/

            int b = 3;

            ++b;
            Console.WriteLine(b);
            Console.WriteLine(b++);
            Console.WriteLine(b);
        }
    }
}
