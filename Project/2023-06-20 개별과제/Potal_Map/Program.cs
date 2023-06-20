using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Potal_Map
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 맵 입력
            #region
            string[,] map = new string[20, 20];
            int map_Size = 20;
            string map_ground = "ㅤ";
            string map_limit = "■";

            string player = "★";
            int player_X = map_Size / 2;
            int player_Y = map_Size / 2;

            string portal = "＠";

            for (int y = 0; y < map_Size; y++)
            {
                for (int x = 0; x < map_Size; x++)
                {
                    map[y, x] = map_ground;

                    if (((x == 0 || x == map_Size - 1) && y == map_Size / 2) || ((y == 0 || y == map_Size - 1) && x == map_Size / 2))
                    {
                        map[y, x] = portal;
                    }
                    else if (x == 0 || x == map_Size - 1 || y == 0 || y == map_Size - 1)
                    {
                        map[y, x] = map_limit;
                    }
                    else if (x == player_X && y == player_Y)
                    {
                        map[y, x] = player;
                    }


                }
            }
            #endregion

            // 게임 시작 == 맵 내부 플레이어 이동로직
            
            while (true)
            {
                // 맵 출력
                Console.SetCursorPosition(0, 0);

                for (int y = 0; y < map_Size; ++y)
                {
                    for (int x = 0; x < map_Size; x++)
                    {
                        Console.Write(map[y, x]);
                    }
                    Console.WriteLine();
                }
                // 맵 출력


                // 맵 내부 플레이어 이동                
                ConsoleKeyInfo user_Arrow = Console.ReadKey();

                switch (user_Arrow.Key)
                {
                    case ConsoleKey.UpArrow:

                        if (map[player_Y - 1, player_X] == map_limit)   // 플레이어가 맵 크기 상한선 넘으려 할 때 이동제한
                        {
                            continue;
                        }
                        else if (map[player_Y - 1, player_X] == portal) // 플레이어 포탈 도달시
                        {
                            North_Map();    // North_Map 이동
                            continue;       // 초기로 돌아왔을시 포탈 스왑 방지
                        }

                        Swap(ref map[player_Y, player_X], ref map[player_Y - 1, player_X]);
                        player_Y -= 1;

                        break;

                    // 이후 아래, 양 옆 이동 로직은 같은 메커니즘을 가진다.
                    case ConsoleKey.DownArrow:

                        if (map[player_Y + 1, player_X] == map_limit)
                        {
                            player_Y = map_Size - 2;
                            continue;
                        }
                        else if (map[player_Y + 1, player_X] == portal)
                        {
                            South_Map();    // 플레이어가 아래 방향키 입력으로 포탈 도달시, South_Map 이동
                            continue;       // 초기로 돌아왔을시 포탈 스왑 방지
                        }

                        Swap(ref map[player_Y, player_X], ref map[player_Y + 1, player_X]);
                        player_Y += 1;

                        break;
                    case ConsoleKey.LeftArrow:

                        if (map[player_Y, player_X - 1] == map_limit)
                        {
                            player_X = 1;
                            continue;
                        }
                        else if (map[player_Y, player_X - 1] == portal)
                        {
                            West_Map();
                            continue;
                        }

                        Swap(ref map[player_Y, player_X], ref map[player_Y, player_X - 1]);
                        player_X -= 1;

                        break;
                    case ConsoleKey.RightArrow:

                        if (map[player_Y, player_X + 1] == map_limit)
                        {
                            player_X = map_Size - 2;
                            continue;
                        }
                        else if (map[player_Y, player_X + 1] == portal)
                        {
                            East_Map();
                            continue;
                        }

                        Swap(ref map[player_Y, player_X], ref map[player_Y, player_X + 1]);
                        player_X += 1;

                        break;
                }
                // 맵 내부 플레이어 이동


            }

        }

        // 동서남북 추가 맵
        #region
        static void North_Map()
        {
            string[,] map = new string[20, 20];
            int map_Size = 20;
            string map_ground = "ㅤ";
            string map_limit = "■";

            string player = "★";
            int player_X = map_Size / 2;
            int player_Y = map_Size - 2;

            string portal = "＠";

            for (int y = 0; y < map_Size; y++)
            {
                for (int x = 0; x < map_Size; x++)
                {
                    map[y, x] = map_ground;

                    if (y == map_Size - 1 && x == map_Size / 2)
                    {
                        map[y, x] = portal;
                    }
                    else if (x == 0 || x == map_Size - 1 || y == 0 || y == map_Size - 1)
                    {
                        map[y, x] = map_limit;
                    }
                    else if (x == player_X && y == player_Y)
                    {
                        map[y, x] = player;
                    }

                }
            }

            while (true)
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

                if (user_Arrow.Key == ConsoleKey.UpArrow)
                {

                    if (map[player_Y - 1, player_X] == map_limit)
                    {
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y - 1, player_X]);
                    player_Y -= 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.DownArrow)
                {

                    if (map[player_Y + 1, player_X] == map_limit)
                    {
                        player_Y = map_Size - 2;
                        continue;
                    }
                    else if (map[player_Y + 1, player_X] == portal)
                    {
                        break;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y + 1, player_X]);
                    player_Y += 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.LeftArrow)
                {
                    if (map[player_Y, player_X - 1] == map_limit)
                    {
                        player_X = 1;
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y, player_X - 1]);
                    player_X -= 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.RightArrow)
                {
                    if (map[player_Y, player_X + 1] == map_limit)
                    {
                        player_X = map_Size - 2;
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y, player_X + 1]);
                    player_X += 1;

                    continue;
                }

            }

        }

        static void South_Map()
        {
            string[,] map = new string[20, 20];
            int map_Size = 20;
            string map_ground = "ㅤ";
            string map_limit = "■";

            string player = "★";
            int player_X = map_Size / 2;
            int player_Y = 1;

            string portal = "＠";

            for (int y = 0; y < map_Size; y++)
            {
                for (int x = 0; x < map_Size; x++)
                {
                    map[y, x] = map_ground;

                    if (y == 0 && x == map_Size / 2)
                    {
                        map[y, x] = portal;
                    }
                    else if (x == 0 || x == map_Size - 1 || y == 0 || y == map_Size - 1)
                    {
                        map[y, x] = map_limit;
                    }
                    else if (x == player_X && y == player_Y)
                    {
                        map[y, x] = player;
                    }

                }
            }

            while (true)
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

                if (user_Arrow.Key == ConsoleKey.UpArrow)
                {

                    if (map[player_Y - 1, player_X] == map_limit)
                    {
                        continue;
                    }
                    else if (map[player_Y - 1, player_X] == portal)
                    {
                        break;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y - 1, player_X]);
                    player_Y -= 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.DownArrow)
                {

                    if (map[player_Y + 1, player_X] == map_limit)
                    {
                        player_Y = map_Size - 2;
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y + 1, player_X]);
                    player_Y += 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.LeftArrow)
                {
                    if (map[player_Y, player_X - 1] == map_limit)
                    {
                        player_X = 1;
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y, player_X - 1]);
                    player_X -= 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.RightArrow)
                {
                    if (map[player_Y, player_X + 1] == map_limit)
                    {
                        player_X = map_Size - 2;
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y, player_X + 1]);
                    player_X += 1;

                    continue;
                }

            }

        }

        static void West_Map()
        {
            string[,] map = new string[20, 20];
            int map_Size = 20;
            string map_ground = "ㅤ";
            string map_limit = "■";

            string player = "★";
            int player_X = map_Size - 2;
            int player_Y = map_Size / 2;

            string portal = "＠";

            for (int y = 0; y < map_Size; y++)
            {
                for (int x = 0; x < map_Size; x++)
                {
                    map[y, x] = map_ground;

                    if (y == map_Size / 2 && x == map_Size - 1)
                    {
                        map[y, x] = portal;
                    }
                    else if (x == 0 || x == map_Size - 1 || y == 0 || y == map_Size - 1)
                    {
                        map[y, x] = map_limit;
                    }
                    else if (x == player_X && y == player_Y)
                    {
                        map[y, x] = player;
                    }

                }
            }

            while (true)
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

                if (user_Arrow.Key == ConsoleKey.UpArrow)
                {

                    if (map[player_Y - 1, player_X] == map_limit)
                    {
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y - 1, player_X]);
                    player_Y -= 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.DownArrow)
                {

                    if (map[player_Y + 1, player_X] == map_limit)
                    {
                        player_Y = map_Size - 2;
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y + 1, player_X]);
                    player_Y += 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.LeftArrow)
                {
                    if (map[player_Y, player_X - 1] == map_limit)
                    {
                        player_X = 1;
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y, player_X - 1]);
                    player_X -= 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.RightArrow)
                {
                    if (map[player_Y, player_X + 1] == map_limit)
                    {
                        player_X = map_Size - 2;
                        continue;
                    }
                    else if (map[player_Y, player_X + 1] == portal)
                    {
                        break;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y, player_X + 1]);
                    player_X += 1;

                    continue;
                }

            }

        }

        static void East_Map()
        {
            string[,] map = new string[20, 20];
            int map_Size = 20;
            string map_ground = "ㅤ";
            string map_limit = "■";

            string player = "★";
            int player_X = 1;
            int player_Y = map_Size / 2;

            string portal = "＠";

            for (int y = 0; y < map_Size; y++)
            {
                for (int x = 0; x < map_Size; x++)
                {
                    map[y, x] = map_ground;

                    if (y == map_Size / 2 && x == 0)
                    {
                        map[y, x] = portal;
                    }
                    else if (x == 0 || x == map_Size - 1 || y == 0 || y == map_Size - 1)
                    {
                        map[y, x] = map_limit;
                    }
                    else if (x == player_X && y == player_Y)
                    {
                        map[y, x] = player;
                    }

                }
            }

            while (true)
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

                if (user_Arrow.Key == ConsoleKey.UpArrow)
                {

                    if (map[player_Y - 1, player_X] == map_limit)
                    {
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y - 1, player_X]);
                    player_Y -= 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.DownArrow)
                {

                    if (map[player_Y + 1, player_X] == map_limit)
                    {
                        player_Y = map_Size - 2;
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y + 1, player_X]);
                    player_Y += 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.LeftArrow)
                {
                    if (map[player_Y, player_X - 1] == map_limit)
                    {
                        player_X = 1;
                        continue;
                    }
                    else if (map[player_Y, player_X - 1] == portal)
                    {
                        break;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y, player_X - 1]);
                    player_X -= 1;

                    continue;
                }
                else if (user_Arrow.Key == ConsoleKey.RightArrow)
                {
                    if (map[player_Y, player_X + 1] == map_limit)
                    {
                        player_X = map_Size - 2;
                        continue;
                    }


                    Swap(ref map[player_Y, player_X], ref map[player_Y, player_X + 1]);
                    player_X += 1;

                    continue;
                }

            }

        }

        #endregion
        static void Swap(ref string first, ref string second)
        {
            string temp = "\0";
            temp = first;
            first = second;
            second = temp;
        }
    }
}