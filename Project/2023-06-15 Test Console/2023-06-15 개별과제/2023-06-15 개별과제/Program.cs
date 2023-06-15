using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_15_개별과제
{   // 플레이어로부터 사이즈를 입력받아서 해당 사이즈 크기만큼 콘솔맵을 구현한다.
    // 플레이어는 w, a, s, d 방향을 입력 받아서 콘솔 맵 안을 자유롭게 움직일 수 있다.
    // 콘솔 맵에는 일정 시간 or 일정 움직임 마다 돌 3개가 등장한다. (한 맵에 돌은 최대 3개까지 존재할 수 있다.)
    // 플레이어는 돌을 밀 수 있다.
            // - 한번 민 돌은 해당 방향으로 끝까지 쭉 밀린다.
            // - 어떤 방향으로든 돌이 연속으로 3개가 붙어 있을 경우 돌은 사라지고, 점수가 올라간다.
    // 플레이어가 일정 점수를 획득하면 게임을 종료한다.
    // R 키를 눌러서 돌의 위치, 플레이어의 위치, 점수를 초기화 한다.

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
            string[,] background = new string [100,100];            

            Console.WriteLine("     맵 사이즈를 입력해주세요 : ");
            userinput = Console.ReadLine();

            Console.Clear();

            int.TryParse(userinput, out useroutput);

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
                for (int y = 0; y < useroutput; y++)
                {
                    for (int x = 0; x < useroutput; x++)
                    {
                        Console.Write("{0}", background[y, x]);
                    }

                    Console.WriteLine();
                }


            square_limit:

                userKey = Console.ReadKey(true);

                if(userKey.KeyChar == 'w' || userKey.KeyChar == 'W')
                {                    
                    if(player_y <=0)
                    {
                        player_y = 0;
                        goto square_limit;
                    }


                    if (background[player_y -1,player_x] == "#  ")
                    {
                        Swap(ref background[player_y -1, player_x], ref background[0, player_x]);
                    }


                    Swap(ref background[player_y, player_x], ref background[player_y - 1, player_x]);
                    player_y -= 1;

                }

                else if (userKey.KeyChar == 's' || userKey.KeyChar == 'S')
                {
                    if (player_y >= useroutput -1)
                    {
                        player_y = useroutput - 1;
                        goto square_limit;
                    }

                    if (background[player_y + 1, player_x] == "#  ")
                    {
                        Swap(ref background[player_y + 1, player_x], ref background[useroutput -1 , player_x]);
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

                    if (background[player_y, player_x -1 ] == "#  ")
                    {
                        Swap(ref background[player_y, player_x -1 ], ref background[player_y, 0]);
                    }

                    Swap(ref background[player_y, player_x], ref background[player_y , player_x -1]);
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
                        Swap(ref background[player_y, player_x + 1], ref background[player_y, useroutput - 1]);
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

                    while (background[rock_y,rock_x] == background[player_y,player_x])
                    {
                        rock_x = random.Next(0, useroutput - 1);
                        rock_y = random.Next(0, useroutput - 1);
                        break;
                    }

                    background[rock_y, rock_x] = "#  ";

                    movecount = 0;
                    rock += 1;
                }
                
                Console.SetCursorPosition(0, 0);
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
