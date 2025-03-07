using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgQuest25._03._07
{
    internal class Monster
    {
        public INFO info;
        public void SetDamage(int Attack) { info.Hp -= Attack; }
        public void SetMonster(INFO Monster) { info = Monster; }
        public INFO GetMonster() { return info; }

        public void MonsterInfo()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("몬스터 이름 : " + info.Name);
            Console.WriteLine("체력 : " + info.Hp + "\t공격력 : " + info.Attack);
        }


        public Monster() { }
        ~Monster() { }
    }
}
