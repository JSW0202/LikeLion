using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int x = 5, y = 10;

            Console.WriteLine(x == y);  // false
            Console.WriteLine(x != y);  // true
            Console.WriteLine(x < y);   // true
            Console.WriteLine(x > y);   // false
            Console.WriteLine(x >= y);  // false
            Console.WriteLine(x <= y);  //true  */

            /*bool a = true;
            bool b = false;

            Console.WriteLine(a && b);
            Console.WriteLine(a || b);*/

            /*int x = 5;
            int y = 3;

            Console.WriteLine(x & y);
            Console.WriteLine(x | y);
            Console.WriteLine(x ^ y);
            Console.WriteLine(~x);*/

            /*int value = 4;

            Console.WriteLine(value << 1);
            Console.WriteLine(value >> 1);*/

            /*int a = 10, b = 20, max;
            max = (a > b) ? a : b;

            Console.WriteLine(max);*/

            /*int key = 1;
            string str = "";

            str = (key == 1) ? "문이열렸습니다" : "문을 못열었습니다.";
            Console.WriteLine(str);*/

            /*int result = 10 + 2 * 5;
            Console.WriteLine(result);

            int adjustedResult = (10 + 2) * 5;
            Console.WriteLine(adjustedResult);*/

            /*int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else
            {
                Console.WriteLine("B 학점");
            }

            if (false) {
                Console.WriteLine("트루");
            }
            else
            {
                Console.WriteLine("팔스");
            }*/

            /*string GameId = "멋사";

            if (GameId == "멋사")
            {
                Console.WriteLine("아이디가 일치합니다");
            }
            else {
                Console.WriteLine("아이디가 일치하지 않습니다");
            }*/

            /*int score = 60;

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }*/

            /*int money,attack =100;
            string read,sword="",name;
            Console.Write("가지고 있는 소지금을 입력하세요 :");
            read = Console.ReadLine();
            money = int.Parse(read);
            if (money >= 1 && money <= 100) {
                attack++;
                sword = "무한의대검";
            }
            else if (money >= 101 && money <= 200)
            {
                attack+=2;
                sword = "카타나";
            }
            else if (money >= 201 && money <= 300)
            {
                attack+=2;
                sword = "진은검";
            }
            else if (money >= 301 && money <= 400)
            {
                attack+=3;
                sword = "집판검";
            }
            else if (money >= 401 && money <= 500)
            {
                attack+=4;
                sword = "엑스칼리버";
            }
            else if (money >= 501 && money <= 600)
            {
                attack+=5;
                sword = "유령검";
            }
            else if (money >= 601)
            {
                attack += 6;
                sword = "전설의검";
            }

            Console.WriteLine("이름을 입력해주세요");
            name = Console.ReadLine();

            Console.WriteLine($"{name}의 공격력은 {attack}이고 소지한 무기는 {sword}입니다");*/

            // 1번 문제
            int a, b, c,result=0,point,first,second;
            string read;
            char grade;
            Console.Write("첫번째 숫자를 입력해 주세요");
            read = Console.ReadLine();
            a = int.Parse(read);
            Console.Write("두번째 숫자를 입력해 주세요");
            read = Console.ReadLine();
            b = int.Parse(read);
            Console.Write("세번째 숫자를 입력해 주세요");
            read = Console.ReadLine();
            c = int.Parse(read);
            if (a > b && a > c) result = a;
            else if (b > a && b > c) result = b;
            else if (c > a && c > b) result = c;
            Console.WriteLine("최대값: " + result);

            // 2번 문제
            Console.Write("점수를 입력해주세요 :");
            read = Console.ReadLine();
            point = int.Parse (read);
            if (point > 90) grade = 'A';
            else if (point >= 80 && point < 90) grade = 'B';
            else if (point >= 70 && point < 80) grade = 'C';
            else if (point >= 60 && point < 70) grade = 'D';
            else if (point < 60) grade = 'F';

            // 3번 문제
            Console.Write("첫번째 숫자를 입력해주세요 :");
            read = Console.ReadLine();
            first = int.Parse(read);
            Console.Write("두번째 숫자를 입력해주세요 :");
            read = Console.ReadLine();
            second = int.Parse(read);
            Console.Write("연산자 기호를 입력해주세요 :");
            read = Console.ReadLine();

            if (read == "+") Console.WriteLine($"결과는: {first+second}");
            else if (read == "-") Console.WriteLine($"결과는: {first - second}");
            else if (read == "*") Console.WriteLine($"결과는: {first * second}");
            else if (read == "/" && second != 0) Console.WriteLine($"결과는: {first / second}");
            else if (read == "/" && second == 0) Console.WriteLine("0으로 나눌수 없습니다");

        }
    }
}
