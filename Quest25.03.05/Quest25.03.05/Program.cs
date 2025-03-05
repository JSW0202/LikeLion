using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest25._03._05
{
    //부모클래스 (기본유닛)
    class Unit
    {
        public string Name;
        public string Q_Name;
        public string W_Name;
        public string E_Name;
        public string R_Name;
        protected int Health;
        protected float Armor;
        protected int Mana;
        protected float Damage;


        public Unit()
        {
            Name = "Unknown";
            Q_Name = "Unknown";
            W_Name = "Unknown";
            E_Name = "Unknown";
            R_Name = "Unknown";
            Health = 0;
            Armor = 0;
            Mana = 0;
            Damage = 0;
        }

        public virtual void Q()
        {
            Console.WriteLine($"{Name}이 {Q_Name}을 사용하였습니다. ");
            Damaged(Damage);
        }
        public virtual void W()
        {
            Console.WriteLine($"{Name}이 {W_Name}을 사용하였습니다. ");
            Damaged(Damage);
        }
        public virtual void E()
        {
            Console.WriteLine($"{Name}이 {E_Name}을 사용하였습니다. ");
            Damaged(Damage);
        }
        public virtual void R()
        {
            Console.WriteLine($"{Name}이 {R_Name}을 사용하였습니다. ");
            Damaged(Damage);
        }
        public virtual float Damaged(float Damage)
        {
            Console.WriteLine($"상대방이 {Damage}의 피해를 입었습니다");
            return 0;
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다. ");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다. ");
        }
    }

    class Garen : Unit
    {
        public Garen()
        {
            Name = "Garen";
            Health = 690;
            Mana = 0;
            Damage = 145.5f;
            Armor = 38;
            Q_Name = "Decisive Strike";
            W_Name = "Courage";
            E_Name = "Judgement";
            R_Name = "Demacian Justice";
        }        

        public override void W()
        {
            Armor *= 1.1f;
            Console.WriteLine($"가렌의 방어력이 10% 증가합니다. 현재 가렌의 방어력 : {Armor}");
        }

    }

 
    class Corki : Unit
    {
        public Corki()
        {
            Name = "Corki";
            Health = 610;
            Mana = 350;
            Damage = 52;
            Armor = 30;
            Q_Name = "Phosphorus Bomb";
            W_Name = "Valkyrie";
            E_Name = "Gatling Gun";
            R_Name = "Missile Barrage";
        }

        public override void W()
        {           
            Console.WriteLine($"코르키가 {W_Name}을 사용했습니다.");
            Move();
        }
    }

    class Program
    {
 
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();

            units.Add(new Garen());
            units.Add(new Corki());


            //모든 유닛을 순회하며 다형성 적용
            foreach (var unit in units)
            {
                unit.Move(); //이동
                unit.Attack(); //공격
                unit.Q();
                unit.W();
                unit.E();
                unit.R();
                Console.WriteLine();
            }


            

        }
    }
}
