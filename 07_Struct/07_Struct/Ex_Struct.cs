using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Struct
{
    /* 구조체 (Struct) */
    /* 
     * 1. 구조체를 사용하면 Value type을 만들며 Class를 사용하면 Reference type을 만든다.
     * 2. Value type의 파라미터는 데이터를 복사하여 전달하므로 원래 값의 변동이 일어나지 않는다.
     * 3. 클래스와 같이 메서드, 프로퍼티 등 비슷한 구조를 가지지만 상속은 불가능하다. 
     * 4. 인터페이스의 구현은 가능하다.
     * 5. Class와 달리 상대적으로 가벼운 오버헤드를 가지므로 구조체가 필요할 수 있다.
    */
    public class Ex_Struct
    {
        public struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return string.Format("({0}, {1})", x, y);
            }
        }

        public void test_point()
        {
            Point pt = new Point(5, 3);
            Console.WriteLine(pt.ToString());
        }
    }
}
