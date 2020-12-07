using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operator
{
    class Ex_Operator
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            int? res = 0;

            /* 산술연산 */
            // { +, - *, / % }
            res = a + b + c;
            System.Console.WriteLine(res);

            /* 할당연산 */
            // { =, +=, -=, *=, /=, %= }
            res += a;
            System.Console.WriteLine(res);

            /* 증감연산 */
            // { ++, -- }
            res++;
            System.Console.WriteLine(res);

            /* 관계, 비교연산 */
            // { <, >, ==, !=, >=, <= }
            /* 논리연산 */
            // { &&, ||, !)
            bool result = (a > 5) && ((b < 25) || !(c < 25));
            System.Console.WriteLine(result);

            /* 비트연산 */
            //{ &, |, ^ }
            res = a & b;
            System.Console.WriteLine(res);

            /* 시프트 연산*/
            //{ << , >> }
            res = res << 1;
            System.Console.WriteLine(res);

            /* 조건 연산 */
            // { ?, ?? }
            res = (a > b) ? a : b;
            System.Console.WriteLine(res);

            // ??연산 : 값이 null일 시 피연산자 값을 return
            res = res ?? 0;
            System.Console.WriteLine(res);
            int? nullVal = null;
            res = nullVal ?? 0;
            System.Console.WriteLine(res);
        }
    }
}
