using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest25._03._06
{
    internal class Field
    {
        Player m_pPlayer = null;
        Monster m_pMonster = null;

        public void SetPlayer(ref Player player) { m_pPlayer = player; }

        public void Progress()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();

                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                    break;

                if (iInput <= 3)
                {                    
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }

        public Monster Create(string _strName, int _iHp, int _iAttack, int _iArmor)
        {
            Monster pMonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;
            tMonster.iArmor = _iArmor;

            pMonster.SetMonster(tMonster);

            return pMonster;
        }
        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    m_pMonster = Create("초보몹", 30, 3, 1);
                    break;
                case 2:
                    m_pMonster = Create("중수몹", 60, 6, 2);
                    break;
                case 3:
                    m_pMonster = Create("고수몹", 90, 9, 3);
                    break;
            }
        }

        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();


                Console.Write("1.공격 2.도망 : "); //1,2 선택 표시
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {

                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);

                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if (m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }

                }


                if (iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break; //탈출
                }
            }
        }
        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택하세요 : ");
        }

        public Field() { }
        ~Field() { }

    }
}
