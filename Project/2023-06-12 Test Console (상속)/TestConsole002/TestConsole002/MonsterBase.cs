using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole002
{
    public class MonsterBase
    {
        // 캡슐화 -> 필드를 private 로 처리해서 외부에서 접근 불가능하도록 하겠다는 의미.
        // protected는 상속받은 자식 클래스에서는 쓸 수 있도록 하겠다는 의미.

        protected string name;
        protected int hp;
        protected int mp;
        protected int damage;
        protected int defence;
        protected string type;

        public virtual void Initilize(string name, int hp, int mp, int damage, int defence, string type)
        {
            this.name = name;
            this.hp = hp;
            this.mp = mp;
            this.damage = damage;
            this.defence = defence;
            this.type = type;
        }

        public virtual void Print_MonsterInfo()
        {
            Console.WriteLine(" 몬스터 등장 ");
            Console.WriteLine();
            Console.WriteLine("이름 : {0}          타입 : {1}", name, type);
            Console.WriteLine("체력 : {0}   마나 : {1}  공격력 : {2}  방어력 : {3}",
                hp, mp, damage, defence);
            Console.WriteLine();
            Console.WriteLine();
        }




    }
}
