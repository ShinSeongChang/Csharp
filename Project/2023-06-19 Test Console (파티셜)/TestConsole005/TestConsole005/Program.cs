using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole005
{
    public class Program
    {
        static void Main(string[] args)
        {

            Parent myParent = new Parent();
            Child myChild = new Child();

            //myParent.PrintInfos();
            //myChild.PrintInfos();

            Parent tempParent = myChild;
            Child tempChild = (Child)tempParent; 

            tempParent.PrintInfos();
            tempChild.PrintInfos();

            int number = 10;
            number.PlusAndPrint(5);

        }

        static void Desc001()
        {
            int number = 10;
            char charValue = 'A';
            string textStr = "Hello World!";

            // 오브젝트라는 타입의 canSaveAll 박스에 변수를 담고 있는것.

            //      상위 변수       하위변수
            //              <== 담는다
            object canSaveAll1 = number;
            object canSaveAll2 = charValue;
            object canSaveAll3 = textStr;

            // object랑 var은 전혀 다르다
            // var은 리플렉션이 이루어지고 있는 것. ( 선언된 변수의 타입을 탐색하여 해당 타입의 자료형으로 변환하는 것이 var이다. )

            var canSaveAnything1 = number;
            var canSaveAnything2 = charValue;
            var canSaveAnything3 = textStr;

            int number2 = (int)canSaveAll2;
            
            Console.WriteLine(canSaveAll1);
            Console.WriteLine(canSaveAll2);
            Console.WriteLine(canSaveAll3);

        }
    }
}
