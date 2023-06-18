using _2023_06_16_주말과제;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2023_06_16_주말과제
{
    public class Field
    {
        public void Draw_field()
        {
            CardGame cardgame_play = new CardGame();
            Battle battle_play = new Battle();
            Shop shop_Init = new Shop();
            

            string[,] map = new string[20, 20];
            int mapsize = 20;
            string map_limit = " ■ ";
            string background = " □ ";
            string player = " ★ ";
            int player_x = 10;
            int player_y = 10;
            string shop = " S  ";
            int shop_x = 5;
            int shop_y = 7;
            string cardgame = " C  ";
            int cardgame_x = 17;
            int cardgame_y = 7;
            string monster = " M  ";
            int monster_x = 10;
            int monster_y = 3;

            for (int y = 0; y < mapsize; y++)
            {
                for (int x = 0; x < mapsize; x++)
                {
                    map[y, x] = background;

                    if (y == 0 || y == mapsize - 1 || x == 0 || x == mapsize - 1)
                    {
                        map[y, x] = map_limit;
                    }
                    else if (x == player_x && y == player_y)
                    {
                        map[y, x] = player;
                    }
                    else if (x == shop_x && y == shop_y)
                    {
                        map[y, x] = shop;
                    }
                    else if (x == cardgame_x && y == cardgame_y)
                    {
                        map[y, x] = cardgame;
                    }
                    else if (x== monster_x && y == monster_y)
                    {
                        map[y, x] = monster;
                    }

                }

            }

            while (true)
            {
                Console.SetCursorPosition(0, 0);

                for (int y = 0; y < mapsize; y++)
                {
                    for (int x = 0; x < mapsize; x++)
                    {
                        Console.Write("{0}", map[y, x]);
                    }

                    Console.WriteLine();

                }

                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();


                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:

                        if (map[player_y - 1, player_x] == cardgame)
                        {
                            cardgame_play.Play_CardGame();
                        }
                        else if (map[player_y - 1, player_x] == monster)
                        {
                            battle_play.Play_battle();
                        }
                        else if (map[player_y - 1, player_x] == shop)
                        {
                            shop_Init.Open_Shop();
                        }
                        else if (map[player_y - 1, player_x] != map_limit)
                        {
                            Swap(ref map[player_y, player_x], ref map[player_y - 1, player_x]);
                            player_y -= 1;
                        }

                        break;
                    case ConsoleKey.DownArrow:

                        if (map[player_y + 1, player_x] == cardgame)
                        {
                            cardgame_play.Play_CardGame();
                        }
                        else if (map[player_y + 1, player_x] == monster)
                        {
                            battle_play.Play_battle();
                        }
                        else if (map[player_y + 1, player_x] == shop)
                        {
                            shop_Init.Open_Shop();
                        }
                        else if (map[player_y + 1, player_x] != map_limit)
                        {
                            Swap(ref map[player_y, player_x], ref map[player_y + 1, player_x]);
                            player_y += 1;
                        }

                        break;
                    case ConsoleKey.LeftArrow:

                        if (map[player_y, player_x - 1] == cardgame)
                        {
                            cardgame_play.Play_CardGame();
                        }
                        else if (map[player_y, player_x - 1] == monster)
                        {
                            battle_play.Play_battle();
                        }
                        else if (map[player_y, player_x -1] == shop)
                        {
                            shop_Init.Open_Shop();
                        }
                        else if (map[player_y, player_x - 1] != map_limit)
                        {
                            Swap(ref map[player_y, player_x], ref map[player_y, player_x - 1]);
                            player_x -= 1;
                        }

                        break;
                    case ConsoleKey.RightArrow:

                        if (map[player_y, player_x + 1] == cardgame)
                        {
                            cardgame_play.Play_CardGame();
                        }
                        else if (map[player_y, player_x +1] == monster)
                        {
                            battle_play.Play_battle();
                        }
                        else if (map[player_y, player_x +1] == shop)
                        {
                            shop_Init.Open_Shop();
                        }
                        else if (map[player_y, player_x + 1] != map_limit)
                        {
                            Swap(ref map[player_y, player_x], ref map[player_y, player_x + 1]);
                            player_x += 1;
                        }

                        break;
                }



            }

        }
        public void Swap(ref string first, ref string second)
        {
            string temp = "\0";
            temp = first;
            first = second;
            second = temp;
        }

    }

}
