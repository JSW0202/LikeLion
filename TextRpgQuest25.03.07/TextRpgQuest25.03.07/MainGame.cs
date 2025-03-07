using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgQuest25._03._07
{
    internal class MainGame
    {
        public int input = 0;
        public Player player = null;
        public Field field = null;

        public void Render()
        {
            player = new Player();
            player.SelectJob();

            while (true)
            {
                Console.Clear();
                player.PlayerInfo();
                Console.Write("1.사냥터 2.종료 : ");
                input = int.Parse(Console.ReadLine());

                if (input == 2)
                    break;


                if (input == 1)
                {
                    //사냥터 구현
                    if (field == null)
                    {
                        field = new Field();
                        field.SetPlayer(ref player);
                    }
                    field.field();

                }
            }

        }
        public MainGame() { }
        ~MainGame() { }
    }
}
