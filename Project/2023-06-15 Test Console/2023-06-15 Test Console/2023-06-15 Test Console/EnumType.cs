using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_15_Test_Console
{
    enum ItemType_SC        // 상수를 모아놓은 (int형 정수) 
    {
        POTION, GOLD, WEAPON, ARMOR

        // 앞에서부터 [0] ~ [3] 의 주소값을 할당받음
        // POTION = 1 을 부여하면 [1]부터 순차적으로 주소값이 할당된다.
        // POTION =1 , GOLD [3] 식으로 주소값을 할당하면 [2] 주소는 존재하지 않고 [3] 부터 순차적으로 주소를 부여한다.
        // 1_0000_0000 == 1억, 상수에 붙은 _는 인식을 안해서 숫자 구분하기에 용이하다.
    }



}
