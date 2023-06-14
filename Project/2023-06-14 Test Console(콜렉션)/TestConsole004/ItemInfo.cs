using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole004
{
    public class ItemInfo
    {
        public string itemName;
        public int itemCount;
        public int itemPrice;

        public void InitItem(string name, int count, int price)
        {
            itemName = name;
            itemCount = count;
            itemPrice = price;
        }
    }
}
