using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 개별과제
{
    internal class Gameplaying
    {
        public void Gameplay()
        {
            Thread.Sleep(100);
            Console.Clear();

            int gameturn = 0;
            int gamepoint = 1000;
            char usercode = default;
            char computerSecretCode = default;

            Random random = new Random();

            computerSecretCode = (char)random.Next(65, 90);

            while (usercode != computerSecretCode)
            {


                Console.WriteLine("{0}", computerSecretCode);
                Console.WriteLine("현재 게임 포인트 : {0} \t\t 현재 진행된 게임 턴 수 : {1}", gamepoint, gameturn);
                Console.Write("현재 컴퓨터의 코드를 맞춰 보세요 : ");
                usercode = Console.ReadLine()[0];

                if (usercode > computerSecretCode)
                {
                    Console.WriteLine("컴퓨터의 코드보다 높습니다. 숫자를 낮춰주세요.");
                    gameturn += 1;
                    gamepoint -= 100;
                    Thread.Sleep(800);
                    Console.Clear();
                    continue;
                }

                else if(usercode < computerSecretCode)
                {
                    Console.WriteLine("컴퓨터의 코드값보다 낮습니다. 숫자를 높혀주세요. ");
                    gameturn += 1;
                    gamepoint -= 100;
                    Thread.Sleep(800);
                    Console.Clear();
                    continue;
                }

            }

            Console.Clear() ;
            Console.WriteLine("컴퓨터의 코드를 맞췄습니다.");
            Console.WriteLine("2초후 게임이 자동 종료됩니다...");
            Thread.Sleep(2000);

        } 
    }
}
