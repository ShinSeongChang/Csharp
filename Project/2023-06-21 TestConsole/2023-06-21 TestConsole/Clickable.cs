using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_21_TestConsole
{
    // 무언가 클릭이 가능한 오브젝트를 만들고 싶을 때 사용할 클래스임.
    abstract public class Clickable
    {
        bool isClickOk = false;

        public void ClickThisObject(bool isClick_)
        {
            isClickOk = isClick_;

            Console.WriteLine("당신은 이 오브젝트를 클릭했습니다.");
        }
    }
}
