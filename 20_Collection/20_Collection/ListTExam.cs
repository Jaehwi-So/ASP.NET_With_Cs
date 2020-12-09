using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Collection
{
    public class ListTExam
    {
        public List<int> list = new List<int>();    //동적 배열 List<T> 선언, Generics로 동적배열을 지원한다.

        public void test()
        {
            list.Add(100);
            list.Add(200);  //엘리먼트 추가
            Console.Write(list[1]);
            int i = list[0];   //ArrayList와 달리 캐스팅하지 않아도 된다.
            Console.Write(i);
        }
    }
}
