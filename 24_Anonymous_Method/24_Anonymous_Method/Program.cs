using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Anonymous_Method
{
    /* delegate 키워드는 델리게이트 타입을 정의할 때 사용하거나 무명 메서드를 정의할 때도 사용된다.
     * 미리 정의된 메서드들과 달리 메서드를 미리 정의하지 않아도 되는 메서드명이 없는 무명 메서드를 지원한다.
     * 어떤 메서드가 일회용으로 단순하게 구성되어 있다면 별도의 메서드를 정의하지 않아도 된다.
     * 
     * 무명 메서드를 사용하기 위해서는 메서드가 필요한 곳에 직접 delegate로 시작하는 무명 메서드를 사용하면 된다.
     * 1. 무명 메서드를 델리게이트 변수에 할당하여 사용
     * 2. 메서드의 파라미터에 인라인 형식으로 무명 메서드 사용
     * 3. 이벤트 핸들러를 추가하는 곳에 무명메서드를 사용할 수 있다.
     * 
     * 무명 메서드는 이름이 없는 메서드 자체만을 가리키며 그 자체로 Delegage 타입이 되는 것은 아니다.
     * 따라서 델리게이트 타입을 사용해야 하는 곳에 무명메서드만 직접 사용할 경우 컴파일 에러가 발생할 수 있다.
     */
    class Program
    {
        delegate int OperateDelegate(int a, int b);
        static void print(int num, int num2, OperateDelegate method)
        {
            int result = method.Invoke(num, num2);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            //메서드의 파라미터에 인라인 형식으로 무명 메서드 사용
            print(10, 20, delegate (int a, int b)
            {
                return a + b;
            });

            //OperateDelegate op_plus = new OperateDelegate(선언된 method); -> 이것을 무명 메서드 형식으로 사용한다.
            //무명 메서드를 델리게이트 변수에 할당하여 사용
            OperateDelegate op_plus;
            op_plus = delegate (int a, int b)
            {
                return a + b;
            };
            OperateDelegate op_minus;
            op_minus = delegate (int a, int b)
            {
                return a - b;
            };

            print(10, 20, op_plus);
            print(10, 20, op_minus);


        }
    }
}
