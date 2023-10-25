using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class 실행
    {
        //멤버변수
        public MoveSomething move;
        public MoveSomething move2;
        int[] arr;

        //new 할 때 실행이 된다
        //생성자
        public 실행()
        {
            arr = new int[14];
            move = new MoveSomething();


        }

        public void Play()
        {
            Console.WriteLine(move.x + ", " + move.y);
            Console.WriteLine(move2.x + ", " + move2.y);

        }
    }
}
