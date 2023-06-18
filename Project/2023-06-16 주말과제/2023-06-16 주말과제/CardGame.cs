using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2023_06_16_주말과제
{
    public class CardGame
    {
        public void Play_CardGame()
        {
            Field field = new Field();

            string[] card_Numbers = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] card_Pattern = { "♠", "◆", "♥", "♣" };

            string[] drawcard_Number = new string[3];
            string[] drawcard_Pattern = new string[3];

            int randomnum1 = 0;
            int randomnum2 = 0;
            int randomnum3 = 0;

            int randompattern1 = 0;
            int randompattern2 = 0;
            int randompattern3 = 0;

            int point = 1000;
            string userinput = default;
            int betting_point = 0;


            Random random = new Random();

            Console.Clear();
        
            while (true)
            {   

                if(point <= 0)
                {
                    Console.WriteLine("소지한 포인트를 모두 잃었습니다...");
                    Thread.Sleep(1000);
                    break;
                }
                else if(point >= 5000)
                {
                    Console.WriteLine("목표치를 이뤘습니다!");
                    Thread.Sleep(1000);
                    break;
                }

                while (true)
                {
                    randomnum1 = random.Next(0, card_Numbers.Length);
                    randomnum2 = random.Next(0, card_Numbers.Length);
                    randomnum3 = random.Next(0, card_Numbers.Length);

                    drawcard_Number[0] = card_Numbers[randomnum1];
                    drawcard_Number[1] = card_Numbers[randomnum2];
                    drawcard_Number[2] = card_Numbers[randomnum3];

                    randompattern1 = random.Next(0, card_Pattern.Length);
                    randompattern2 = random.Next(0, card_Pattern.Length);
                    randompattern3 = random.Next(0, card_Pattern.Length);

                    drawcard_Pattern[0] = card_Pattern[randompattern1];
                    drawcard_Pattern[1] = card_Pattern[randompattern2];
                    drawcard_Pattern[2] = card_Pattern[randompattern3];


                    //for (int i = 0; i < drawcard_Number.Length; i++)
                    //{
                    //    drawcard_Number[i] = card_Numbers[random.Next(0,card_Numbers.Length)];
                    //    drawcard_Pattern[i] = card_Pattern[random.Next(0,card_Pattern.Length)];
                    //}

                    if (randomnum1 != randomnum2 && randomnum2 != randomnum3 && randomnum1 != randomnum3)
                    {
                        break;
                    }

                }

                Console.Write("컴퓨터의 카드");
                Console.WriteLine("\t\t\t 소지한 포인트 : {0}", point);
                Console.WriteLine("{0}{1,2}", drawcard_Number[0], drawcard_Pattern[0]);
                Console.WriteLine("{0}{1,2}", drawcard_Number[1], drawcard_Pattern[1]);


                Console.WriteLine("베팅 하시겠습니까?  수락 : [Y]  거절: [N]");

                ConsoleKeyInfo userkey = Console.ReadKey();

                Console.WriteLine();

                switch (userkey.Key)
                {
                    case ConsoleKey.Y:
                        Console.Write("베팅 포인트를 입력해주세요 : ");
                        userinput = Console.ReadLine();

                        int.TryParse(userinput, out betting_point);

                        if(betting_point > point)
                        {
                            Console.WriteLine("소지한 포인트보다 많습니다.");
                            Console.WriteLine("카드를 다시 뽑습니다.");
                            Thread.Sleep(1000);
                            Console.Clear();

                            continue;
                        }

                        point -= betting_point;


                        Console.WriteLine("당신의 카드는....");

                        Thread.Sleep(1000);

                        Console.WriteLine("{0}{1,2}", drawcard_Number[2], drawcard_Pattern[2]);

                        if (randomnum1 < randomnum3 && randomnum3 < randomnum2 || randomnum2 < randomnum3 && randomnum3 < randomnum1)
                        {

                            point += betting_point * 2;

                            Console.Write("베팅에 성공하셨습니다!!");
                            Console.WriteLine("\t소지 포인트 : {0}", point);

                            Thread.Sleep(1000);
                            break;

                        }

                        Console.Write("승부실패... 베팅포인트를 잃습니다.");
                        Console.WriteLine("\t차감 포인트 : {0}", betting_point);
                        Thread.Sleep(2000);

                        if (point <= 0)
                        {
                            Console.WriteLine("승부할 포인트가 없습니다...");
                            Console.Clear();
                            Console.WriteLine("Game Over");
                        }
                        break;

                    case ConsoleKey.N:
                        Console.WriteLine("카드를 다시 뽑습니다.");
                        Thread.Sleep(1000);
                        break;

                }

                Console.WriteLine("게임을 계속 하시려면 [Y] 키를, 나가시려면 [N] 키를 눌러주세요.");
                userkey = Console.ReadKey();

                if(userkey.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("게임을 재개합니다.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else if(userkey.Key == ConsoleKey.N)
                {
                    Console.WriteLine("게임에서 나갑니다.");
                    Thread.Sleep(1000);
                    break;
                }

                
               
            }

        }
 
    }

}
