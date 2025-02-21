using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TodayTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            Console.Clear();
            char a = '□';
            char b = '■';
            string load = "";
            Thread.Sleep(7000);
            for (int i = 0; i <= 10; i++)
            {
                Console.Clear();
                for (int j = 0; j < 10; j++)
                {
                    if(j>=i) load += a.ToString();
                    else load += b.ToString();
                }
                Console.WriteLine(load);
                Thread.Sleep(1000);
                load = "";
            }
            Console.Clear();
            Console.WriteLine("로딩바 엔터를 치면 스토리가 시작됩니다");
            pass();
            Console.WriteLine("나는 눈을 떴다. 어쩐지 기분이 이상했다.");
            pass();
            Console.WriteLine("방 안은 낯설었고, 창밖에서는 희미한 빛만이 새어 들어왔다.");
            pass();
            Console.WriteLine("???: 드디어 깨어났네.");
            pass();
            Console.WriteLine("어디선가 들려오는 목소리. 나는 반사적으로 몸을 돌렸다.");
            pass();
            Console.WriteLine("어둠 속에서 희미하게 보이는 실루엣이 나를 바라보고 있었다.");
            pass();
            Console.WriteLine("나: 누구야...? 여긴 어디지?");
            pass();
            Console.WriteLine("???: 넌 중요한 선택을 해야 해. 하지만 시간이 없어.");
            pass();
            Console.WriteLine("그의 말이 끝나기 무섭게, 방 한가운데 두 개의 문이 나타났다.");
            pass();
            Console.WriteLine("하나는 밝은 빛이 새어 나오는 문, 다른 하나는 깊은 어둠으로 가려진 문.");
            pass();
            Console.WriteLine("???: 빛의 문을 선택하면 네가 원하던 대답을 얻을 수 있어. 하지만 다시 돌아오진 못할 거야.");
            pass();
            Console.WriteLine("???: 어둠의 문을 선택하면 모든 걸 잊고 원래대로 돌아갈 수 있어. 하지만 진실은 영원히 감춰지겠지.");
            pass();
            Console.WriteLine("나: ......");
            pass();
            Console.WriteLine("나는 문 앞에 섰다. 선택해야 한다.");
            pass();
            Console.WriteLine("어느 쪽으로 가야 할까…?");
        }
        static void pass()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}
