using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Class_Indexer
{
    class ExClass
    {
        private const int MAX = 10;
        private int[] data = new int[MAX];

        //클래스 객체의 데이터를 배열 형태로 인덱스를 사용하여 엑세스 할 수 있도록 해준다. 
        //클래스 객체는 배열이 아님에도 불구하고 배열처럼 []를 사용하여 클래스 내의 데이터의 특정 인덱스를 엑세스할 수 있다.

        //인덱서 정의.
        //this[]를 사용하여 클래스 속성(프로퍼티)처럼 get과 set을 정의한다.
        public int this[int idx]
        {
            get
            {
                if (idx < 0 || idx >= MAX)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return data[idx];
                }
            }

            set
            {
                if (!(idx < 0 || idx >= MAX))
                {
                    data[idx] = value;
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ExClass exclass = new ExClass();
            exclass[0] = 100;
            exclass[5] = 200;

            Console.Write(exclass[5]);
        }
    }
}
