using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgQuest25._03._07
{
    internal class Field
    {
        public int input = 0;
        Player player = null;
        Monster monster = null;

        public void SetPlayer(ref Player player) { this.player = player; }

        public void field()
        {
            while (true)
            {
                Console.Clear();
                player.PlayerInfo();
                DrawField();
                input = int.Parse(Console.ReadLine());
                if (input == 4) break;
                if (input <= 3)
                {
                    CreateMonster(input);
                    Fight();
                }
            }
        }

        public void Create(string _Name, int _Hp, int _Attack, out Monster monster)
        {
            monster = new Monster(); 
            INFO CMonster = new INFO();

            CMonster.Name = _Name;
            CMonster.Hp = _Hp; //체력
            CMonster.Attack = _Attack;

            monster.SetMonster(CMonster);
        }
        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 3, out monster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, out monster);
                    break;
                case 3:
                    Create("고수몹", 90, 9, out monster);
                    break;
            }
        }

        public void DrawField()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("=============");
            Console.Write("맵을 선택하세요 : ");
        }
        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                player.PlayerInfo();
                monster.MonsterInfo();


                Console.Write("1.공격 2.도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    player.SetDamage(monster.GetMonster().Attack);
                    monster.SetDamage(player.GetInfo().Attack);

                    if (player.GetInfo().Hp <= 0)
                    {
                        player.SetHp(100);
                        break;
                    }



                }


                if (iInput == 2 || monster.GetMonster().Hp <= 0)
                {
                    monster = null;
                    break;
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
