using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole002
{
    public class Skeletone : MonsterBase
    {
        //public string skeletoneName = "해골병사";
        //public int skeletoneHp = 60;
        //public int skeletoneMp = 10;
        //public int skeletoneDamage = 30;
        //public int skeletoneDefence = 2;
        //public string skeletoneType = "UNDEAD";

        //public void override Initilize(string name, int hp, int mp, int damage, int defence, string type)
        //{
        //    this.name = name;
        //    this.hp = hp;
        //    this.mp = mp;
        //    this.damage = damage;
        //    this.defence = defence;
        //    this.type = type;
        //}

        //public override 
  
        //public void print_Skeletone()
        //{
        //    Console.WriteLine(" 몬스터 등장 ");
        //    Console.WriteLine();
        //    Console.WriteLine("이름 : {0}          타입 : {1}", name, type);
        //    Console.WriteLine("체력 : {0}   마나 : {1}  공격력 : {2}  방어력 : {3}",
        //        hp, mp, damage, defence);
        //    Console.WriteLine();
        //    Console.WriteLine();

        //}

        public void Print_OverloadingTest()
        {
            Console.WriteLine("함수 찍힌다.");
        }
    }
}
