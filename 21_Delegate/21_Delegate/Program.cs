using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* # Delegate
 * 메서드를 다른 메서드의 인자로 전달할 수 있도록 하기 위해서 만들어졌다.
 * 
 */
namespace _21_Delegate
{
    class Program
    {
        //델리게이트 정의하기.
        //메서드 원형과 입력 파라미터 타입과 갯수, 리턴 타입이 동일하다면 해당 메서드는 해당 델리게이트에서 사용될 수 있다.
        //메서드 파라미터와 리턴 타입에 대한 정의를 한 후 동일한 파라미터와 리턴 타입을 가진 메서드를 서로 호환하여 불러쓰는 것이 가능하다.
        delegate int MyDelegate(int num, int num2);
        void print(int num, int num2, MyDelegate method)
        {
            int result = method.Invoke(num, num2);  //Invoke() : 전달된 delegate로부터 실제 메서드 호출
            Console.WriteLine(result);
        }
        public int plus(int num, int num2)
        {
            return num + num2;
        }

        public int minus(int num, int num2)
        {
            return num - num2;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            MyDelegate operate = new MyDelegate(p.plus);  //델리게이트 객체 생성. 
            p.print(10, 20, operate); //델리게이트를 다른 메서드로 전달. 델리게이트 객체를 인수로 넣는다.

            operate = p.minus;  //이와 같이 delegate 인스턴스를 표현 가능하다.
            p.print(10, 20, operate);

            //Delegate 예제
            SortClass sort = new SortClass();
            int[] array = { 7, 5, 15, 94, 32, 45, 77, 79, 5, 24, 12, 11, 8, 26 };
            sort.test(array);
        }
    }
}
