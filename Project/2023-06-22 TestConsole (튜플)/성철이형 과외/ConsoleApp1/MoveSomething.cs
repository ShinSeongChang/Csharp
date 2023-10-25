using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MoveSomething
    {
        public int x = default;
        public int y = default;
        public int? z;

        public MoveSomething() 
        {
            x = 10;
            y = 15;
            z = null;

        }


        // 정적 메소드 => 따로 인스턴스, 참조 없이 바로 접근 가능 하다. 정적 변수또한 마찬가지
        public static void TestMetod()
        {
            Console.WriteLine("정적 메소드는 바로 접근 가능");
        }

        public void Nullable()
        {
            Console.Write("Nullable");
        }



        ~MoveSomething()
        {
            Console.WriteLine("가비지 컬렉터가 동작");
        }

    }
}
