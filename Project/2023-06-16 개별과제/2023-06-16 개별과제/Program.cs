using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_16_개별과제
{
    // 콘솔 맵에서 매 턴 랜덤한 곳에 숫자 1이 등장한다.
    // 방향키 중 오른쪽 키(혹은 D) 를 입력하면 맵에 존재하는 모든 1이 오른쪽 끝으로 이동한다.
    // 만약, 오른쪽 끝에 이미 1이 있는 경우 1이 더해진다.

    internal class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo user_Key = default;

            int[,] background = new int[10, 10];
            int randomnum = 1;
            int randomnum_x = 0;
            int randomnum_y = 0;




            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    background[y, x] = 0;

                    //if (x == randomnum_x && y == randomnum_y)
                    //{
                    //    background[y, x] = randomnum;
                    //}     필요 없음 

                }

            }


            while (true)
            {
                int loop_count = 0;


                //Console.SetCursorPosition(0, 0);

                user_Key = Console.ReadKey(true);

                Console.Clear();

                int result = 0;
                int sum = 0;          //준오

                if (user_Key.KeyChar == 'd' || user_Key.KeyChar == 'D')
                {
                    //for (int i = 0; i < 10; i++)
                    //{
                    //    for (int j = 0; j < 10; j++)
                    //    {
                    //        if (background[i, j] != 0)
                    //        {
                    //            result += background[i, j];
                    //            background[i, j] = 0;
                    //        }


                    //    }

                    //    background[i, 9] = result;
                    //    result = 0;
                    //}


                    for (int y = 0; y < 9; y++)
                    {
                        for (int x = 0; x < 9; x++)
                        {
                            if (background[y, x] != 0)
                            {
                                result = background[y, 9];
                                result += background[y, x];

                                background[y, x] = 0;
                                background[y, 9] = result;

                            }
                        }


                    }
                }

                else if(user_Key.KeyChar == 's' || user_Key.KeyChar == 'S')`
                {
                    for(int y =0;y < 9;y++)
                    {
                        for(int x =0; x < 9 ; x++)
                        {
                            if (background[y, x] != 0)
                            {
                                result = background[9, x];
                                result += background[y, x];

                                background[y, x] = 0;
                                background[9, x] = result;
                            }
                        }
                    }

                }

                Random random = new Random();

                while (loop_count < 3)
                {
                    randomnum_x = random.Next(0, 9);
                    randomnum_y = random.Next(0, 9);



                    if (background[randomnum_y, randomnum_x] != randomnum)
                    {
                        loop_count++;
                        background[randomnum_y, randomnum_x] = randomnum;
                    }
                }

                for (int y = 0; y < 10; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        Console.Write(" {0} ", background[y, x]);
                    }

                    Console.WriteLine();
                    Console.WriteLine();

                }

                


            }

        }

        static void Swap(ref int first, ref int second)
        {
            int temp = default;
            temp = first;
            first = second;
            second = temp;
        }
    }
}
