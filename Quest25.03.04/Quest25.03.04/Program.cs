using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quest25._03._04
{
    internal class Program
    {
        // 문제 1번
        /*public class Player
        {
            public string Name { get; set; }
            public int Score { get; set; }
        }
        public class Warrior : Player
        {
            public int Strength { get; set; }
        }
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.Strength = 150;
            warrior.Name = "전사";
            warrior.Score = 100;
            Console.WriteLine($"이름은 {warrior.Name}이고, 힘은 {warrior.Strength} 이며, 점수는 {warrior.Score}입니다.");
        }*/




        // 문제 2번

        /*static void Main(string[] args)
        {
            int result = 0;
            Console.Write("숫자를 입력해 주세요: ");
            try
            {
                result = int.Parse(Console.ReadLine());
                Console.WriteLine($"입력한 숫자는 {result} 입니다.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("올바른 숫자를 입력하세요!");
            }

        }*/




        // 문제 3번

        /*static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("사과");
            list.Add("바나나");
            list.Add("포도");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("첫 번째 직업");
            queue.Enqueue("두 번째 직업");
            queue.Enqueue("세 번째 직업");
            while (queue.Count > 0) { 
                Console.WriteLine(queue.Dequeue());
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }*/




        // 문제 4번

        /*static void Main(string[] args)
        {
            Console.Write("문자열을 작성해 주세요: ");
            string str = Console.ReadLine();
            str.ToUpper();
            Console.WriteLine(str);
            Console.WriteLine(str.Replace("C#", "CSharp"));
            Console.WriteLine(str.Length);
        }*/



        // 문제 5번

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sum = numbers.Sum();
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            foreach (int n in evenNumbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }

    }
}
