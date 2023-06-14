using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole004
{
    public static class Print002   // 클래스의 접근 수준이 Public
    {
        private static string message = default;

        public static void PrintMesage(string localMessage)     // 메서드의 접근 수준이 Public
        {
            message = localMessage;
            Console.WriteLine("이런걸 출력할 것 -> {0}", message);

            // PrintMesage()
        }
    }
}