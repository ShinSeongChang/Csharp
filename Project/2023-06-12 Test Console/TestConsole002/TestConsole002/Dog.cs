using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Cat
{
    private int legCount;
    private string catName;
    private string catColor;

    public Cat(int legCount_, string catName_, string catColor_)
    {
        // 구조체(클래스) 자신과 동일한 이름을 가진 메서드가 있다.
        // 생성자와 소멸자라고 한다.
        // 특징은 자신과 이름이 똑같고, 리턴 타입이 전혀 없다.
        legCount = legCount_;
        catName = catName_;
        catColor = catColor_;
    }

    public void Print_MyCat()
    {
        Console.WriteLine("우리집 고양이 이름은 {0} 이고, 색은 {1} 이다.", catName, catColor);
    }
}

namespace TestConsole002
{

    public class Dog
    {
        // 접근 제한자, 접근 지정자
        // public, protected, private
        // public = > 외부에서 데이터 접근이 가능.
        // private = > 외부에서 데이터 접근이 불가능하게 한다.

        public int legCount = 4;
        public string dogName = "멍멍이";
        private string dogColor = "하얀색";
        private string dogSound = "왈크왈크";

        public void Print_DogDescription()
        {
            Console .WriteLine("강아지 색은 {0} 이고, 짖는 소리는 {1} 이다.",
                dogColor, dogSound);
        }       // private 변수를 public  함수에 집어넣고 public 함수를 호출한다면?

        public static void Print_DogDescription002()
        {
            Console.WriteLine("강아지 이름은 {0} 이고, 색상은 {1} 이다.", "모름", "모른다");
        }
    }
}
