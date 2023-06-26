using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 개별과제
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GameIntro gamestart = new GameIntro();
            gamestart.GameStart();

        }
    }
}

// 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임.
// 1. 컴퓨터는 비밀 코드를 하나 램덤하게 선정한다. 비밀 코드는 아스키 코드로 이루어져 있다.
// 2. 유저는 Input 입력해서 비밀 코드가 어떤건지 추측한다.
// 3. 컴퓨터는 유저의 추측을 보고 비밀 코드가 유저의 추측보다 앞에 있는지, 뒤에 있는지 알려준다.
// 4. 몇 번만에 맞추는지에 따라서 점수를 부여한다.
// 5. 유저가 코드를 맞추면 게임을 종료한다.

// - 클래스를 활용해서 구현한다.
// ex) SecretCode mySecretCode = new SecretCode();
//      mySecretCode.Play();
