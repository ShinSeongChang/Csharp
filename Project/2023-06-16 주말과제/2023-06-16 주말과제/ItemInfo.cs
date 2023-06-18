using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_16_주말과제
{
    internal class ItemInfo
    {
        public string itemname;
        public int itemprice;

        public void Init_Item(string name, int pirce)
        {
            itemname = name;
            itemprice = pirce;            
        }
    }
}
