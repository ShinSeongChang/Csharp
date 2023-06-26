using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 리스트_확인용
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            string changecard2 = default;
            int changecard2_num = 0;

            Random rand = new Random();

            int randomnum1 = 0;


            
            for(int i = 0; i < 52; i++)
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

                for (int i = 7; i < 12; i++)
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

                for (int i = 0; i < user_cardnum.Count; i++)
                {
                    Console.Write("{0} {1} ", user_cardnum[i], user_cardpattern[i]);
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.Write("베팅 포인트를 입력해주세요 : ");

                userinput = Console.ReadLine();
                int.TryParse(userinput, out bettingpoint);

                for (int i = 0; i < 2; i++)
                {

                    Console.WriteLine("교체할 카드 두장을 고릅니다 ");
                    Console.Write("교체할 카드 : ");
                    changecard1 = Console.ReadLine();
                    int.TryParse(changecard1, out changecard1_num);

                    switch (changecard1_num)
                    {
                        case 1:
                            user_cardnum.Remove(user_cardnum[0]);
                            user_cardpattern.Remove(user_cardpattern[0]);

                            cardnum.Add(user_cardnum[0]);
                            cardspattern.Add(user_cardpattern[0]);

                            randomnum1 = rand.Next(0, cardnum.Count);

                            user_cardnum.Add(cardnum[randomnum1]);
                            user_cardpattern.Add(cardspattern[randomnum1]);

                            cardnum.Remove(cardnum[randomnum1]);
                            cardspattern.Remove(cardspattern[randomnum1]);
                            break;

                        case 2:
                            user_cardnum.Remove(user_cardnum[1]);
                            user_cardpattern.Remove(user_cardpattern[1]);

                            cardnum.Add(user_cardnum[1]);
                            cardspattern.Add(user_cardpattern[1]);

                            randomnum1 = rand.Next(0, cardnum.Count);

                            user_cardnum.Add(cardnum[randomnum1]);
                            user_cardpattern.Add(cardspattern[randomnum1]);

                            cardnum.Remove(cardnum[randomnum1]);
                            cardspattern.Remove(cardspattern[randomnum1]);
                            break;
                        case 3:
                            user_cardnum.Remove(user_cardnum[2]);
                            user_cardpattern.Remove(user_cardpattern[2]);

                            cardnum.Add(user_cardnum[2]);
                            cardspattern.Add(user_cardpattern[2]);

                            randomnum1 = rand.Next(0, cardnum.Count);

                            user_cardnum.Add(cardnum[randomnum1]);
                            user_cardpattern.Add(cardspattern[randomnum1]);

                            cardnum.Remove(cardnum[randomnum1]);
                            cardspattern.Remove(cardspattern[randomnum1]);
                            break;
                        case 4:
                            user_cardnum.Remove(user_cardnum[3]);
                            user_cardpattern.Remove(user_cardpattern[3]);

                            cardnum.Add(user_cardnum[3]);
                            cardspattern.Add(user_cardpattern[3]);

                            randomnum1 = rand.Next(0, cardnum.Count);

                            user_cardnum.Add(cardnum[randomnum1]);
                            user_cardpattern.Add(cardspattern[randomnum1]);

                            cardnum.Remove(cardnum[randomnum1]);
                            cardspattern.Remove(cardspattern[randomnum1]);
                            break;
                        case 5:
                            user_cardnum.Remove(user_cardnum[4]);
                            user_cardpattern.Remove(user_cardpattern[4]);

                            cardnum.Add(user_cardnum[4]);
                            cardspattern.Add(user_cardpattern[4]);

                            randomnum1 = rand.Next(0, cardnum.Count);

                            user_cardnum.Add(cardnum[randomnum1]);
                            user_cardpattern.Add(cardspattern[randomnum1]);

                            cardnum.Remove(cardnum[randomnum1]);
                            cardspattern.Remove(cardspattern[randomnum1]);
                            break;

                    }

                }

                Console.WriteLine("플레이어의 카드");
                Console.WriteLine();

                for (int i = 0; i < user_cardnum.Count; i++)
                {
                    Console.Write("{0} {1} ", user_cardnum[i], user_cardpattern[i]);
                }

                Console.WriteLine();
                Console.WriteLine();




            }


        }

    }
}
