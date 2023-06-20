using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_20_개별과제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] map = new string[20, 20];
            int map_Size = 20;
            string map_ground = " ㅤ ";
            string map_limit = " ■ ";

            string player = " ★ ";
            int player_X = map_Size / 2;
            int player_Y = map_Size / 2;

            for(int y= 0; y<map_Size; y++)
            {
                for(int x = 0; x<map_Size; x++)
                {
                    map[y, x] = map_ground;

                    if (x == 0 || x == map_Size -1 || y == 0 || y == map_Size -1)
                    {
                        map[y, x] = map_limit;
                    }
                    else if(x == player_X && y == player_Y)
                    {
                        map[y, x] = player;
                    }
                    
                }
            }


            while(true)
            {

                Console.SetCursorPosition(0, 0);

                for (int y = 0; y < map_Size; ++y)
                {
                    for (int x = 0; x < map_Size; x++)
                    {
                        Console.Write(map[y, x]);
                    }
                    Console.WriteLine();
                }                   

                ConsoleKeyInfo user_Arrow = Console.ReadKey();

                switch(user_Arrow.Key)
                {
                    case ConsoleKey.UpArrow:
                        
                        if(map[player_Y -1, player_X] == map_limit)
                        {
                            continue;
                        }

                        Swap(ref map[player_Y, player_X], ref map[player_Y -1, player_X]);
                        player_Y -= 1;

                        break;
                    case ConsoleKey.DownArrow:

                        if (map[player_Y+1,player_X] == map_limit)
                        {
                            player_Y = map_Size - 2;
                            continue;
                        }

                        Swap(ref map[player_Y, player_X], ref map[player_Y + 1, player_X]);
                        player_Y += 1;

                        break;
                    case ConsoleKey.LeftArrow:

                        if (map[player_Y,player_X -1] == map_limit)
                        {
                            player_X = 1;
                            continue;
                        }

                        Swap(ref map[player_Y, player_X], ref map[player_Y, player_X -1]);
                        player_X -= 1;

                        break;
                    case ConsoleKey.RightArrow:

                        if (map[player_Y, player_X +1] == map_limit)
                        {
                            player_X = map_Size -2;
                            continue;
                        }

                        Swap(ref map[player_Y, player_X], ref map[player_Y, player_X +1]);
                        player_X += 1;

                        break;
                }

                

            }

        
        }

        static void Swap(ref string first, ref string second)
        {
            string temp = "\0";
            temp = first;
            first = second;
            second = temp;
        }
    }
}
