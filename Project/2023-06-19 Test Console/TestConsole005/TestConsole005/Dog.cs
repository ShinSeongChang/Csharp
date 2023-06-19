using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole005
{
    public partial class Dog
    {
        // partial : 클래스를 다른 파일로 나눠서 사용하는 기능이다.


        public void PrintAnotherThings()
        {
            Console.WriteLine("파일을 2개로 나누었다." +
                "정말로 Dog 클래스에서 이 함수를 call할 수 있을까?");
        }
    }
}
