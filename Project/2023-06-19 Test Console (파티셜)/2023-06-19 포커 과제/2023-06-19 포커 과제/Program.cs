using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_19_포커_과제
{
    
    public class Program
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

            for(int i = 0; i<52; i++)
            {
                Console.WriteLine("{0} {1}", cardnum[i], cardspattern[i]);
            }

        }
    }
}
