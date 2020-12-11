using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Func_Delegate
{
    class Program
    {
        public static void Start(string str, Func<string, string> method)
        {
            string result = method.Invoke(str);
            Console.WriteLine(result);
        }
        public static void Run()
        {
            // Func<T1> : 인수가 없고 T1타입을 반환하는 함수에 사용되는 Delegate
            // Func<T2, T1> : 하나의 T2타입 파라미터를 받아들이고 T1타입을 반환하는 함수에 사용되는 Delegate

            // 1. 기존 메서드 지정
            Func<string, string> act = AddString;
            Console.WriteLine(act("Hello"));

            // 2. 무명 메서드 지정
            Func<string, string> act2 = delegate (string str)
            {
                return "ADDSTRING " + str;
            };
            Start("Hello2", act2);  //Action Delegate를 메서드 파라미터로 전달

            // 3. 람다식 사용
            Func<string, string> act3 = (str) => "ADDSTRING " + str;
            Start("Hello3", act3);
        }

        static string AddString(string str)
        {
            return "ADDSTRING " + str;
        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}
