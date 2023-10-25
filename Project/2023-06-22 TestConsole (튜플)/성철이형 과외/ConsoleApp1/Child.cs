using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Child : Parent
    {
        public Child(string name) : base(name)
        {
            Console.WriteLine($"자식이 생성자를 호출할때 부모에게 보낸 이름 : {base.name}");
        }

        public void ChildPrint()
        {
            name = Console.ReadLine();

            Console.WriteLine($"자식에서 부모이름 바꿔보기 : {name}");
            Console.WriteLine($"자식에서 부모이름 바꿔보기2 : {base.name}");
        }
    }
}
