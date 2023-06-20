using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Poker checkcard = new Poker();

            List<int> cardnum = new List<int>();
            List<string> cardspattern = new List<string>();

            List<int> computer_cardnum = new List<int>();
            List<string> computer_cardpattern = new List<string>();

            List<int> user_cardnum = new List<int>();
            List<string> user_cardpattern = new List<string>();


            int point = 1000;
            string userinput = default;
            int bettingpoint = 0;
            string changecard1 = default;
            int changecard1_num = 0;
            int swapcard = 5;

            Random rand = new Random();

            int randomnum1 = 0;

            for (int i = 0; i < 52; i++)
            {
                cardnum.Add(i + 1);
                cardnum[i] = (cardnum[i] % 13) + 1;
                //if (cardnum[i] % 13 == 11)
                //{
                //    cardnum[i] = "J";
                //}

            }


            for (int i = 0; i < 13; i++)
            {
                cardspattern.Add("♠");
            }
            for (int i = 13; i < 26; i++)
            {
                cardspattern.Add("◆");
            }
            for (int i = 26; i < 39; i++)
            {
                cardspattern.Add("♥");
            }
            for (int i = 39; i < 52; i++)
            {
                cardspattern.Add("♣");
            }



            while (true)
            {

                for (int i = 0; i < 7; i++)
                {
                    randomnum1 = rand.Next(0, cardnum.Count);
                    if (randomnum1 % 13 == 11)
                    {

                    }

                    computer_cardnum.Add(cardnum[randomnum1]);
                    computer_cardpattern.Add(cardspattern[randomnum1]);

                    cardnum.Remove(cardnum[randomnum1]);
                    cardspattern.Remove(cardspattern[randomnum1]);
                }

                for (int i = 0; i < 7; i++)
                {
                    randomnum1 = rand.Next(0, cardnum.Count);
                    user_cardnum.Add(cardnum[randomnum1]);
                    user_cardpattern.Add(cardspattern[randomnum1]);

                    cardnum.Remove(cardnum[randomnum1]);
                    cardspattern.Remove(cardspattern[randomnum1]);
                }

                Console.WriteLine("컴퓨터의 카드");
                Console.WriteLine();
                //Console.WriteLine(" 1.     2.   3.     4.     5.     6.     7.");
                for (int i = 0; i < computer_cardnum.Count; i++)
                {
                    Console.Write("{0} {1} ", computer_cardnum[i], computer_cardpattern[i]);
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("플레이어의 카드");
                Console.WriteLine();

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0} {1} ", user_cardnum[i], user_cardpattern[i]);
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.Write("베팅 포인트를 입력해주세요 : ");

                userinput = Console.ReadLine();
                int.TryParse(userinput, out bettingpoint);

                Console.WriteLine("교체할 카드 두장을 고릅니다 ");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine();
                    Console.Write("교체할 카드 : ");
                    changecard1 = Console.ReadLine();
                    int.TryParse(changecard1, out changecard1_num);


                    switch (changecard1_num)
                    {

                        case 1:
                            changecard1_num -= 1;
                            int temp = 0;
                            string temp2 = "\0";

                            temp = user_cardnum[0];
                            user_cardnum[0] = user_cardnum[swapcard];
                            user_cardnum[swapcard] = temp;

                            temp2 = user_cardpattern[0];
                            user_cardpattern[0] = user_cardpattern[swapcard];
                            user_cardpattern[swapcard] = temp2;
                            break;

                        case 2:
                            changecard1_num -= 1;
                            temp = user_cardnum[1];
                            user_cardnum[1] = user_cardnum[swapcard];
                            user_cardnum[swapcard] = temp;

                            temp2 = user_cardpattern[1];
                            user_cardpattern[1] = user_cardpattern[swapcard];
                            user_cardpattern[swapcard] = temp2;
                            break;

                        case 3:
                            changecard1_num -= 1;
                            temp = user_cardnum[2];
                            user_cardnum[2] = user_cardnum[swapcard];
                            user_cardnum[swapcard] = temp;

                            temp2 = user_cardpattern[2];
                            user_cardpattern[2] = user_cardpattern[swapcard];
                            user_cardpattern[swapcard] = temp2;
                            break;

                        case 4:
                            changecard1_num -= 1;
                            temp = user_cardnum[3];
                            user_cardnum[3] = user_cardnum[swapcard];
                            user_cardnum[swapcard] = temp;

                            temp2 = user_cardpattern[3];
                            user_cardpattern[3] = user_cardpattern[swapcard];
                            user_cardpattern[swapcard] = temp2;
                            break;

                        case 5:
                            changecard1_num -= 1;
                            temp = user_cardnum[4];
                            user_cardnum[4] = user_cardnum[swapcard];
                            user_cardnum[swapcard] = temp;

                            temp2 = user_cardpattern[4];
                            user_cardpattern[4] = user_cardpattern[swapcard];
                            user_cardpattern[swapcard] = temp2;
                            break;

                    }

                    swapcard++;

                    Console.WriteLine("플레이어의 카드");
                    Console.WriteLine();


                }


                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 4-j; k++)
                    {
                        if (user_cardnum[k] > user_cardnum[k + 1])
                        {
                            int temp = 0;
                            temp = user_cardnum[k];
                            user_cardnum[k] = user_cardnum[k + 1];
                            user_cardnum[k + 1] = temp;

                            string temp2 = user_cardpattern[k];
                            user_cardpattern[k] = user_cardpattern[k + 1];
                            user_cardpattern[k + 1] = temp2;
                        }

                    }

                }

                for (int a = 0; a < 5; a++)
                {
                    Console.Write("{0} {1} ", user_cardnum[a], user_cardpattern[a]);
                }

                // 백스트레이트, 마운틴 제외

                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

            }


        }

        static void Swap(ref int first, ref int second)
        {
            int temp = 0;
            temp = first;
            first = second;
            second = temp;
        }
    
    }
}
