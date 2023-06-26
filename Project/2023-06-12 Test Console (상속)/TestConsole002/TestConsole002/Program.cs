using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole002
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Dog myDog = new Dog();
            //Console.WriteLine("우리집 강아지 이름은 {0} 이고, 다리 갯수는 {1}개 이다.",
            //    myDog.dogName, myDog.legCount);

            //myDog.Print_DogDescription();       // private한 변수도 값이 출력된다.

            //Dog.Print_DogDescription002();

            //Cat myCat = new Cat(4, "야옹이", "검정색");
            //myCat.Print_MyCat();



            Zombie monsterZombie = new Zombie();
            monsterZombie.Initilize("좀비", 100, 0, 5, 2, "Undead");
            monsterZombie.Print_MonsterInfo();

            Skeletone monsterSkeletone = new Skeletone();
            monsterSkeletone.Initilize("해골병사", 60, 10, 30, 5, "Undead");
            monsterSkeletone.Print_MonsterInfo();


            Lich bossmonsterLich = new Lich();
            bossmonsterLich.Initilize("리치", 1000, 1000, 150, 20, "Undead");
            bossmonsterLich.Print_MonsterInfo();


        }   // Main()

        static void Desc001()
        {
            string[] str = new string[2] { "Hello", "world" };
            // CallFunc001(str);
            //CallFunc002("Hello", "World", "+", "Hello", "World");
            //CallFunc003(ref str);
            CallFunc003(ref str);

            string[] resultStr;             // string 배열을 선언함.
            CallFunc004(str, out resultStr);    // out을 활용해서 값을 넘겨 받음.

            foreach (string result_ in resultStr)      
            {
                Console.Write("{0} ", result_);
            }

            Console.WriteLine();

        }

        // ! 첫번째 방법은 매개변수를 call by value 방식으로 넘기는 방법

        static void CallFunc001(string[] str)
        {
            foreach(string strElement in str)       // 메모리 값의 순차적인 정렬로 메모리 크기만큼 값을 대입해주는 
            {
                Console.Write("{0} ", strElement);
            }

            Console.WriteLine();

        }       // CallFunc001()

        // ! 두번째 방법은 매개변수를 call by value 방식으로 넘기는건 똑같음. 그런데 넘겨줄
        // ! 매개변수를 배열의 요소 형태로 여러개 넘길 수 있다.

        static void CallFunc002(params string[] str)
        {
            foreach (string strElement in str)
            {
                Console.Write("{0} ", strElement);
            }

            Console.WriteLine();
        }

        // ! 세번째 방법은 매개변수를 call by reference 방식으로 넘기는 방법

        static void CallFunc003(ref string[] str)
        {
            foreach (string strElement in str)
            {
                Console.Write("{0} ", strElement);
            }

            Console.WriteLine();
        }

        // ! 네번째 방법은 매개변수를 call by reference 방식으로 넘기는 방법
        // ! 매개변수를 통해서 값을 Return 한다.

        static void CallFunc004(string[] str, out string[] outstr)
        {
            string[] resultString = new string[str.Length + 1];

            for(int i = 0; i < str.Length; i++)
            {
                resultString[i] = str[i];

            }

            resultString[str.Length] = "!";
            outstr = resultString;

        }


    }       // class Program
}
