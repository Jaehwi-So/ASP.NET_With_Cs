using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Dynamic_Language
{
    /* Dynamic Language
     * C#은 기본적으로 정적 언어이지만 4.0부터 Dynamic 요소가 추가됨.
     * dynamic 키워드는 변수의 Type을 체크하지 않고 런타임시까지는 해당 타입을 알 수 없음을 표시한다.
     * 내부적으로 dynamic 타입은 object타입을 사용하여 중간에 다른 타입의 값을 가질 수 있다.
     * object 타입과의 차이점은 캐스팅 없이 직접 실제 타입의 메서드와 속성을 사용할 수 있다.
     */
    class Program
    {
        public void Test()
        {
            //익명타입은 한 번 생성된 후 다시 새로운 속성을 추가할 수 없다.
            //익명타입 자체가 메서드 이벤트 등을 가지지 못한다.
            dynamic t = new { Name = "Kim", Age = 25 };

        }

        static void Main(string[] args)
        {
            //Object : 캐스팅 필요
            object num1 = 20;
            num1 = (int)num1 + 20;

            //dynamic : 캐스팅이 필요없음.
            dynamic num2 = 20;
            num2 = num2 + 20;

            //형 변환 가능
            dynamic v1 = 10;
            v1 = "aaa";

            //var : 데이터 타입을 개발자가 아닌 컴파일러가 결정하게 한다.
            var num3 = 20;
            int b = num3;   //num3 == int
            //num3 = "hello" 에러

        }
    }
}
