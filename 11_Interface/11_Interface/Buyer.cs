using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface
{
    public interface Buyer
    {
        //int a = 0; 인터페이스는 필드 포함 불가능
        void init();
        void buy();  //인터페이스의 메서드에는 접근 제어자를 사용하지 않는다.
        void order();
    }
}
