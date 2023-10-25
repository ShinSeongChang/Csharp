using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Parent
    {
        protected string name;

        public Parent(string name) 
        {
            this.name  = name;
        }

        public void PrintParent(string message)
        {
            Console.WriteLine("이것은 자식이 부모에게 보내는 메세지입니다 : " + message);
        }
    }
}
