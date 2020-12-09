using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Static
{
    public class StaticTestClass
    {
        //정적(스태틱) 필드 및 속성 : 클래스 인스턴스를 생성할 때 마다 메모리에 새로 생성되는 것이 아닌 처음으로 클래스가 사용될 때 초기화되어 계속 동일한 메모리를 사용한다.
        protected static int name;
        public static string Name { get; set;}
        //인스턴스 메서드
        public void no_static()
        {
            Console.WriteLine("no static method");
        }

        //정적 (스태틱) 메서드
        //메서드 내부에서 클래스의 인스턴스 객체 멤버를 참조할 수 없다.
        public static void method_static()
        {
            Console.WriteLine("static method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StaticTestClass static_test = new StaticTestClass();
            //인스턴스 메서드 호출
            static_test.no_static();
            //static_test.method_static(); 인스턴스 객체로부터 호출될 수 없다.

            //스태틱 메서드 호출
            StaticTestClass.method_static();

            //스태틱 속성, 필드 사용
            StaticTestClass.Name = "kim";

            //스태틱 클래스 사용
            StaticClass.hello();
        }
    }
}
