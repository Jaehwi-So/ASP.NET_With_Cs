using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Lambda_Express
{
    /* 람다식(Lambda Express)
     * 무명 메소드를 단순한 계산식으로 표현한 것.
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
            /* 무명 메서드 사용 */
            OperateDelegate op_plus;
            op_plus = delegate (int a, int b)
            {
                return a + b;
            };
            print(10, 20, op_plus);

            /* 람다식 사용 */
            OperateDelegate op_minus;
            op_minus = (int a, int b) => a - b; //단순한 계산식 : 자동으로 해당 값 반환

            OperateDelegate op_multiply;
            op_multiply = (a, b) => //매개변수의 타입또한 생략 가능. Delegate의 타입을 보고 컴파일러가 유추한다.
            {
                // ... Code block...
                return a * b;
            };
            print(10, 20, op_minus);
            print(10, 20, op_multiply);
        }
    }
}
