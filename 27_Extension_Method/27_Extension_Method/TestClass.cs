using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Extension_Method
{
    public static class TestClass
    {
        //확장 메서드는 정적 클래스에서만 정의할 수 있다.
        //정적 메서드처럼 정의하면서 사용은 인스턴스 메서드처럼 한다.
        //확장 메서드를 선언하면 마치 다른 클래스의 인스턴스 메서드인 것 처럼 사용되는 기능을 제공할 수 있다.

        //String 클래스의 인스턴스 메서드인 것 처럼 사용되는 확장 메서드
        public static string ExchangeA(this String str)  //현재 인스턴스의 string을 매개변수로 받아 반환(str.exchange() 시 str이 this). 
            
        {
            return str.Replace("a", "A");
        }
    }
}
