using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_16_주말과제
{
    internal class Shop
    {        
        public void Open_Shop()
        {
            Random random = new Random();

            ItemInfo sword = new ItemInfo();
            sword.Init_Item("검", 1000);
            ItemInfo spear = new ItemInfo();
            spear.Init_Item("창", 700);
            ItemInfo axe = new ItemInfo();
            axe.Init_Item("도끼", 1300);
            ItemInfo hammer = new ItemInfo();
            hammer.Init_Item("망치", 1500);
            ItemInfo arrow = new ItemInfo();
            arrow.Init_Item("활", 2000);

            Console.Clear();

            Dictionary<string, ItemInfo> items = new Dictionary<string, ItemInfo>();
            items.Add("검", sword);
            items.Add("창", spear);
            items.Add("도끼", axe);
            items.Add("망치", hammer);
            items.Add("활", arrow);

            Dictionary<string, ItemInfo> userinventory = new Dictionary<string, ItemInfo>();


            string userinput = default;

            while (true)
            {
                Console.WriteLine("이름\t 가격\t");
                Console.WriteLine();
                Console.WriteLine();

                foreach (var item in items)
                {
                    Console.WriteLine("{0}\t{1}", item.Key, item.Value.itemprice);
                }

                

                foreach (var item in userinventory)
                {
                    Console.WriteLine("{0}", item.Key);
                }

                userinput = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("유저 인벤토리");
                Console.WriteLine();


                if (userinput == "검")
                {
                    items.Remove("검");                    
                    //userinventory.Add("검");
                }
                else if(userinput == "창")
                {
                    items.Remove("창");

                }
                else if (userinput == "도끼")
                {
                    items.Remove("도끼");
                }
                else if (userinput == "망치")
                {
                    items.Remove("망치");
                }
                else if (userinput == "활")
                {
                    items.Remove("활");
                }

                Console.Clear() ;

            }
        }
    }
}
