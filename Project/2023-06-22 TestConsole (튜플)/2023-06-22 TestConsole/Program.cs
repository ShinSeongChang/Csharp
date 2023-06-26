using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_22_TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 튜플 선언하는 법
            (int xPos, int yPos) playerPosition = (0, 1);
            playerPosition.xPos = 10;
            playerPosition.yPos = 20;

            Console.WriteLine("Player position : ({0}, {1})", playerPosition.xPos, playerPosition.yPos);
            (playerPosition.xPos, playerPosition.yPos) = (playerPosition.yPos, playerPosition.xPos);
            Console.WriteLine("Player position : ({0}, {1})", playerPosition.xPos, playerPosition.yPos);
        }

        static void Desc002()
        {
            string strValue = "i am a boy.";
            string[] strArray = strValue.Split(' ');

            Console.WriteLine("몇 개로 Split 되었는가? -> {0}", strArray.Count());
            Console.WriteLine();

            foreach (string str_ in strArray)
            {
                Console.WriteLine("{0}", str_);
            }

            int? number = null;
            // int number = int.MinValue; 정수에서 음수값을 안쓰려 할 때
            // int number = int.MaxValue;         양수값을 안쓰려 할 때

        }

        static void Desc001()
        {
            List<int> intList = new List<int>();
            CustomClass customclass = new CustomClass();
            CustomChild customChild = new CustomChild();

            customChild.Initialize(0, 1);

            PrintValue(customChild);

            customChild = null;
            if(customChild == null) 
            {
                Console.WriteLine("customchild는 null 입니다.");
            }
            else
            {
                customChild.PrintPosition();
            }

            customChild?.PrintPosition();

        }

        // var 런타임때 타입을 추론, 제네릭은 컴파일때 타입을 추론한다 ==> 속도차이가 있다.

        //                     제네릭을 T로 쓰는이유 : C, c++을 사용하던 시절에는 제네릭이 아닌 템플릿이라는 이름을 갖고있어서 T를 따왔었다.
        //                                          <> 내부는 T가 아닌 자신만의 작명을 써도 된다.
        // 기본 형태는                여기까지//  where 부터는 해당하는 부분만 받아들이겠다는 제한을 거는 것이다.
        static void PrintValue<T>(T anyValue) where T : CustomClass
        {
            anyValue.PrintPosition();
        }

        //static void PrintValue(int intValue)
        //{
        //    Console.WriteLine("int 매개변수로 넘겨받은 값을 출력했다. -> {0}", intValue);
        //}
        //static void PrintValue(float floatValue)
        //{
        //    Console.WriteLine("float 매개변수로 넘겨받은 값을 출력했다. -> {0}", floatValue);
        //}
        //static void PrintValue(string strValue)
        //{
        //    Console.WriteLine("string 매개변수로 넘겨받은 값을 출력했다. -> {0}", strValue);
        //}


    }
}
