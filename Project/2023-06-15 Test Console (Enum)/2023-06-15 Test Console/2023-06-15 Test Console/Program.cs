using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_15_Test_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 내가 정의한 enum 타입 변수를 선언해 볼 것임.
            ItemType_SC itemType;

            itemType = ItemType_SC.POTION;

            Console.WriteLine("enum type은 무엇이라고 출력이 될까? -> {0}", (int)itemType);

            switch(itemType)
            {
                case ItemType_SC.POTION:
                    Console.WriteLine("이 아이템의 타입은 포션입니다.");
                    break;
                case ItemType_SC.GOLD:
                    Console.WriteLine("이 아이템의 타입은 골드입니다.");
                    break;
                case ItemType_SC.WEAPON:
                    Console.WriteLine("이 아이템의 타입은 무기입니다.");
                    break;
                case ItemType_SC.ARMOR:
                    Console.WriteLine("이 아이템의 타입은 방어구입니다.");
                    break;
                default:
                    Console.WriteLine("이 아이템의 타입은 정의되지 않습니다.");
                    break;
            }
        }

        public void Desc001()
        {

        }
    }
}
