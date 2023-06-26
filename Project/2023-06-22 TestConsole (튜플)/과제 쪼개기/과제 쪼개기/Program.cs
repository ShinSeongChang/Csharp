using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 과제_쪼개기
{
    public class Program
    {
        static void Main(string[] args)
        {
            Map map_Create = new Map();
            map_Create.Create_Map();
            map_Create.Draw_Map();
        }
    }
}
