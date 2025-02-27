using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ShootingGame1.Program;

namespace ShootingGame1
{
    class Program
    {
        static bool isRunning = true;
        public struct players
        {
            public int x;
            public int y;
            public string[] character;
        }
        static void playerMove(ref players players, ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow: if (players.y > 0) players.y--; break;
                case ConsoleKey.DownArrow: if (players.y < Console.WindowHeight - 1) players.y++; break;
                case ConsoleKey.LeftArrow: if (players.x > 0) players.x--; break;
                case ConsoleKey.RightArrow: if (players.x < Console.WindowWidth - 1) players.x++; break;
                case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                case ConsoleKey.Escape: isRunning = false; break; //ESC키로 종료 
            }
        }

        static void playerRender(ref players players)
        {
            for (int i = 0; i < players.character.Length; i++)
            {
                //콘솔좌표 설정 플레이어X 플레이어Y
                Console.SetCursorPosition(players.x, players.y + i);
                //문자열배열 출력
                Console.WriteLine(players.character[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            //int x = 10, y = 10;

            //ConsoleKeyInfo keyInfo;

            //Console.CursorVisible = false;

            //while(true)
            //{
            //    Console.Clear(); //화면 지우기

            //    Console.SetCursorPosition(x, y);

            //    Console.Write("●"); //현재 위치 출력

            //    keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)

            //    //방향키 입력에 따른 좌표 변경
            //    switch(keyInfo.Key)
            //    {
            //        case ConsoleKey.UpArrow: if (y > 0) y--;break;
            //        case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
            //        case ConsoleKey.LeftArrow: if (x > 0) x--; break;
            //        case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
            //        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
            //        case ConsoleKey.Escape: return; //ESC키로 종료 

            //    }


            //}


            //플레이어 struct로 변경
            /*string[] player = new string[]
            {
                "->",
                ">>>",
                "->",
            }; //배열 문자열로 그리기

            int playerX = 0;
            int playerY = 12;*/

            players player;
            player.x = 0;
            player.y = 0;
            player.character = new string[]
            {
                "->",
                ">>>",
                "->",
            };

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;


            //시간 1초루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1 /1000    1000일때 1초


            while (isRunning)
            {

                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기

                // Console.WriteLine("1초루프");


                if (currentSecond - prevSecond >= 100)
                {

                    Console.Clear();

                    if (Console.KeyAvailable) //키가 눌렸을때 true
                    {
                        keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)
                                                         //방향키 입력에 따른 좌표 변경
                        playerMove(ref player, keyInfo);

                    }

                    playerRender(ref player);

                    prevSecond = currentSecond;//이전 시간 업데이트
                }


            }
        }
    }
}
