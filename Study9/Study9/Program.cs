using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Study9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int day = 3;

            switch (day) { 
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                case 6:
                    Console.WriteLine("토요일");
                    break;
                case 7:
                    Console.WriteLine("일요일");
                    break;
            }*/

            /*Console.WriteLine("캐릭터를 선택하세요 (1.검사 2.마법사 3.도적)");
            int att = 0, def = 0;
            int cha = int.Parse(Console.ReadLine());
            string cla = "";
            switch (cha) { 
                case 1:
                    cla = "검사";
                    att = 100;
                    def = 90;
                    break;
                case 2:
                    cla = "마법사";
                    att = 110;
                    def = 80;
                    break;
                case 3:
                    cla = "도적";
                    att = 115;
                    def = 75;
                    break;
            }
            Console.WriteLine($"직업은 {cla}이고 공격력은 {att} 방어력은 {def}입니다");*/

            /*for (int i = 1; i <= 5; i++) {
                Console.WriteLine($"숫자 : {i}");
            }
            //무한반복
            for (; ; )
            {
                Console.WriteLine("중요한건 꺽이지 않는 마음");
            }*/

            /*for (int i = 0; i < 10; i++) { 
                Console.WriteLine("숫자 : "+i);
            }

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("숫자의 합: " + sum);*/

            /*int count = 0;
            while (count <= 5)
            {
                Console.WriteLine("Count = " + count);
                count++;
            }*/

            /*Random rand = new Random();
            int randomInRange = 0;
            for (int i = 0; i < 100; i++) { 
                randomInRange = rand.Next(5, 15);
                Console.WriteLine("5부터 14까지: " + randomInRange);
            }*/

            /*Random rnd = new Random();
            int range = 0;
            for (int i = 0; i <= 10; i++) { 
                range = rnd.Next(1,101);

                if (range >= 1 && range <= 10) {
                    Console.WriteLine("도끼등급 SSS");
                }
                else if (range >= 11 && range <= 40)
                {
                    Console.WriteLine("도끼등급 SS");
                }
                else
                {
                    Console.WriteLine("도끼등급 S");
                }
                Thread.Sleep(500);
            }*/

            /*int x = 5;

            do
            {
                Console.WriteLine("최소 한번은 실행됩니다.");
                x--;
            } while (x > 0);*/

            /*for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }


                Console.WriteLine(i);
            }*/

            /*for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(i); //홀수만 출력
            }*/

            int n = 1;

            start:
                if(n <= 5)
            {
                Console.WriteLine(n);
                n++;

                goto start;
            }


        }
    }
}
