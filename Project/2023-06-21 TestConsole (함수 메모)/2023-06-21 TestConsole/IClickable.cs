using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_21_TestConsole
{
     public interface IClickable
    {
        // 인터페이스를 생성하고 다른클래스에 상속시켜주면
        // 그 클래스는 인터페이스의 구현된 함수를 강제 하는 것 ( 해당 함수들을 무조건 사용해야 한다 )
        void ClickThisObject(bool isClick_);
  
    }

}
