using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        //최대 아이템 개수(배열 크기)
        const int MAX_ITEMS = 10;

        public struct Item
        {
            public string name;
            public int count;
        }
        static Item[] items = new Item[MAX_ITEMS];

        //아이템 추가 함수
        static void AddItem(Item[] items,string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (items[i].name == name)  //이미 있는 아이템이면 개수 증가
                {
                    items[i].count += count;
                    return;
                }
            }

            //빈 슬롯에 새로운 아이템 추가
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (items[i].name == null)
                {
                    items[i].name = name;
                    items[i].count = count;
                    return;
                }
            }
            Console.WriteLine("인벤토리가 가득 찼습니다.");

        }

        //아이템 제거 함수
        static void RemoveItem(Item[] items, string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (items[i].name == name) //이름하고 같은지
                {
                    if (items[i].count >= count) //개수가 충분하면 차감
                    {
                        items[i].count -= count;
                        if (items[i].count == 0) //개수가 0이면 삭제
                        {
                            items[i].name = null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("아이템 개수가 부족합니다!");
                        return;
                    }
                }
            }

            Console.WriteLine("아이템을 찾을 수 없습니다!");

        }


        //인벤토리 출력 함수
        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool isEmpty = true;

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (items[i].name != null)
                {
                    Console.WriteLine($"{items[i].name} (x{items[i].count})");
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }

        static void Main(string[] args)
        {
            //테스트 : 아이템 추가
            AddItem(items, "포션", 5);
            AddItem(items, "칼", 1);
            AddItem(items, "포션", 3); //포션 개수 추가

            ShowInventory();

            //아이템 사용
            Console.WriteLine("포션 2개 사용");
            RemoveItem(items, "포션", 2);
            ShowInventory();

            //테스트 : 없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            RemoveItem(items, "방패", 1);

            ShowInventory();


            //테스트: 모든 포션 제거
            Console.WriteLine("포션 7개 사용(초과 사용 테스트)");
            RemoveItem(items, "포션", 7);
            ShowInventory();


        }
    }
}