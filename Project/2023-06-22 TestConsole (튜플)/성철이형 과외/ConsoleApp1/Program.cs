using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//아직 인스턴트화 되지 않았다.
            MoveSomething move;
            
                
            //이제 인스턴트화 되었다.(new)
            move = new MoveSomething();
            
            move.x = 1;

            
*/
            /* 클래스의 생성과정
            MoveSomething.TestMetod();
            실행 exe = new 실행();
            exe.Play();
            */

            //Child childs = new Child();
            //childs.ChildPrint();

            Parent parent = new Parent("부모");
            parent = new Child("자식");

            Child child1 = (Child)parent;//골렘ㅇㄹ 만ㄷㄴ다는것은 ㅁ엇일ㅋ까

            Parent parent2 = new Parent("");
            parent2 = new Child("is 사용법");
            Child child2 = (Child)parent2;

            child2.PrintParent("두번째 부모 인스턴스에서 생성된 자식입니다.");


            if(parent2 is Child)
            {
                Console.WriteLine("parent2는 자식클래스 객체를 담고 있음");
            }

            Parent parent3 = new Parent("");

            Child child3 = parent3 as Child;

            if (child3 != null) { Console.WriteLine("null이 아님"); }
            else { Console.WriteLine("null이 들어감 "); }

            //child2.ChildPrint();


        }

        static void Pritnt()
        {
            Console.WriteLine("Nullable");
        }
    }
}
