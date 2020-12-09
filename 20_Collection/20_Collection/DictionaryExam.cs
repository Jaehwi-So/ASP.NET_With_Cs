using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Collection
{
    public class DictionaryExam
    {
        //Dictionary은 key와 value의 쌍을 가진 집합 자료구조
        public Dictionary<int, string> map = new Dictionary<int, string>();

        public void test()
        {
            map.Add(1, "kim");
            map.Add(2, "lee");
            map[3] = "park";    //key, value의 쌍으로 데이터 추가

            //Hashtable과 달리 Dictionary는 Generic 타입을 명시하여 박싱/언박싱의 필요성이 없다.
            Console.WriteLine(map[1]);  //키를 통해 데이터를 가져옴
            Console.WriteLine(map[2]);  //키를 통해 데이터를 가져옴
            Console.WriteLine(map[3]);  //키를 통해 데이터를 가져옴
        }
    }
}
