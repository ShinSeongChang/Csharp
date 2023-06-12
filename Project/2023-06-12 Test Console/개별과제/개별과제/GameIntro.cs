using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 개별과제
{
    public class GameIntro
    {
        public void GameStart()
        {

            string userstart = default;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tUP & Down 게임");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("게임을 시작한다 : Y \t 게임을 종료한다 : N");
            Console.Write("입력해주세요 : ");

            userstart = Console.ReadLine();

            if (userstart == "Y")
            {
                Gameplaying ingame = new Gameplaying();
                ingame.Gameplay();
            }

            else if (userstart == "N")
            {
                Console.WriteLine("게임을 종료합니다.");
                Thread.Sleep(500);
            } 
            
        }

    }
}
