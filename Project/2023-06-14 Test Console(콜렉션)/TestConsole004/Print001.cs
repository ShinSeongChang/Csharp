using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole004
{
    public class Print001   // 클래스의 접근 수준이 Public
    {
        public static string staticmasaage = default;
        private string message = "인스턴스 필드에 미리 넣어둔 값";

        public void PrintMessage(string localMesage)     // 메서드의 접근 수준이 Public
        {
            message = localMesage;
            Console.WriteLine("이런걸 출력할 것 -> {0}", message);

            // PrintMesage()
        }

        public void PrintMessage()
        {
            Print002.PrintMesage("Print002를 더 늦게 만들었는데 이게 왜 되지?");
        }

        public void PrintMesaage()
        {
            Console.WriteLine("Static 메서드에서 인스턴스 필드를 찍어볼 수 있을까? -> {0}", message);
        }
    }
}
