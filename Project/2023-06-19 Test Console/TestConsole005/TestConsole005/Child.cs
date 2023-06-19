using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole005
{
    public class Child : Parent
    {

        string strChild = default;

        public override void PrintInfos()
        {
            //base.PrintInfos();

            // base. 는 부모클래스것을 사용하겠다는 것.


            number = 10;
            strValue = "This is Child";
            strChild = "Sentences of child added";

            Console.WriteLine("child class -> number : {0}, strValue : {1}, strChild : {2}",
                this.number, this.strValue, this.strChild);

            // this. 는 나의 것을 사용하겠다는 것.
        }
    }

}
