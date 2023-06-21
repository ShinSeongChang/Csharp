using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<int> enumy_X = new List<int>();

            List<int> enumy_Y = new List<int>();

            string[,] map = new string[28, 40];
            int map_Y_Size = 28;
            int map_X_Size = 40;
            string map_ground = "ㅤ";
            string map_limit = "■";

            int wall_Count = 0;
            int random_Wall_X = 0;
            int random_Wall_Y = 0;

            string player = "★";
            int player_X = map_X_Size / 2;
            int player_Y = map_Y_Size / 2;

            string enumy = "＠";
            int random_Enumy_X = 0;
            int random_Enumy_Y = 0;

            int moove_Count = 0;


            for (int y = 0; y < map_Y_Size; y++)
            {
                for (int x = 0; x < map_X_Size; x++)
                {
                    map[y, x] = map_ground;

                    if (x == 0 || x == map_X_Size - 1 || y == 0 || y == map_Y_Size - 1)
                    {
                        map[y, x] = map_limit;
                    }
                    else if (x == player_X && y == player_Y)
                    {
                        map[y, x] = player;
                    }


                }
            }


            // 랜덤 벽 생성 로직
            while (wall_Count < 100)
            {
                random_Wall_X = rnd.Next(1, map_X_Size - 2);
                random_Wall_Y = rnd.Next(1, map_Y_Size - 2);

                while (map[random_Wall_Y, random_Wall_X] == player || map[random_Wall_Y, random_Wall_X] == map_limit)
                {
                    random_Wall_X = rnd.Next(1, map_X_Size - 2);
                    random_Wall_Y = rnd.Next(1, map_Y_Size - 2);

                }

                map[random_Wall_Y, random_Wall_X] = map_limit;
                wall_Count++;

            }
            // 랜덤 벽 생성

            // 게임 진행부분

            while (map[player_Y,player_X] != enumy)
            {

                Console.SetCursorPosition(0, 0);

                for (int y = 0; y < map_Y_Size; ++y)
                {
                    for (int x = 0; x < map_X_Size; x++)
                    {
                        Console.Write(map[y, x]);
                    }
                    Console.WriteLine();
                }

                //플레이어 이동

                ConsoleKeyInfo user_Arrow = Console.ReadKey();
                if (user_Arrow.Key == ConsoleKey.UpArrow)
                {

                    if (map[player_Y - 1, player_X] == map_limit)   // 플레이어가 맵 크기 상한선 넘으려 할 때 이동제한
                    {
                        continue;
                    }
                    else if (map[player_Y - 1, player_X] == enumy)
                    {
                        break;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y - 1, player_X]);
                    player_Y -= 1;
                    moove_Count++;

                }
                else if (user_Arrow.Key == ConsoleKey.DownArrow)
                {

                    if (map[player_Y + 1, player_X] == map_limit)
                    {
                        continue;
                    }
                    else if (map[player_Y + 1, player_X] == enumy)
                    {
                        continue;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y + 1, player_X]);
                    player_Y += 1;
                    moove_Count++;

                }
                else if (user_Arrow.Key == ConsoleKey.LeftArrow)
                {

                    if (map[player_Y, player_X - 1] == map_limit)
                    {
                        continue;
                    }
                    else if (map[player_Y, player_X - 1] == enumy)
                    {
                        break;
                    }


                    Swap(ref map[player_Y, player_X], ref map[player_Y, player_X - 1]);
                    player_X -= 1;
                    moove_Count++;

                }
                else if (user_Arrow.Key == ConsoleKey.RightArrow)
                {
                    if (map[player_Y, player_X + 1] == map_limit)
                    {
                        continue;
                    }
                    else if (map[player_Y, player_X + 1] == enumy)
                    {
                        break;
                    }

                    Swap(ref map[player_Y, player_X], ref map[player_Y, player_X + 1]);
                    player_X += 1;

                }
                // 플레이어 이동

                moove_Count++;

                // 랜덤 적 생성                
                if (moove_Count % 7 == 0)
                {
                    while (true)
                    {
                        random_Enumy_X = rnd.Next(1, map_X_Size - 2);
                        random_Enumy_Y = rnd.Next(1, map_Y_Size - 2);

                        if (map[random_Enumy_Y, random_Enumy_X] != player && map[random_Enumy_Y, random_Enumy_X] != map_limit)
                        {
                            enumy_X.Add(random_Enumy_X);
                            enumy_Y.Add(random_Enumy_Y);

                            map[random_Enumy_Y, random_Enumy_X] = enumy;
                            break;
                        }

                    }

                }
                // 랜덤 적 생성


                for (int i = 0; i < enumy_X.Count; i++)
                {
                    if (enumy_Y[i] != player_Y)
                    {
                        if (enumy_Y[i] < player_Y)
                        {
                            if (map[enumy_Y[i] + 1, enumy_X[i]] == map_limit)
                            {
                                continue;
                            }
    

                            Swap(ref map[enumy_Y[i], enumy_X[i]], ref map[enumy_Y[i] + 1, enumy_X[i]]);
                            enumy_Y[i] += 1;
                        }
                        else if (enumy_Y[i] > player_Y)
                        {
                            if (map[enumy_Y[i] - 1, enumy_X[i]] == map_limit || map[enumy_Y[i] - 1, enumy_X[i]] == enumy)
                            {
                                continue;
                            }

                            Swap(ref map[enumy_Y[i], enumy_X[i]], ref map[enumy_Y[i] - 1, enumy_X[i]]);
                            enumy_Y[i] -= 1;
                        }

                    }
                    else if (enumy_X[i] != player_X)
                    {

                        if (enumy_X[i] < player_X)
                        {
                            if (map[enumy_Y[i], enumy_X[i] + 1] == map_limit || map[enumy_Y[i], enumy_X[i] + 1] == enumy)
                            {
                                continue;
                            }


                            Swap(ref map[enumy_Y[i], enumy_X[i]], ref map[enumy_Y[i], enumy_X[i] + 1]);
                            enumy_X[i] += 1;
                        }
                        else if (enumy_X[i] > player_X)
                        {
                            if (map[enumy_Y[i], enumy_X[i] - 1] == map_limit || map[enumy_Y[i], enumy_X[i] - 1] == enumy)
                            {
                                continue;
                            }


                            Swap(ref map[enumy_Y[i], enumy_X[i]], ref map[enumy_Y[i], enumy_X[i] - 1]);
                            enumy_X[i] -= 1;
                        }
                    }
                }

                for(int i = 0; i < enumy_X.Count; i++)
                {
                    if(player_Y == enumy_Y[i] && player_X == enumy_X[i])
                    {
                        return;
                    }
                }


            }
            // 게임 진행 부분


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

