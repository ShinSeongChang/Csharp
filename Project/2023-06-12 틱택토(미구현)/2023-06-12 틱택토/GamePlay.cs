using System;

namespace _2023_06_12_틱택토
{
    public class GamePlay
    {
        public void Gameplay()
        {

            string[,] board = new string[3, 3];

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    board[y, x] = "■ ";
                    Console.Write("{0}", board[y, x]);
                }

                Console.WriteLine("");
            }

            int userinput = 0;
            string str;


           
         while(true)
            {   
                int a = -1;
                int[] count = new int[9];
                for(int i = 0; i< 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        a++;

                        if (board[i, j] != "0  " && board[i, j] != "X  ")
                        {
                            
                             count[count.Length-1] = a;
                            
                            break;
                        }
                        

                    }

                }
              
                str = Console.ReadLine();
                userinput =int.Parse(str);

                switch(userinput)
                {
                    case 1:
                        board[0, 0] = "X  ";
                        break;
                    case 2:
                        board[0, 1] = "X  ";
                        break;
                    case 3:
                        board[0, 2] = "X  ";
                        break;
                    case 4:
                        board[1, 0] = "X  ";
                        break;
                    case 5:
                        board[1, 1] = "X  ";
                        break;
                    case 6:
                        board[1, 2] = "X  ";
                        break;
                    case 7:
                        board[2, 0] = "X  ";
                        break;
                    case 8:
                        board[2, 1] = "X  ";
                        break;
                    case 9:
                        board[2, 2] = "X  ";
                        break;     

                }
                
                while (true){
                    Random rand = new Random();
                    int x = rand.Next(0, 3);
                    int y = rand.Next(0, 3);
                   
                    if (board[x, y] != "0  " && board[x, y] != "X  ")
                    {
                        board[x, y]= "0  ";
                        break;
                    }
                   

                }
              



                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        
                        Console.Write("{0}", board[y, x]);
                    }

                    Console.WriteLine("");
                }

            }


        }

    }
}
