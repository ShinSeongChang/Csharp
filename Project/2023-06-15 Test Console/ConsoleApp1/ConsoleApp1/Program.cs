using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        
            System.ConsoleKeyInfo userKey = default;


            string userinput = default;
            int useroutput = 0;
            int player = 0;
            int rock = 0;
            int rock_x = default;
            int rock_y = default;
            int score = 0;
            int movecount = 0;
            string[,] background = new string[20, 20];

        
            Console.Write("     맵 사이즈를 입력해주세요 : ");
            userinput = Console.ReadLine();

            Console.Clear();

            int.TryParse(userinput, out useroutput);

        Reset:
            player = useroutput / 2;
            int player_x = player;
            int player_y = player;

            for (int y = 0; y < useroutput; y++)
            {
                for (int x = 0; x < useroutput; x++)
                {
                    background[y, x] = "*  ";

                    if (x == player_x && y == player_y)
                    {
                        background[y, x] = "0  ";
                    }

                }

            }


            while (true)
            {

            square_limit:

                Console.SetCursorPosition(0, 0);

                for (int y = 0; y < useroutput; y++)
                {
                    for (int x = 0; x < useroutput; x++)
                    {
                        Console.Write("{0}", background[y, x]);
                    }

                    Console.WriteLine();
                }

                userKey = Console.ReadKey(true);

                if(userKey.KeyChar == 'r' || userKey.KeyChar == 'R')
                {
                    movecount = 0;
                    rock = 0;

                    goto Reset;
                }

                if (userKey.KeyChar == 'w' || userKey.KeyChar == 'W')
                {
                    if (player_y <= 0)
                    {
                        player_y = 0;
                        goto square_limit;
                    }
                    
                    if (background[player_y -1, player_x] == "#  ")
                    {
                        for(int y = player_y -2; y >= 0; y--)
                        {
                            if (background[y, player_x] == "#  ")
                            {
                                Swap(ref background[player_y - 1, player_x], ref background[y + 1, player_x]);
                                goto square_limit;
                            }
                            
                        }

                        Swap(ref background[player_y -1, player_x], ref background[0, player_x]);

                    }
               
                    Swap(ref background[player_y, player_x], ref background[player_y - 1, player_x]);
                    player_y -= 1;

                }

                else if (userKey.KeyChar == 's' || userKey.KeyChar == 'S')
                {
                    if (player_y >= useroutput - 1)
                    {
                        player_y = useroutput - 1;
                        goto square_limit;
                    }

                    if (background[player_y + 1, player_x] == "#  ")
                    {
                        for (int y = player_y + 2; y <= useroutput -1; y++)
                        {
                            if (background[y, player_x] == "#  ")
                            {
                                Swap(ref background[player_y + 1, player_x], ref background[y -1, player_x]);
                                goto square_limit;
                            }

                        }

                        Swap(ref background[useroutput -1 , player_x], ref background[player_y + 1, player_x]);

                    }


                    Swap(ref background[player_y, player_x], ref background[player_y + 1, player_x]);
                    player_y += 1;
                }

                else if (userKey.KeyChar == 'a' || userKey.KeyChar == 'A')
                {
                    if (player_x <= 0)
                    {
                        player_x = 0;
                        goto square_limit;
                    }

                    if (background[player_y, player_x -1] == "#  ")
                    {
                        for (int x = player_x - 2; x >= 0; x--)
                        {
                            if (background[player_y, x] == "#  ")
                            {
                                Swap(ref background[player_y, player_x-1], ref background[player_y, x+1]);
                                goto square_limit;
                            }

                        }

                        Swap(ref background[player_y, 0], ref background[player_y , player_x-1]);

                    }


                    Swap(ref background[player_y, player_x], ref background[player_y, player_x - 1]);
                    player_x -= 1;
                }

                else if (userKey.KeyChar == 'd' || userKey.KeyChar == 'D')
                {
                    if (player_x >= useroutput - 1)
                    {
                        player_x = useroutput - 1;
                        goto square_limit;
                    }

                    if (background[player_y, player_x + 1] == "#  ")
                    {
                        for (int x = player_x + 2; x <= useroutput -1; x++)
                        {
                            if (background[player_y, x] == "#  ")
                            {
                                Swap(ref background[player_y, player_x + 1], ref background[player_y, x-1]);
                                goto square_limit;
                            }

                        }

                        Swap(ref background[player_y, player_x +1 ], ref background[player_y, useroutput -1]);

                    }


                    Swap(ref background[player_y, player_x], ref background[player_y, player_x + 1]);
                    player_x += 1;
                }

                movecount += 1;

                if (movecount == 5 && rock < 3)
                {
                    Random random = new Random();
                    rock_x = random.Next(0, useroutput - 1);
                    rock_y = random.Next(0, useroutput - 1);

                    while (background[rock_y, rock_x] == background[player_y, player_x] || background[rock_y,rock_x] == background[rock_y,rock_x])
                    {
                        rock_x = random.Next(0, useroutput - 1);
                        rock_y = random.Next(0, useroutput - 1);
                        break;
                    }

                    background[rock_y, rock_x] = "#  ";

                    movecount = 0;
                    rock += 1;
                }

            }

        }

        static void Swap(ref string first, ref string second)
        {
            string temp = default;
            temp = first;
            first = second;
            second = temp;
        }
    }
}
