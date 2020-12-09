using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Static
{
    //static 클래스
    //모든 클래스 멤버가 static, public 생성자를 가질 수 없다.(객체를 생성할 수 없음). 대신 static 생성자를 가질 수 있다.
    //static 생성자는 static 필드들을 초기화 할 때 사용된다.
    public static class StaticClass
    {
        private static int number;
        static StaticClass()    //static 생성자에는 매개변수가 없어야 한다.
        {
            number = 10;
        }

        public static void hello()
        {
            Console.WriteLine("Hello " + number);
        }
    }
}
