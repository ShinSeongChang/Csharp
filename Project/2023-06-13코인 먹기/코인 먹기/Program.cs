using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 코인_먹기
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.ConsoleKeyInfo user_Key_Input = default;     // getch


            //  글자배경색, 글자색 바꾸는 함수

            //  Console.BackgroundColor = ConsoleColor.DarkYellow;
            //  Console.ForegroundColor = ConsoleColor.White;
            //  Console.WriteLine("색깔이 정말로 바뀌나?");

            string[,] background = new string[15, 15];

            string user_Background_Input = default;
            int user_Background = 0;
            int user_Array = 0;

        start:
            Console.Write("맵 사이즈를 입력해주세요(맵사이즈는 5 ~ 15 제한입니다.) : ");

            user_Background_Input = Console.ReadLine();

            int.TryParse(user_Background_Input, out user_Background);

            user_Array = user_Background / 2;

            if (user_Background < 5 || 15 < user_Background)
            {
                Console.WriteLine("입력하신 값은 제한크기를 벗어났습니다.");
                Console.WriteLine("맵 크기를 다시 입력해 주세요.");
                Thread.Sleep(1000);
                Console.Clear();
                goto start;
            }

            for (int y = 0; y < user_Background; y++)
            {
                for (int x = 0; x < user_Background; x++)
                {

                    background[y, x] = "*  ";

                    if (x == user_Background / 2 && y == user_Background / 2)
                    {
                        background[y, x] = "♀ ";
                    }

                    Console.Write("{0}", background[y, x]);

                }
                Console.WriteLine();
            }

            int user_X_Array = user_Array;
            int user_Y_Array = user_Array;
            int keycount = 4;
            int coincount = 0;

            while (true)
            {
                Console.SetCursorPosition(0, 0);

                if(coincount == 3)
                {
                    Console.Clear();
                    Console.WriteLine("게임 클리어!");
                    break;
                }

                Console.WriteLine("현재 획득한 코인 갯수 : {0}", coincount);

                //char user_Key_Input = (char)Console.ReadLine()[0];
                user_Key_Input = Console.ReadKey(true);

                //Console.Clear();
       
                if (user_Key_Input.KeyChar == 'w' || user_Key_Input.KeyChar == 'W')
                {
                    if (user_Y_Array <= 0)
                    {
                        user_Y_Array = 0;
                        goto exit;
                       
                    }

                    if ( background[user_Y_Array -1 ,user_X_Array] == "ⓒ ")
                    {
                        background[user_Y_Array -1 ,user_X_Array] = "*  ";
                        coincount += 1;
                    }

                    swap(ref background[user_Y_Array, user_X_Array],
                        ref background[user_Y_Array - 1, user_X_Array]);

                    user_Y_Array -= 1;
                   
                }
            
                else if (user_Key_Input.KeyChar == 's' || user_Key_Input.KeyChar == 'S')
                {

                    if (user_Y_Array >= user_Background -1)
                    {
                        user_Y_Array = user_Background -1 ;
                        goto exit;

                    }

                    if (background[user_Y_Array + 1, user_X_Array] == "ⓒ ")
                    {
                        background[user_Y_Array + 1, user_X_Array] = "*  ";
                        coincount += 1;
                    }

                    swap(ref background[user_Y_Array, user_X_Array],
                        ref background[user_Y_Array + 1, user_X_Array]);

                    user_Y_Array += 1;


                }
            
                else if (user_Key_Input.KeyChar == 'd' || user_Key_Input.KeyChar == 'D')
                {

                    if (user_X_Array >= user_Background - 1)
                    {
                        user_X_Array = user_Background - 1;
                        goto exit;

                    }

                    if (background[user_Y_Array, user_X_Array + 1] == "ⓒ ")
                    {
                        background[user_Y_Array, user_X_Array + 1] = "*  ";
                        coincount += 1;
                    }

                    swap(ref background[user_Y_Array, user_X_Array],
                        ref background[user_Y_Array, user_X_Array + 1]);

                    user_X_Array += 1;

                }
            
                else if (user_Key_Input.KeyChar == 'a' || user_Key_Input.KeyChar == 'A')
                {

                    if (user_X_Array <= 0)
                    {
                        user_X_Array = 0;
                        goto exit;

                    }

                    if (background[user_Y_Array, user_X_Array -1 ] == "ⓒ ")
                    {
                        background[user_Y_Array, user_X_Array -1 ] = "*  ";
                        coincount += 1;
                    }

                    swap(ref background[user_Y_Array, user_X_Array],
                        ref background[user_Y_Array, user_X_Array - 1]);

                    user_X_Array -= 1;

            
                }

                exit:

                if (keycount % 3 == 0)
                {
                    Random random = new Random();

                    int coin_x = random.Next(1, user_Background - 1);
                    int coin_y = random.Next(1, user_Background - 1);

                    while (background[coin_y,coin_x] == background[user_Y_Array,user_X_Array])
                    {
                        coin_x = random.Next(1, user_Background - 1);
                        coin_y = random.Next(1, user_Background - 1);
                    }

                    background[coin_y, coin_x] = "ⓒ ";

                }

                for (int y = 0; y < user_Background; y++)
                {
                    for (int x = 0; x < user_Background; x++)
                    {
                        Console.Write("{0}", background[y, x]);
                    }
                    Console.WriteLine();
                }

                keycount += 1;

                
            
            }
            
            
        }

        static void swap(ref string num1, ref string num2)
        {
            string temp = "";
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
