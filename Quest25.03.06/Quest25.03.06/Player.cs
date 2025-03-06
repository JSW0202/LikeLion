using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest25._03._06
{
    internal class Player
    {
        public INFO m_tInfo;
        public void SetDamage(int iAttact) { if (m_tInfo.iArmor < iAttact) m_tInfo.iHp -= (iAttact - m_tInfo.iArmor); }
        public INFO GetInfo() { return m_tInfo; }
        public void SetHp(int Hp) { m_tInfo.iHp = Hp; }

        public void SelectJob()
        {
            m_tInfo = new INFO();

            Console.Write("직업을 선택하세요(1.기사 2.마법사 3.도둑) : ");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    m_tInfo.strName = "기사";
                    m_tInfo.iHp = 100;                   
                    m_tInfo.iAttack = 10;
                    m_tInfo.iArmor = 5;
                    break;
                case 2:
                    m_tInfo.strName = "마법사";
                    m_tInfo.iHp = 90;
                    m_tInfo.iAttack = 15;
                    m_tInfo.iArmor = 2;
                    break;
                case 3:
                    m_tInfo.strName = "도둑";
                    m_tInfo.iHp = 85;
                    m_tInfo.iAttack = 13;
                    m_tInfo.iArmor = 3;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("직업 이름 : " + m_tInfo.strName);
            Console.WriteLine("체력 : " + m_tInfo.iHp + "\t공격력 :  " + m_tInfo.iAttack + "\t방어력 :  " + m_tInfo.iArmor);
        }

        public Player() { }

        ~Player() { }
    }
}
