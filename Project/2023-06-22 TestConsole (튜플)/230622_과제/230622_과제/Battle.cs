using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _230622_과제
{
    public class Battle
    {
        public void Play_Battle()
        {
            Random random = new Random();

            int player_Hp = 100;
            int player_Max_Hp = 100;
            int player_Atk = 150;
            int monster_HP = 150;
            int monster_Atk = 10;
            int gameturn = 0;
            int critcal_chance = 0;
            int critical_damage = player_Atk * 2;
            int heal_chance = 0;
            int heal = 20;

            Console.Clear();

            Console.WriteLine("몬스터와 조우 했습니다.");
            Console.WriteLine("도망칠수 없습니다...");
            Thread.Sleep(1000);
            Console.Clear();

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("\t몬스터   체력 : {0,3} \t 공격력 : {1,3}", monster_HP, monster_Atk);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t플레이어 체력 : {0,3} \t 공격력 : {1,3}", player_Hp, player_Atk);

                if (gameturn % 2 == 0)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    player_Hp -= monster_Atk;

                    Console.WriteLine("\t몬스터   체력 : {0,3} \t 공격력 : {1,3}", monster_HP, monster_Atk);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t몬스터에게 공격을 받습니다. ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t플레이어 체력 : {0,3} \t 공격력 : {1,3}", player_Hp, player_Atk);

                    Thread.Sleep(1000);

                }
                else
                {
                    critcal_chance = random.Next(0, 10);
                    heal_chance = random.Next(0, 10);

                    if (critcal_chance < 5)
                    {
                        Console.Clear();
                        monster_HP -= critical_damage;

                        Console.WriteLine("\t몬스터   체력 : {0,3} \t 공격력 : {1,3}", monster_HP, monster_Atk);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t크리티컬 발생! 두배의 데미지를 가합니다.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t플레이어 체력 : {0,3} \t 공격력 : {1,3}", player_Hp, player_Atk);

                        Thread.Sleep(1000);


                        if (monster_HP <= 0)
                        {
                            monster_HP = 0;

                            Console.Clear();

                            Console.WriteLine("\t몬스터   체력 : {0,3} \t 공격력 : {1,3}", monster_HP, monster_Atk);
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("\t 전투 승리! 마을로 돌아갑니다...");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("\t플레이어 체력 : {0,3} \t 공격력 : {1,3}", player_Hp, player_Atk);

                            Thread.Sleep(1000);
                            break;
                        }

                        gameturn++;
                        continue;
                    }


                    if (heal_chance < 3)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        player_Hp += heal;

                        if (player_Hp >= player_Max_Hp)
                        {
                            player_Hp = player_Max_Hp;
                        }

                        Console.WriteLine("\t몬스터   체력 : {0,3} \t 공격력 : {1,3}", monster_HP, monster_Atk);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t회복 스킬발생... 플레이어가 회복합니다.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t플레이어 체력 : {0,3} \t 공격력 : {1,3}", player_Hp, player_Atk);

                        Thread.Sleep(1000);

                    }


                    Console.Clear();
                    Console.SetCursorPosition(0, 0);

                    monster_HP -= player_Atk;

                    Console.WriteLine("\t몬스터   체력 : {0,3} \t 공격력 : {1,3}", monster_HP, monster_Atk);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t플레이어가 공격 합니다.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t플레이어 체력 : {0,3} \t 공격력 : {1,3}", player_Hp, player_Atk);

                    Thread.Sleep(1000);

                    if (monster_HP <= 0)
                    {
                        monster_HP = 0;

                        Console.Clear();

                        Console.WriteLine("\t몬스터   체력 : {0,3} \t 공격력 : {1,3}", monster_HP, monster_Atk);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t 전투 승리! 마을로 돌아갑니다...");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t플레이어 체력 : {0,3} \t 공격력 : {1,3}", player_Hp, player_Atk);

                        Thread.Sleep(1000);
                        break;
                    }

                }

                gameturn++;
            }
        }
    }
}
