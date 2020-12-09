using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Yield
{
    class Program
    {
        //yield 키워드는 호출자에게 컬렉션 데이터를 하나씩 리턴할 때 사용한다. Enumerator(Iterator)이라고 불리는 해당 기능은 집합적인 데이터셋에서 데이터를 하나씩 호출자에게 보내준다.
        //yield return과 yield break의 방식이 있는데 yield return은 컬렉션 데이터를 하나씩 리턴할 때 사용하며 yield break는 리턴을 중지하고 iteration 루프를 빠져 나올 때 사용한다.

        //Enumerator은 데이터 요소를 하나씩 리턴하는 기능. IEnumberator라는 인터페이스를 구현해야 한다.
        //IEnumerator 인터페이스는 Current (속성), MoveNext() (메서드), Reset() (메서드) 등 3개의 멤버로 구성
        //Enumerator가 되기 위해서는 Current와 MoveNext() 를 반드시 구현해야 한다.
        //컬렉션 클래스와 같이 Enumeration이 가능한 클래스를 Enumerable 클래스라고 부른다.
        //IEnumerable 인터페이스는 GetEnumerator() 라는 메서드를 가지고 있는데 GetEnumerator()는 IEnumerator를 구현한 객체를 리턴한다.
        //컬렉션 타입 혹은 Enumerable 클래스에서 GetEnumerator() 메서드를 구현하는 한 방법으로 yield 를 사용할 수 있다

        public int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public IEnumerable<int> getNumber() 
        {
            int i = 0;
            while (i < data.Length)
            {
                if (data[i] > 10)
                {
                    yield break;
                }
                else
                {
                    yield return data[i];
                }
                i++;
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            foreach (var item in program.getNumber())
            {
                Console.WriteLine(item);
            }

        }
    }
}
