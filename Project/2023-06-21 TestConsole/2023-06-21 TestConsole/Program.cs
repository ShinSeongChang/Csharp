using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_21_TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract형은 인스턴스화 불가능
            //Clickable clickableObject = new Clickable();
            Button clickableObject = new Button();
            clickableObject.ClickThisObject(true);
            //TestFunc001();
        }

        // 함수에는 타인이 읽을 수 있도록 설명을 추가할 수 있다.
        // 2가지 방법 소개 할거임.
        // 1 가지 방법은 attribute 기능을 사용한 설명 추가.

        [Obsolete("\n이 함수는 아무런 기능이 없는 테스트 함수입니다.")]

        static void TestFunc001()
        {
            Console.WriteLine("함수 콜");
        }


        /// <summary>
        /// 이 함수는 매개변수를 하나 받아서 출력하는 함수입니다.
        /// </summary>
        /// <param name="descStr">이 변수는 문자열로 이루어진 설명을 받아서 저장하는 변수</param>
        static void DescFunc001_void(string descStr)
        {
            Console.WriteLine("함수 콜, 매개변수 -> {0}", descStr);
        }

        /// <summary>
        /// 이 함수는 매개변수를 하나 받아서 출력하는 함수입니다.
        /// </summary>
        /// <param name="descStr">이 변수는 문자열로 이루어진 설명을 받아서 저장하는 변수</param>
        /// <returns>함수가 정상 동작했을 때 true를 리턴합니다.</returns>
        static bool DescFunc001_return(string descStr)
        {
            Console.WriteLine("함수 콜, 매개변수 -> {0}", descStr);
            return true;
        }
            
    }
}
