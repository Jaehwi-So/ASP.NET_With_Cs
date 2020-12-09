using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Method
{
    public class TestClass
    {
        //pass by value : 값을 복사하여 전달받음. 메서드 안에서만 값의 변경이 이루어진다.
        public void increase(int a)
        {
            a++;
        }

        //pass by reference : 참조값을 전달하여 메서드 내에서 변경된 값은 메서드를 빠져나와도 유효하다.
        public void plus(ref int a, out int b)
        {
            a++;
            b = a;  //out은 메서드를 빠져나가기 전 초기화가 이루어져야 한다.
        }

        public void print(string name, string age)
        {
            Console.WriteLine(name + " " + age);

        }

        //Optional한 파라미터를 사용할 시 optional이 아닌 파라미터들 뒤에 놓여져야 한다.
        public double calc(int a, int b, string op = "+")
        {
            switch (op)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    return 0;
            }
        }

        //params 키워드는 가변적인 배열을 인수로 가질 수 있도록 한다. 파라미터들 중 반드시 하나만 존재해야 하며 맨 마지막에 위치해야 한다.
        public int all_plus(params int[] values)
        {
            int sum = 0;
            foreach(int number in values){
                sum += number;
            }
            return sum;
        }

        public void test()
        {
            //pass by value
            int number = 3;
            increase(number);
            Console.WriteLine(number);  //3

            //pass by reference
            int a = 1;  //ref 사용, 초기화가 필요하다.
            int b;  //out 사용, 선언 후 초기화를 하지 않아도 된다.
            plus(ref a, out b);
            Console.WriteLine(a + " " + b); //2 2

            //Named 파라미터
            print(age: "15", name: "kim");  //파라미터의 순서를 따지지 않고 파라미터명을 지정하여 인수를 전달할 수 있다.

            //Optional 파라미터
            Console.WriteLine(calc(10, 20));
            Console.WriteLine(calc(10, 20, "*"));

            //params를 사용하여 가변적인 파라미터의 개수 사용이 가능.
            Console.WriteLine(all_plus(1, 2, 3, 4));
            Console.WriteLine(all_plus(4, 8, 9, 45, 44, 12));

        }
    }
}
