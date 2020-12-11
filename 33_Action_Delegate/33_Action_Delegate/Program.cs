using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Action_Delegate
{
    class Program
    {
        public static void Start(string str, Action<string> method)
        {
            method.Invoke(str);
        }
        public static void Run()
        {
            // Action<T> : 하나의 파라미터를 받아들이고 반환값이 없는 함수에 사용되는 Delegate이다..
            // Action<T1, T2> : 파라미터 T1, T2를 받아들이고 반환값이 없는 함수에 사용되는 Delegate이다..
            // 입력  : T 타입
            // 리턴갑 : 없음

            // 1. 기존 메서드 지정
            Action<string> act = Print;
            act("Hello");

            // 2. 무명 메서드 지정
            Action<string> act2 = delegate (string str)
            {
                Console.WriteLine(str);
            };
            Start("Hello2", act2);  //Action Delegate를 메서드 파라미터로 전달

            // 3. 람다식 사용
            Action<string> act3 = (str) => Console.WriteLine(str);
            Start("Hello3", act3);
        }

        static void Print(string str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
