using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole005
{
    public class Parent
    {

        protected int number = default;
        protected string strValue = default;

        public virtual void PrintInfos()
        {
            number = 1;


            Console.WriteLine("Parent class -> number : {0}, strValue : {1}",
                number, strValue);
        }


    }
}
