using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Block
    {
        public BLOCKDATA m_tBlock = new BLOCKDATA();
        Random random = new Random();
        Ball m_pBall;
        public void SetBall(Ball ball) { m_pBall = ball; }

        public void Initialize()
        {
            for (int i = 0; i < 10; i++)
            {
                int x, y;
                x = random.Next(5, 80);
                y = random.Next(2, 25);
                m_tBlock.nXnY[i] = (x * 100) + y;
            }
        }


        public void Render()
        {
            for (int i = 0; i < 10; i++)
            {
                if (m_tBlock.nXnY[i] != 0)
                {
                    Program.gotoxy(m_tBlock.nXnY[i] / 100, (m_tBlock.nXnY[i] % 100));
                    Console.Write("▣");
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (m_tBlock.nXnY[i] == (m_pBall.m_tBall.nX * 100) + m_pBall.m_tBall.nY)
                {
                    Program.gotoxy(m_tBlock.nXnY[i] / 100, (m_tBlock.nXnY[i] % 100));
                    m_tBlock.nXnY[i] = 0;
                    Console.Write(" ");
                }
            }
        }
        public void Release()
        {
        }

    }
}
