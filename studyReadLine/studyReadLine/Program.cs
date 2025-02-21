using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("이름을 입력하세요: ");
            string username = Console.ReadLine();
            Console.WriteLine($"안녕하세요, {username}님!");*/

            /*Console.Write("나이를 입력하세요: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");
            Console.WriteLine("내년에는 " + age + "살이 되겠군요");
            Console.WriteLine("내년에는 {0}살이 되겠군요", age);*/

            Console.Write("스킬 피해량을 입력하세요 : ");
            string ruin = Console.ReadLine();
            float damage = float.Parse(ruin), card = 3.2f, ult = 6.5f, speed = 100.0f, ride = 100.0f, take = 100.0f, time = 3.3f;
            int mp = 2827, fmp = 101, nfmp = 101;
            Console.WriteLine("활동");
            Console.WriteLine($"루인 스킬 피해 : {damage}%");
            Console.WriteLine($"카드 게이지 획득량 : {card}%");
            Console.WriteLine($"각성기 피해: {ult}%");
            Console.WriteLine($"최대 마나 : {mp}");
            Console.WriteLine($"전투 중 마나 회복량 : {fmp}");
            Console.WriteLine($"비전투 중 마나 회복량 : {nfmp}");
            Console.WriteLine($"이동 속도 : {speed}%");
            Console.WriteLine($"탈 것 속도 : {ride}%");
            Console.WriteLine($"운반 속도 {take}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 {time}%");
        }
    }
}
