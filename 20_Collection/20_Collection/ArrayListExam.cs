using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Collection
{
    public class ArrayListExam
    {
        public ArrayList list = new ArrayList();    //동적 배열 ArrayList 선언

        public void test()
        {
            list.Add(10);
            list.Add("hello");  //엘리먼트 추가
            Console.Write(list[1]);
            int i = (int)list[0];   //ArrayList는 엘리먼트를 읽어 사용할 때 objet를 리턴하므로 타입 캐스팅한 후 사용
            Console.Write(i);
            list.RemoveAt(1);   //엘리먼트 삭제
        }
    }
}
