using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_06_15_Test_Console
{
    public class Property
    {
        private string itemName;
        public int itemCount { get; private set; }      // => get은 외부에서 데이터를 확인(public형) , set은 private이라 외부에서는 해당 데이터 수정이 불가능
                           // get은 변수명 앞에 public이 자동으로 입력된것. 
                                                        // 마치 스위치를 키면 불이 들어오고 스위치를 내리면 불이 꺼지는듯한 모습
                                                        // get ==> 외부에서 데이터를 참조만 가능 , private set ==> 하지만 수정은 불가능

        private int itemPrice;
        public int ItemPrice
        {
            get
            {
                return itemPrice;
            }

            private set
            {
                itemPrice = value;
            }
        }


        // ! private 아이템 name을 Return 해보겠음.
        public string Get_ItemName()        // get => 외부에서 데이터를 확인 할때
        {
            return itemName;
            // 값을 반환하면 그 값은 메모리에 저장된다.
        }

        //! private 아이템 name을 외부에서 변경할 수 있게 해주겠음.
        public void Set_ItemName(string changeName)     // set => 외부에서 데이터를 바꾸고 싶을때
        {
            itemName = changeName;

            // SET_ItemName()
        }

        // 변수선언에서 get, set을 사용하겠다면
        // public itemName { get; private set; }  ==> 
        //
    
    }
}
