using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole004
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dictionary는 정렬을 하지않는 , 그 내부에서 무작위로 search 한다.  ==> 비선형 구조
            //Dictionary<string, int> myInventory = new Dictionary<string, int>();
            //myInventory.Add("빨간 포션", 5);
            //myInventory.Add("골드", 500);
            //myInventory.Add("몰락한 왕의 검", 1);

            //foreach(KeyValuePair<string, int>item in myInventory) 
            //{
            //    Console.WriteLine("아이템 이름 : {0}, 아이템 갯수 : {1}", item.Key, item.Value);
            //}

            //Console.WriteLine("아이템 갯수 : {0}", myInventory["빨간 포션"]);

            ItemInfo redPotion = new ItemInfo();
            redPotion.InitItem("빨간 포션", 5, 100);

            ItemInfo gold = new ItemInfo();
            gold.InitItem("골드", 500, 1);

            ItemInfo sword = new ItemInfo();
            sword.InitItem("몰락한 왕의 검", 1, 39800);

            Dictionary<string, ItemInfo> myInventory2 = new Dictionary<string, ItemInfo>();
            myInventory2.Add("빨간 포션", redPotion);
            myInventory2.Add("골드", gold);
            myInventory2.Add("몰락한 왕의 검", sword);

            foreach(var item in myInventory2)
            {
                Console.WriteLine("아이템 이름 : {0}, 아이템 갯수 : {1}, 아이템 가격 : {2}",
                   item.Value.itemName, item.Value.itemCount, item.Value.itemPrice);
            }

            //Stack<int> stacknumbers = new Stack<int>();
            //stacknumbers.Push(1);
            //stacknumbers.Pop();

        }

        static void Desc001()
        {

            // Print001 printClass = new Print001();       // new => 힙에다가 저장 == 인스턴스화 한다.
            // printClass.PrintMesage("Hello World");

            //Print001 printClass = new Print001();
            //printClass.PrintMesage();

            Print001.staticmasaage = "여기에 값이 들어가나?";
            Console.WriteLine(Print001.staticmasaage);

            List<int> numbers = new List<int>();
            Console.WriteLine("내 리스트의 크기는 몇일까 ? -> {0}", numbers.Count);

            for(int i = 0; i<10; i++)
            {
                numbers.Add(i + 1);
            }

            foreach(int n in numbers)
            {
                Console.Write("{0} ", n);

            }
            Console.WriteLine();
            Console.WriteLine("내 리스트의 크기는 몇일까 ? -> {0}", numbers.Count);

            for (int i = numbers.Count - 1; 0 <= i; i--)
            {
                if( i % 2 == 1 )
                {
                    Console.WriteLine("[데이터 지우는 중] 내가 지우려는 데이터 -> {0} ", numbers[i]);
                    numbers.Remove(i);
                }
                else 
                {
                    Console.WriteLine("[데이터 지우는 중] 내 리스트의 크기는 -> {0} ", numbers.Count);              
                }
            }
        }
    }
}
