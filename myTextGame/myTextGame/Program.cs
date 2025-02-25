using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myTextGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold = 1000, goal, dice, bet, select, point = 0;
            bool isAlive = true;
            goal = gold * 20;
            Random rand = new Random();
            //콘솔 창 크기 설정 
            Console.SetWindowSize(80, 25); //x 80 , y 25

            //콘솔 버퍼 크기도 설정 (스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false; //커서 숨기기


            Console.Clear(); //화면 지우기
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃                            주사위 맞추기 게임                                ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


            Thread.Sleep(7000);

            Console.Clear();
            Console.WriteLine("주사위를 던져 총 눈의 합을 맞추는 게임입니다");
            Console.WriteLine($"처음 자금은 {gold}gold 이며 {goal}을 모으는게 목표입니다.");
            Thread.Sleep(2000);
            Console.WriteLine("주사위 개수와 배팅 금액을 정할 수 있으며, 주사위 개수가 높을 수록 얻는 골드가 늘어납니다");
            Thread.Sleep(2000);
            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($"현재 gold는 {gold}입니다. ");
                Console.Write("베팅할 금액을 정해주세요 : ");
                bet = int.Parse(Console.ReadLine());
                if (bet > gold)
                {
                    Console.WriteLine("골드가 부족합니다 다시 정해주세요.");
                    Thread.Sleep(1500);
                }
                else
                {
                    Console.Write("주사위 개수를 정해주세요 (1개는 2배, 2개는 4배, 3개는 9배, 4개는 16배, 5개는 25배) : ");
                    dice = int.Parse(Console.ReadLine());
                    if (dice >= 1 && dice <= 5)
                    {
                        Console.Write($"눈의 합을 정해주세요(최소 {dice}, 최대 {dice * 6}) : ");
                        select = int.Parse(Console.ReadLine());
                        if (select >= dice && select <= dice * 6)
                        {
                            gold -= bet;
                            for (int i = 0; i < dice; i++)
                            {
                                int dicePoint = rand.Next(1, 7);
                                point += dicePoint;
                                Console.WriteLine("주사위 굴리는 중....");
                                Thread.Sleep(1000);
                                Console.WriteLine($"주사위 눈이 {dicePoint}이 나왔습니다!");
                                Thread.Sleep(500);
                                Console.WriteLine($"현재 눈의 합은 {point}입니다.");
                            }
                            Console.WriteLine($"총 눈의 합이 {point}입니다.");
                            Thread.Sleep(500);
                            if (select == point)
                            {
                                int getGold = 0;
                                if (dice == 1) getGold = bet * 2;
                                else getGold = bet * dice * dice;
                                gold += getGold;
                                Console.WriteLine("축하합니다. 맞추셨습니다!");
                                Thread.Sleep(500);
                                Console.WriteLine($"획득한 상금은 {getGold}입니다.");
                                Thread.Sleep(500);
                            }
                            else
                            {
                                Console.WriteLine("아쉽게도 맞추지 못했습니다...");
                                Thread.Sleep(500);
                            }
                        }
                        else
                        {
                            Console.WriteLine("눈의 합을 잘못 정했습니다, 처음부터 다시 정해주세요");
                            Thread.Sleep(1500);
                        }
                    }
                    else
                    {
                        Console.WriteLine("주사위 개수를 잘못 정했습니다, 처음부터 다시 정해주세요");
                        Thread.Sleep(1500);
                    }
                }
                if (gold >= goal)
                {
                    Console.WriteLine("축하합니다! 목표 금액에 달성했습니다!");
                    isAlive = false;
                }
                if (gold <= 0)
                {
                    Console.WriteLine("돈을 전부 탕진했습니다. 다음 기회에 다시..");
                    isAlive = false;
                }
            }
        }
    }
}
