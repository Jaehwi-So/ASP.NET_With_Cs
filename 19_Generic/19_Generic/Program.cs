using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 일반적으로 클래스를 정의할 때 클래스 내의 데이터 타입을 지정해준다.
 * 하지만 어떤 경우에는 클래스의 거의 모든 부분이 동일하지만 일부 데이터 타입만이 다를 수 있다.
 * 이를 제네릭 타입으로 설정하여 여러개의 클래스를 따로 만들지 않아도 되도록 한다.
 * 클래스 이외에 인터페이스나 메서드에도 적용될 수 있다.
*/
namespace _19_Generic
{
    public class TestClass<T1, T2>
    {
        public T1 element1;
        public T2 element2;
        public TestClass(T1 element1, T2 element2)
        {
            this.element1 = element1;
            this.element2 = element2;
        }
        public void getInfo()
        {
            Console.WriteLine(this.element1.GetType() + " " + this.element2.GetType());
        }
    }

    public class AnotherClass<T1, T2> //다음과 같이 제네릭 타입의 제약조건을 걸 수 있다.
        where T1: struct
        where T2 : IComparable //, ...
    {
        public T1 element1;
        public T2 element2;
        public AnotherClass(T1 element1, T2 element2)
        {
            this.element1 = element1;
            this.element2 = element2;
        }
        public void getInfo()
        {
            Console.WriteLine(this.element1.GetType() + " " + this.element2.GetType());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass<int, string> test1 = new TestClass<int, string>(10, "hello");

            int[] arr = { 1, 2, 3, 4 };
            TestClass<double, int[]> test2 = new TestClass<double, int[]>(16.5, arr);

            test1.getInfo();
            test2.getInfo();
        }
    }
}
