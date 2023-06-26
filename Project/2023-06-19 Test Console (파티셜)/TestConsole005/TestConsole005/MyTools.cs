using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole005
{
    public static class MyTools
    {

        public static void DogPrint(this Dog myDog)
        {
            
        }

        public static int Plus(this int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }

        public static int PlusAndPrint(this int firstValue, int secondValue)
        {
            Console.WriteLine ("{0} + {1} = {2}", firstValue, secondValue, firstValue + secondValue);
            return firstValue + secondValue;
        }
    }
}
