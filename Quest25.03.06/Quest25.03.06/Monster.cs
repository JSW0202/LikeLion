using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest25._03._06
{
    internal class Monster
    {
        public INFO m_tMonster;
        public void SetDamage(int iAttact) { if (m_tMonster.iArmor < iAttact) m_tMonster.iHp -= (iAttact - m_tMonster.iArmor); }
        public void SetMonster(INFO tMonster) { m_tMonster = tMonster; }
        public INFO GetMonster() { return m_tMonster; }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("몬스터 이름 : " + m_tMonster.strName);
            Console.WriteLine("체력 : " + m_tMonster.iHp + "\t공격력 :  " + m_tMonster.iAttack + "\t방어력 :  " + m_tMonster.iAttack);
        }

        public Monster() { }

        ~Monster() { }
    }
}
