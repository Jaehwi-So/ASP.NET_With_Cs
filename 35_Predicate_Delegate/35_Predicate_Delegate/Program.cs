using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Predicate_Delegate
{
    class Program
    {
        public static void Start(int num, Predicate<int> method)
        {
            bool isEven = method.Invoke(num);
            Console.WriteLine(isEven);
        }
        public static void Run()
        {
            //Predicate<T> : 입력값이 T타입 한 개이며 반환형이 boolean인 Delegate.
            //주로 .NET의 Array나 List 클래스에서 주로 사용된다. (Func는 Linq에서 많이 사용된다.)

            // 1. 기존 메서드 지정
            Predicate<int> act = isEven;
            Console.WriteLine(act(4));

            // 2. 무명 메서드 지정
            Predicate<int> act2 = delegate (int num)
            {
                if (num % 2 == 0 && num != 0)
                    return true;
                else
                    return false;
            };
            Start(23, act2);  //Action Delegate를 메서드 파라미터로 전달

            // 3. 람다식 사용
            Predicate<int> act3 = (num) =>
            {
                if (num % 2 == 0 && num != 0)
                    return true;
                else
                    return false;
            };
            Start(343, act3);
        }

        static bool isEven(int num)
        {
            if (num % 2 == 0 && num != 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}
