using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 과제_쪼개기
{
    public class Map
    {
        string[,] map = new string[26, 30];
        int map_size_X = 30;
        int map_size_Y = 26;

        string map_ground = "ㅤ";

        string map_limit = "■";

        string player = "★";
        int player_X = 15;
        int player_Y = 13;

        string npc = "§";
        int npc_X = 5;
        int npc_Y = 15;

        int quest_count = 0;
        int quest = 0;
        int quest_Max = 5;

        string bush = "※";

        int random_Battle = 0;

        public void Create_Map()
        {
            for (int y = 0; y < map_size_Y; y++)
            {
                for (int x = 0; x < map_size_X; x++)
                {
                    map[y, x] = map_ground;

                    if ((x == 0 || x == map_size_X - 1) || (y == 0 || y == map_size_Y - 1))
                    {
                        map[y, x] = map_limit;
                    }
                    else if (x == player_X && y == player_Y)
                    {
                        map[y, x] = player;
                    }
                    else if (x == npc_X && y == npc_Y)
                    {
                        map[y, x] = npc;
                    }
                    else if ((y >= 2 && y <= 9) && (x >= 18 && x <= 25))
                    {
                        map[y, x] = bush;
                    }

                }
            }
        }

        public void Draw_Map()
        {
            Random rand = new Random();
            PlayBattle battle = new PlayBattle();


            while (true)
            {
                // 맵 출력
                Console.SetCursorPosition(0, 0);    // 화면 좌표 고정  

                for (int y = 0; y < map_size_Y; y++)
                {
                    for (int x = 0; x < map_size_X; x++)
                    {
                        Console.Write(map[y, x]);

                        if (y == 9 && x == map_size_X - 1)
                        {

                        }
                    }
                    Console.WriteLine();

                }
                // 맵 출력




                // 유저 이동 로직
                ConsoleKeyInfo user_Key = Console.ReadKey();

                switch (user_Key.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        if (map[player_Y - 1, player_X] == map_limit)       // 유저가 이동할 칸이 벽이라면 입력값을 넘긴다.
                        {
                            break;
                        }
                        else if (map[player_Y - 1, player_X] == npc)         // 유저가 이동할 칸이 npc 라면
                        {                                                   // 퀘스트를 수락했다는 문구를 맵과 함께 새로 그려준 뒤
                            quest_count++;                                  // 입력값을 넘긴다.
                            Console.SetCursorPosition(0, 0);

                            for (int y = 0; y < map_size_Y; y++)
                            {
                                for (int x = 0; x < map_size_X; x++)
                                {
                                    Console.Write(map[y, x]);

                                    if (y == 9 && x == map_size_X - 1)
                                    {
                                        Console.Write("\t\t\t 퀘스트 수락");
                                    }
                                }
                                Console.WriteLine();

                            }
                            break;
                        }

                        // npc와 벽을 제외한 상황이면 유저는 한칸 이동한다.

                        Swap(ref map[player_Y, player_X], ref map[player_Y - 1, player_X]);
                        player_Y -= 1;

                        // 하지만 한칸 이동한곳이 부쉬 일시
                        // 부쉬 출입시 스왑 방지 로직
                        if (map[player_Y, player_X] == map[9, player_X] && (player_X >= 18 && player_X <= 25))
                        {
                            map[player_Y + 1, player_X] = map_ground;
                            break;
                        }
                        else if (map[player_Y, player_X] == map[1, player_X] && (player_X >= 18 && player_X <= 25))
                        {
                            map[player_Y + 1, player_X] = bush;
                            break;
                        }
                        // 부쉬 출입시 스왑 방지 로직

                        break;
                    // 이후 나머지 3방향 이동키는 같은 메커니즘을 가진다.
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        if (map[player_Y + 1, player_X] == map_limit)
                        {
                            break;
                        }
                        else if (map[player_Y + 1, player_X] == npc)
                        {
                            quest_count++;
                            Console.SetCursorPosition(0, 0);

                            for (int y = 0; y < map_size_Y; y++)
                            {
                                for (int x = 0; x < map_size_X; x++)
                                {
                                    Console.Write(map[y, x]);

                                    if (y == 9 && x == map_size_X - 1)
                                    {
                                        Console.Write("\t\t\t 퀘스트 수락");
                                    }
                                }
                                Console.WriteLine();

                            }

                            break;
                        }

                        Swap(ref map[player_Y, player_X], ref map[player_Y + 1, player_X]);
                        player_Y += 1;

                        if (map[player_Y, player_X] == map[2, player_X] && (player_X >= 18 && player_X <= 25))
                        {
                            map[player_Y - 1, player_X] = map_ground;
                            break;
                        }
                        else if (map[player_Y, player_X] == map[10, player_X] && (player_X >= 18 && player_X <= 25))
                        {
                            map[player_Y - 1, player_X] = bush;
                            break;
                        }
                        break;

                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        if (map[player_Y, player_X - 1] == map_limit)
                        {
                            break;
                        }
                        else if (map[player_Y, player_X - 1] == npc)
                        {
                            quest_count++;

                            Console.SetCursorPosition(0, 0);

                            for (int y = 0; y < map_size_Y; y++)
                            {
                                for (int x = 0; x < map_size_X; x++)
                                {
                                    Console.Write(map[y, x]);

                                    if (y == 9 && x == map_size_X - 1)
                                    {
                                        Console.Write("\t\t\t 퀘스트 수락");
                                    }
                                }
                                Console.WriteLine();

                            }

                            break;
                        }

                        Swap(ref map[player_Y, player_X], ref map[player_Y, player_X - 1]);
                        player_X -= 1;

                        if (map[player_Y, player_X] == map[player_Y, 25] && (player_Y >= 2 && player_Y <= 9))
                        {
                            map[player_Y, player_X + 1] = map_ground;
                            break;
                        }
                        else if (map[player_Y, player_X] == map[player_Y, 17] && (player_Y >= 2 && player_Y <= 9))
                        {
                            map[player_Y, player_X + 1] = bush;
                            break;
                        }

                        break;

                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        if (map[player_Y, player_X + 1] == map_limit)
                        {
                            break;
                        }
                        else if (map[player_Y, player_X + 1] == npc)
                        {
                            quest_count++;
                            Console.SetCursorPosition(0, 0);

                            for (int y = 0; y < map_size_Y; y++)
                            {
                                for (int x = 0; x < map_size_X; x++)
                                {
                                    Console.Write(map[y, x]);

                                    if (y == 9 && x == map_size_X - 1)
                                    {
                                        Console.Write("\t\t\t 퀘스트 수락");
                                    }
                                }
                                Console.WriteLine();

                            }

                            break;
                        }
                        Swap(ref map[player_Y, player_X], ref map[player_Y, player_X + 1]);
                        player_X += 1;

                        if (map[player_Y, player_X] == map[player_Y, 18] && (player_Y >= 2 && player_Y <= 9))
                        {
                            map[player_Y, player_X - 1] = map_ground;
                            break;
                        }
                        else if (map[player_Y, player_X] == map[player_Y, 26] && (player_Y >= 2 && player_Y <= 9))
                        {
                            map[player_Y, player_X - 1] = bush;
                            break;
                        }
                        break;

                }
                // 유저 이동 로직               


                for (int y = 2; y < 9; y++)
                {
                    for (int x = 18; x < 25; x++)
                    {
                        if (map[y, x] == player)    // 부쉬좌표에 플레이어가 존재하며, random_Battle 확률 36퍼 달성시
                        {
                            random_Battle = rand.Next(0, 100);

                            Console.WriteLine("주사위 값 : {0}", random_Battle);

                            if (random_Battle < 18 && quest_count >= 1)
                            {
                                Console.WriteLine("전투 발생");
                                Console.WriteLine("퀘스트 진행도 : {0} / {1}", quest, quest_Max);
                                Thread.Sleep(1000);

                                battle.Play_Battle();

                                ++quest;
                                Console.WriteLine("퀘스트 진행도 : {0} / {1}", quest, quest_Max);

                            }
                            else if (random_Battle < 18)
                            {
                                Console.WriteLine("전투 발생");
                                Thread.Sleep(1000);

                                battle.Play_Battle();

                            }

                        }
                    }
                }

                if (quest == quest_Max)
                {
                    quest = 0;
                    quest_count = 0;
                    Console.WriteLine("퀘스트 클리어");

                    Thread.Sleep(1000);
                }



            }
            // 메인 반복문 종료부

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
