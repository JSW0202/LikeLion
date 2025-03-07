using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgQuest25._03._07
{
    internal class Player
    {
        public INFO info;
        public void SetDamage(int Attack) { info.Hp -= Attack; }
        public INFO GetInfo() { return info; }
        public void SetHp(int Hp) { info.Hp = Hp; }


        public void SelectJob()
        {
            info = new INFO();
            int input = 0;
            Console.Write("직업을 선택하세요(1.기사 2.마법사 3.도둑) : ");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    info.Name = "기사";
                    info.Hp = 100;
                    info.Attack = 10;
                    break;
                case 2:
                    info.Name = "마법사";
                    info.Hp = 80;
                    info.Attack = 15;
                    break;
                case 3:
                    info.Name = "도둑";
                    info.Hp = 90;
                    info.Attack = 13;
                    break;
                default:
                    break;
            }
        }

        public void PlayerInfo()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("직업 이름 : " + info.Name);
            Console.WriteLine("체력 : " + info.Hp + "\t공격력 : " + info.Attack);
        }


        public Player() { }
        ~Player() { }
    }
}
