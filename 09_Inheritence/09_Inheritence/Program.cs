using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Inheritence
{
    class Parent { }
    class Child : Parent { }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 15);
            Square square = new Square(10);
            Console.WriteLine(rectangle.showInfo());
            Console.WriteLine(square.showInfo());

            //as 연산자와 is 연산자
            Child child = new Child();
            Parent new_ch = child as Parent; //as 연산자는 객체를 지정된 클래스 타입으로 변환한다. 성공하면 캐스팅하며 실패하면 null을 반환한다.

            bool ok = new_ch is Parent; //is 연산자는 객체가 특정 클래스 타입이나 인터페이스를 가지는지를 확인한다.
            Console.WriteLine(ok);
        }
    }
}
